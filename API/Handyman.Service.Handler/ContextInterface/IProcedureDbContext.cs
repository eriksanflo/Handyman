using Handyman.Domain.Procedures;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.ContextInterface
{
    public interface IProcedureDbContext
    {
        Task<List<SubcategoryInfoResult>> GetSubcategoryInfoAsync(int idSubcategory, DateTimeOffset locationDate);
        Task<List<PartScheduleResult>> GetPartScheduleAsync(string idPart);
    }
}
