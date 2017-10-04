using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaduAPI.Controllers
{
    public class RegionAPIController : ApiController
    {
        NorthwindEntities db;
        public RegionAPIController()
        {
            db = new NorthwindEntities();
        }

        [HttpGet]
        public List<Region> GetAll()
        {
            return db.Regions.ToList();
        }

        [HttpGet]
        public Region GetById(int id)
        {
            return db.Regions.SingleOrDefault(s => s.RegionID == id);
        }

        [HttpPost]
        public void InsertRegion(Region r)
        {

            db.Regions.Add(r);
            db.SaveChanges();
        }

        [HttpDelete]
        public void DeleteRegion(int id)
        {
            Region r = db.Regions.SingleOrDefault(s => s.RegionID == id);
            db.Regions.Remove(r);
            db.SaveChanges();
        }

        //[HttpPut]
        //public void UpdateRegion(Region newRegion)
        //{
        //    Region oldRegion = db.Regions.SingleOrDefault(s => s.RegionID == newRegion.RegionID);
        //    db.Regions.Remove(oldRegion);
        //    db.Regions.Add(newRegion);
        //    db.SaveChanges();
        //}
    }
}
