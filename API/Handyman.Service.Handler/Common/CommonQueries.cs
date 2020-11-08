using Handyman.Domain.Models;
using Handyman.Service.Handler.ContextInterface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Handyman.Service.Handler.Common
{
    public static class CommonQueries
    {
        public static DireccionPostalParte GetDireccionPostalParteByID(this IApplicationDbContext _context, int id)
        {
            return _context
                .DireccionPostalParte
                .Include(x => x.IdCodigoPostalNavigation)
                .Single(x => x.IdDireccionPostalParte == id);
        }
    }
}
