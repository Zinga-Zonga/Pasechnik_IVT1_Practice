using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class RegionService
    {
        //Create
        public void Add(Data.Entities.Region region)
        {
            if (region != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Regions.Add(region);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<Data.Entities.Region> GetList()
        {
            List<Data.Entities.Region> regions = new List<Data.Entities.Region>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                regions = db.Regions.ToList();
                db.SaveChanges();
            }
            return regions;
        }
        public Data.Entities.Region GetById(int id)
        {
            Data.Entities.Region region = new Data.Entities.Region();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                region = db.Regions.Where(f => f.Id == id).First();
            }
            return region;
        }
        //Delate
        public void Delate(Data.Entities.Region region)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Regions.Remove(region);
                db.SaveChanges();
            }
        }
        public void DelateRange(Data.Entities.Region[] regions)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (Data.Entities.Region region in regions)
                {
                    db.Regions.Remove(region);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(Data.Entities.Region region)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Regions.Update(region);
                db.SaveChanges();
            }
        }
    }
}
