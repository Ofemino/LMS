using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class StorageBillRepository
    {
        private EnlLogistiicsEntities _db;
        private int s;

        public IEnumerable<StorageBill> GetStorageBill()
        {
            _db = new EnlLogistiicsEntities();
            return _db.StorageBills.OrderByDescending(d => d.CreatedDate);
        }

        public int AddStorageBill(StorageBill storage)
        {
            _db = new EnlLogistiicsEntities();
            _db.StorageBills.Add(storage);
            s = _db.SaveChanges();
            if (s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int EditStorageBill(StorageBill bill)
        {
            _db = new EnlLogistiicsEntities();
            try
            {
                _db.Entry(bill).State = EntityState.Modified;
                s = _db.SaveChanges();
                return s;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }
        public int DeleteStorageBill(StorageBill bill)
        {
            _db = new EnlLogistiicsEntities();
            try
            {
                bill.StorageBillRef += bill.StorageBillRef + "_del";
                _db.Entry(bill).State = EntityState.Modified;
                s = _db.SaveChanges();
                return s;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public List<SP_GetPlantRequestWithPlantCount_Result> Sp_GetStorageBill()
        {
            _db = new EnlLogistiicsEntities();
            var qry = _db.SP_GetPlantRequestWithPlantCount().GroupBy(s => s.StorageBillId).Select(grp => grp.First()).ToList();
            return qry;
        }
    }
}