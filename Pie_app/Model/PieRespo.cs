using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie_app.Model
{
    public class PieRespo : IPieRespo
    {
        public readonly AppDbContext _appDbContext;
        public PieRespo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pie> GetAllPies()
        {
            return _appDbContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDbContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
