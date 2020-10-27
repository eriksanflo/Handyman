using Handyman.Service.Handler.ContextInterface;
using Microsoft.EntityFrameworkCore;

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
        }
        #endregion

        #region Stored Procedures Definition

        #endregion
    }
}
