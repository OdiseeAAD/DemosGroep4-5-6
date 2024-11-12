using DemoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Repositories
{
    public class UnitOfWork
    {
        private DemoEFDataContext dbContext = new DemoEFDataContext();

        public PersoonRepositoryWithUOW PersoonRepository { get; private set; }
        public WoonplaatsRepository WoonplaatsRepository { get; private set; }
        private static UnitOfWork instance;


        // singleton patroon
        public static UnitOfWork Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UnitOfWork();
                }
                return instance;
            }
        }

        private UnitOfWork()
        {
            dbContext.Database.EnsureCreated();
            PersoonRepository = new PersoonRepositoryWithUOW(dbContext);
            WoonplaatsRepository = new WoonplaatsRepository(dbContext);

        }
    }
}
