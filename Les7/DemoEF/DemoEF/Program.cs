using DemoEF.Models;
using DemoEF.Repositories;

namespace DemoEF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersoonRepository persoonRepository = new PersoonRepository();
            persoonRepository.Create("John", "Doe", new DateTime(1990, 1, 1));

            UnitOfWork.Instance.persoonRepository.Create("Jane", "Doe", new DateTime(1990, 1, 1));

            DemoEFDataContext dataContext1 = new DemoEFDataContext();
            DemoEFDataContext dataContext2 = new DemoEFDataContext();
            dataContext1.Database.EnsureDeleted();
            dataContext1.Database.EnsureCreated();
            Console.WriteLine("Databank gecreeerd");

            Persoon persoon = new Persoon("John", "Doe", new DateTime(1950, 1, 1));
            Woonplaats woonplaats = new Woonplaats();
            woonplaats.Straat = "Stormstraat";
            woonplaats.Gemeente = "Brussel";
            woonplaats.Huisnummer = "100";
            woonplaats.Postcode = 1000;
            Student student = new Student("Marie", "Doe", new DateTime(2000, 1, 1), "IT");
            student.Woonplaats = woonplaats;

            Docent docent = new Docent("Matthias", "Druwé", new DateTime(1990, 1, 1), "AAD");
            docent.Woonplaats = woonplaats;

            persoon.Woonplaats = woonplaats;
            dataContext1.Woonplaatsen.Add(woonplaats);
            dataContext1.Personen.Add(student);
            dataContext1.Personen.Add(docent);
            dataContext1.SaveChanges();
            dataContext2.Attach(woonplaats);
            dataContext2.Personen.Add(persoon);
            dataContext2.SaveChanges();

            foreach(Persoon p in dataContext2.Personen)
            {
                Console.WriteLine(p.GetType());
            }

            /*
                        Persoon persoon = new Persoon("John", "Doe", new DateTime(1950, 1, 1));

                        // Data Toevoegen
                        dataContext.Personen.Add(persoon);
                        dataContext.SaveChanges();

                        Console.WriteLine("Persoon toegevoegd!");

                        // Data Wijzigen
                        persoon.Voornaam = "Jef";
                        dataContext.SaveChanges();

                        Console.WriteLine("John wijzigd naam!");

                        // Data Opvragen
                        List<Persoon> personen = dataContext.Personen.ToList();

                        foreach (Persoon p in personen)
                        {
                            Console.WriteLine($"{p.Voornaam} - {p.Achternaam}");
                        }


                        // Voorbeeld disconnected context

                        Persoon persoon2 = new Persoon("Jane", "Doe", new DateTime(1970, 1, 1));

                        using(DemoEFDataContext context1 = new DemoEFDataContext())
                        {
                            context1.Personen.Add(persoon2);
                            Console.WriteLine(context1.Entry(persoon2).State);
                            context1.SaveChanges();

                            persoon2.Achternaam = "qwerty";
                            Console.WriteLine(context1.Entry(persoon2).State);
                            context1.SaveChanges();

                            //context1.Personen.Remove(persoon2);
                            //Console.WriteLine(context1.Entry(persoon2).State);
                            //context1.SaveChanges();
                        }

                        using(DemoEFDataContext context2 = new DemoEFDataContext())
                        {
                            Console.WriteLine(context2.Entry(persoon2).State);
                            persoon2.GeboorteDatum = new DateTime(1970, 1, 2);
                            context2.Update(persoon2);
                            context2.SaveChanges();
                        }*/
        }
    }
}
