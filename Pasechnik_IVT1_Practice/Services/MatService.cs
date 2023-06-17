using Pasechnik_IVT1_Practice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasechnik_IVT1_Practice.Services
{
    internal class MatService
    {
        //Create
        public void Add(Mat mat)
        {
            if (mat != null)
            {
                using (Data.ApplicationContext db = new Data.ApplicationContext())
                {
                    db.Mats.Add(mat);
                    db.SaveChanges();
                }
            }

        }
        //Read
        public List<Mat> GetList()
        {
            List<Mat> mats = new List<Mat>();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                mats = db.Mats.ToList();
                db.SaveChanges();
            }
            return mats;
        }
        public Mat GetById(int id)
        {
            Mat mat = new Mat();
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                mat = (Mat)db.Mats.Where(f => f.Id == id).First();
            }
            return mat;
        }
        //Delate
        public void Delate(Mat mat)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Mats.Remove(mat);
                db.SaveChanges();
            }
        }
        public void DelateRange(Mat[] mats)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                foreach (Mat mat in mats)
                {
                    db.Mats.Remove(mat);

                }
                db.SaveChanges();

            }
        }
        //Update
        public void Update(Mat mat)
        {
            using (Data.ApplicationContext db = new Data.ApplicationContext())
            {
                db.Mats.Update(mat);
                db.SaveChanges();
            }
        }
    }
}
