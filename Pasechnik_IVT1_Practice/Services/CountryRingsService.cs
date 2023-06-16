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
        public void Add(CountryMat countryMat)
        {
            if (countryMat != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Country_Mats.Add(countryMat);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<CountryMat> GetList()
        {
            List<CountryMat> countryMats = new List<CountryMat>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                countryMats = db.Country_Mats.ToList();
                db.SaveChanges();
            }
            return countryMats;
        }
        //Delate
        public void Delate(CountryMat countryMat)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Mats.Remove(countryMat);
                db.SaveChanges();
            }
        }
        public void DelateRange(CountryMat[] countryMats)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (CountryMat countryMat in countryMats)
                {
                    db.Country_Mats.Remove(countryMat);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(CountryMat countryMat)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Country_Mats.Update(countryMat);
                db.SaveChanges();
            }
        }
    }
}
