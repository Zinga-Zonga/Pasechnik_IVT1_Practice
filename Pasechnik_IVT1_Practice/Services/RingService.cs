using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class RingService
    {
        //Create
        public void Add(Ring ring)
        {
            if (ring != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Rings.Add(ring);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<Ring> GetList()
        {
            List<Ring> rings = new List<Ring>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                rings = db.Rings.ToList();
                db.SaveChanges();
            }
            return rings;
        }
        //Delate
        public void Delate(Ring ring)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Rings.Remove(ring);
                db.SaveChanges();
            }
        }
        public void DelateRange(Ring[] rings)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (Ring ring in rings)
                {
                    db.Rings.Remove(ring);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(Ring ring)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Rings.Update(ring);
                db.SaveChanges();
            }
        }
    }
}
