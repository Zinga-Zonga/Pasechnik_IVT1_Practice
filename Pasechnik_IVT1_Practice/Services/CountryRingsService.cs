using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class CountryRingsService
    {
        //Create
        public void Add(CountryRing countryRing)
        {
            if (countryRing != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Country_Rings.Add(countryRing);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<CountryRing> GetList()
        {
            List<CountryRing> countryRings = new List<CountryRing>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                countryRings = db.Country_Rings.ToList();
                db.SaveChanges();
            }
            return countryRings;
        }
        public CountryRing GetById(int id)
        {
            CountryRing countryRing = new CountryRing();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                countryRing = (CountryRing)db.Country_Rings.Where(f => f.Id == id).First();


            }
            return countryRing;
        }
        //Delate
        public void Delate(CountryRing countryRing)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Rings.Remove(countryRing);
                db.SaveChanges();
            }
        }
        public void DelateRange(CountryRing[] countryRings)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (CountryRing countryRing in countryRings)
                {
                    db.Country_Rings.Remove(countryRing);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(CountryRing countryRing)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Rings.Update(countryRing);
                db.SaveChanges();
            }
        }
    }
}
