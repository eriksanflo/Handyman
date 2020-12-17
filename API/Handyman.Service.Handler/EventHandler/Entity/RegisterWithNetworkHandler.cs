using Handyman.Domain.Models;
using Handyman.Service.Handler.Commands.Entity;
using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.ContextInterface;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.EventHandler.Entity
{
    public class RegisterWithNetworkHandler : IRequestHandler<RegisterWithNetworkCommand, BaseResult>
    {
        private readonly IApplicationDbContext _contex;
        public RegisterWithNetworkHandler(IApplicationDbContext contex)
        {
            _contex = contex;
        }
        public async Task<BaseResult> Handle(RegisterWithNetworkCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResult();
            try
            {
                var domain = new Parte();
                domain.IdParte = Guid.NewGuid();
                AttachPerson(domain, request.Person);
                AttachAccess(domain, request.User, request.Password, request.Provider);
                _contex.Parte.Add(domain);
                await _contex.SaveChangesAsync();
                response.SetSuccess();
            }
            catch (ArgumentNullException arr)
            {
                response.BuildBadRequest(arr.Message);
            }
            catch (Exception ex)
            {
                response.BuildBadRequest(ex.Message);
            }
            return response;
        }
        private void AttachPerson(Parte domain, PersonInfo request)
        {
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
        private void AttachAccess(Parte domain, string user, string pass, string provider)
        {
            var access = new Accesos()
            {
                Usuario = user,
                Password = pass,
                Activo = true,
            };
            domain.Accesos.Add(access);          
        }
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
