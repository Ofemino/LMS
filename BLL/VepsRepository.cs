using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class VepsRepository : VehicleEntryPermit
    {
        private EnlLogistiicsEntities _db;

        public int AddVep(VehicleEntryPermit vep)
        {
            _db = new EnlLogistiicsEntities();
            _db.VehicleEntryPermits.Add(vep);
            int s = _db.SaveChanges();
            if (s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int EditStorageBill(VehicleEntryPermit vep)
        {
            _db = new EnlLogistiicsEntities();
            try
            {
                _db.Entry(vep).State = EntityState.Modified;
                int d = _db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public List<VehicleEntryPermit> GetAllVeps()
        {
            _db = new EnlLogistiicsEntities();
            return _db.VehicleEntryPermits.OrderByDescending(d => d.CreatedAt).ToList();
        }
    }
}