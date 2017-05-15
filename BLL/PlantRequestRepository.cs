using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class PlantRequestRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<DailyPlantRequest> GetAllPlantRequest()
        {
            _db = new EnlLogistiicsEntities();
            return _db.DailyPlantRequests.ToList();
        }

        public List<SP1_GetPlantRequestWithPlantCount_Result> GetPlantRequestWithPlantCount()
        {
            _db = new EnlLogistiicsEntities();
            return _db.SP1_GetPlantRequestWithPlantCount().ToList();
            //return _db.SP1_GetPlantRequestWithPlantCount().Take(1).ToList();
        }

        public int AddPlantRequest(DailyPlantRequest plant)
        {
            _db = new EnlLogistiicsEntities();
            _db.DailyPlantRequests.Add(plant);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int UpdateResponseRequest(DailyPlantRequest request)
        {
            _db = new EnlLogistiicsEntities();
            try
            {
                _db.Entry(request).State = EntityState.Modified;
                int d = _db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


    }
}