using Handyman.Domain.Procedures;
using Handyman.Service.Handler.ContextInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Handyman.Persistence
{
    public class ProceduresDbContext : DbContext, IProcedureDbContext
    {
        public ProceduresDbContext(DbContextOptions<ProceduresDbContext> options) : base(options)
        {
        }

        #region Internal
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubcategoryInfoResult>().HasNoKey();
            modelBuilder.Entity<PartScheduleResult>().HasNoKey();
        }
        #endregion

        #region Stored Procedures DbSets
        public virtual DbSet<SubcategoryInfoResult> GetSubcategoryInfo { get; set; }
        public virtual DbSet<PartScheduleResult> GetPartSchedule { get; set; }
        #endregion

        #region Stored Procedures Definition
        public async Task<List<SubcategoryInfoResult>> GetSubcategoryInfoAsync(int idSubcategory, DateTimeOffset locationDate)
        {
            return await GetSubcategoryInfo.FromSqlRaw($"GetSubcategoryInfo {idSubcategory}, '{locationDate}'").ToListAsync();
        }
        public async Task<List<PartScheduleResult>> GetPartScheduleAsync(string idPart)
        {
            return await GetPartSchedule.FromSqlRaw($"GetPartSchedule '{idPart}'").ToListAsync();
        }
        #endregion
    }
}
