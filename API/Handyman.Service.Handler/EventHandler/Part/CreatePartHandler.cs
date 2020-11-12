using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Part;
using Handyman.Service.Handler.ContextInterface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Part
{
    public class CreatePartHandler : IRequestHandler<CreatePartCommand, CreatePartResult>
    {
        private readonly IApplicationDbContext _contex;

        public CreatePartHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<CreatePartResult> Handle(CreatePartCommand request, CancellationToken cancellationToken)
        {
            var result = new CreatePartResult();
            try
            {
                var part = await Build(request);
                result.Parte = new PartAffectedResult
                {
                    IdParte = part.IdParte,
                    Roles = part.ParteRole.Select(x => 
                    new ParteRoleResult() 
                    {
                        IdParteRole = x.IdParteRole,
                        IdTipoParteRole = x.IdTipoParteRole.Value,
                    }).ToList(),
                };
                result.SetSuccess();
            }
            catch (Exception ex)
            {
                result.BuildBadRequest(ex.Message);
            }
            return result;
        }
        private async Task<Parte> Build(CreatePartCommand request)
        {
            var isNew = request.IdParte == Guid.Empty || !ExistsPart(request.IdParte);
            var domain = isNew ? new Parte() : Get(request.IdParte);
            domain.IdParte = isNew ? Guid.NewGuid() : request.IdParte;
            AttachPerson(domain, request);
            AttachCompany(domain, request);
            AttachRole(domain, request.IdTipoRole);

            if (isNew)
                _contex.Parte.Add(domain);
            return await Task.FromResult(domain);
        }
        private void AttachPerson(Parte domain, CreatePartCommand request)
        {
            if (!request.IsPerson) return;

            if (domain.Persona == null)
                domain.Persona = new Persona();

            domain.Persona.Codigo = GetCode(request.NombrePrimario, request.Paterno, request.Materno);
            domain.Persona.Paterno = request.Paterno;
            domain.Persona.Materno = request.Materno;
            domain.Persona.NombrePrimario = request.NombrePrimario;
            domain.Persona.NombreSecundario = request.NombreSecundario;
            domain.Persona.FechaNacimiento = request.FechaNacimiento;
            domain.Persona.LugarNacimiento = request.LugarNacimiento;
            domain.Persona.FechaModificacion = DateTimeOffset.Now;
            domain.Persona.TituloActual = request.TituloActual;
            domain.Persona.Genero = request.Genero;
            domain.Persona.Estatura = request.Estatura;
            domain.Persona.Peso = request.Peso;
            domain.Persona.Activo = request.Activo;
            if (domain.Persona.FechaCreacion == null)
                domain.Persona.FechaCreacion = DateTimeOffset.Now;
        }
        private void AttachCompany(Parte domain, CreatePartCommand request)
        {
            if (request.IsPerson) return;

            if (domain.Organizacion == null)
                domain.Organizacion = new Organizacion();
            domain.Organizacion.Nombre = request.NombreOrganizacion;
        }
        private void AttachRole(Parte domain, int idRoleType)
        {
            if (!domain.ParteRole.Any(x => x.IdTipoParteRole == idRoleType && x.FechaFinal == null))
                domain.ParteRole.Add(
                    new ParteRole 
                    { 
                        IdTipoParteRole = idRoleType,
                        FechaInicial = DateTime.Now,
                    }
                );
        }
        private bool ExistsPart(Guid idPart) => _contex.Parte.Any(x => x.IdParte == idPart);
        private Parte Get(Guid id) =>
            _contex.Parte
            .Include(x => x.ParteRole)
            .Include(x => x.Persona)
            .Include(x => x.Organizacion)
            .Single(x => x.IdParte == id);
        private string GetCode(string name, string lastname = null, string motherLastname = null)
        {
            var characters = string.Empty;
            if (!string.IsNullOrEmpty(name))
            {
                if (lastname == null && motherLastname == null && name.Length > 1)
                    characters += name.Substring(0, 2);
                else
                    characters += name.Substring(0, 1);
            }                
            if (!string.IsNullOrEmpty(lastname))
                characters += name.Substring(0, 1);
            if (!string.IsNullOrEmpty(motherLastname))
                characters += name.Substring(0, 1);
            characters += "HM";
            return characters.Substring(0, 2).ToUpper();
        }
    }
}
