using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pie_app.Model
{
    public class FeedBackReso : IFeedBackRespo
    {
        private readonly AppDbContext _appDbContext;
        public FeedBackReso(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddFeedback(FeedBack feedback)
        {
            _appDbContext.FeedBacks.Add(feedback);
            _appDbContext.SaveChanges();
        }
    }
}
