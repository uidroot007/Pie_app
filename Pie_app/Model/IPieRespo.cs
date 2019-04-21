using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie_app.Model
{
    public interface IPieRespo
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}
