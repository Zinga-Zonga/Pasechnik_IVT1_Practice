using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class CountryService
    {
        //Create
        public void AddCountry(Country country)
        {
            if (country != null)
            {
                using(Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Countries.Add(country);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<Country> GetList()
        {
            RegionService regionService = new RegionService();
            List<Country> countries = new List<Country>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                countries = db.Countries.ToList();
                foreach(Country c in countries)
                {
                    c.Region = regionService.GetById(c.RegionId);
                }
                
            }
            return countries;
        }
        public Country GetById(int id)
        {
            Country country = new Country();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                country = (Country)db.Countries.Where(f => f.Id == id).First();
            }
            return country;
        }
        //Delate
        public void Delate(Country country)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Countries.Remove(country);
                db.SaveChanges();
            }
        }
        public void DelateRange(int[] id)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach(int i in id)
                {
                    db.Countries.RemoveRange((Country)db.Countries.Where(u => u.Id == i));
                    
                }
                db.SaveChanges();
                
            }
        }
        //Update
        public void Update(Country country)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Countries.Update(country);
                db.SaveChanges();
            }
        }
    }
}
