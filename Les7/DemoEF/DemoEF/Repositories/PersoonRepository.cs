using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Repositories
{
    public class PersoonRepository
    {
       

        public void Create(string firstname, string lastname, DateTime birthDate)
        {
            using (DemoEFDataContext dbContext = new DemoEFDataContext())
            {
                Persoon p = new Persoon(firstname, lastname, birthDate);
                dbContext.Personen.Add(p);
                dbContext.SaveChanges();
            }
         
        }

        public List<Persoon> GetAllPersonen()
        {
            using (DemoEFDataContext dbContext = new DemoEFDataContext())
            {
                return dbContext.Personen.ToList();
            }
        }

        public Persoon? FindPersoonById(int id)
        {
            using (DemoEFDataContext dbContext = new DemoEFDataContext())
            {
                return dbContext.Personen.FirstOrDefault(persoon => persoon.Id == id);
            }
        }

        public void Update(Persoon persoon)
        {
            using (DemoEFDataContext dbContext = new DemoEFDataContext())
            {
                dbContext.Update(persoon);
                dbContext.SaveChanges();
            }
        }

        public void Delete(Persoon persoon)
        {
            using (DemoEFDataContext dbContext = new DemoEFDataContext())
            {
                //dbContext.Personen.Remove(persoon);
                dbContext.Remove(persoon);
                dbContext.SaveChanges();
            }
        }

    }
}
