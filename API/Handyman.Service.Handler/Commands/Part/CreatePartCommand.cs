using Handyman.Service.Handler.Common.Info;
using Handyman.Service.Handler.Result;
using MediatR;
using System;
using System.Collections.Generic;

namespace Handyman.Service.Handler.Commands.Part
{
    public class CreatePartCommand : PersonInfo, IRequest<CreatePartResult>
    {
        public bool IsPerson { get; set; }
        public int IdTipoRole { get; set; }
        public string NombreOrganizacion { get; set; }
    }

    public class CreatePartResult : BaseResult
    {
        public PartAffectedResult Parte { get; set; }
    }

    public class PartAffectedResult
    {
        public Guid IdParte { get; set; }
        public List<ParteRoleResult> Roles { get; set; }

    }
    public class ParteRoleResult
    {
        public int IdTipoParteRole { get; set; }
        public int IdParteRole { get; set; }
    }
}
