using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class SportTypeService
    {
        //Create
        public void Add(SportType sportType)
        {
            if (sportType != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Sports_Types.Add(sportType);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<SportType> GetList()
        {
            List<SportType> sportTypes = new List<SportType>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                sportTypes = db.Sports_Types.ToList();
                db.SaveChanges();
            }
            return sportTypes;
        }
        //Delate
        public void Delate(SportType sportType)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Sports_Types.Remove(sportType);
                db.SaveChanges();
            }
        }
        public void DelateRange(SportType[] sportTypes)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (SportType sportType in sportTypes)
                {
                    db.Sports_Types.Remove(sportType);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(SportType sportType)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Sports_Types.Update(sportType);
                db.SaveChanges();
            }
        }
    }
}
