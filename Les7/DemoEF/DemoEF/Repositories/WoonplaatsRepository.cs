using DemoEF.Models;

namespace DemoEF.Repositories
{
    public class WoonplaatsRepository
    {
        private DemoEFDataContext dbContext;

        public WoonplaatsRepository(DemoEFDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}