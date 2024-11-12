using DemoEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.Repositories
{
    public class PersoonRepositoryWithUOW
    {
        DemoEFDataContext dbContext;

        public PersoonRepositoryWithUOW(DemoEFDataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Create(string firstname, string lastname, DateTime birthDate)
        {
           
                Persoon p = new Persoon(firstname, lastname, birthDate);
                dbContext.Personen.Add(p);
                dbContext.SaveChanges();
           
         
        }

        public List<Persoon> GetAllPersonen()
        {
          
                return dbContext.Personen.ToList();
           
        }

        public Persoon? FindPersoonById(int id)
        {
          
                return dbContext.Personen.FirstOrDefault(persoon => persoon.Id == id);
            
        }

        public void Update(Persoon persoon)
        {
          
               
                dbContext.SaveChanges();
            
        }

        public void Delete(Persoon persoon)
        {
           
                //dbContext.Personen.Remove(persoon);
                dbContext.Remove(persoon);
                dbContext.SaveChanges();
            
        }

    }
}
