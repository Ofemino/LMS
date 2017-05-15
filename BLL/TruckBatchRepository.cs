using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class TruckBatchRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<TruckBatch> GetBillBatch()
        {
            _db = new EnlLogistiicsEntities();
            return _db.TruckBatches.ToList();
        }

        public int AddBatch(TruckBatch batch)
        {
            _db = new EnlLogistiicsEntities();
            _db.TruckBatches.Add(batch);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int RemoveBatchFromBill(TruckBatch batch)
        {
            _db = new EnlLogistiicsEntities();

            try
            {
                _db.Entry(batch).State = EntityState.Deleted;
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