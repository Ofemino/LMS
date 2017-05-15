using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class QueueRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public IEnumerable<VehiclesOnQueue> GetVehiclesOnQueue()
        {
            _db = new EnlLogistiicsEntities();
            return _db.VehiclesOnQueues.OrderByDescending(d => d.CreatedDate).ToList();

        }

        public int AddQueue(VehiclesOnQueue queue)
        {
            _db = new EnlLogistiicsEntities();
            _db.VehiclesOnQueues.Add(queue);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int DeleteQueue(int id)
        {
            _db = new EnlLogistiicsEntities();
            VehiclesOnQueue delQueue = _db.VehiclesOnQueues.FirstOrDefault(i => i.Id.Equals(id));
            if (delQueue != null)
            {
                delQueue.QueueRef += "_del";
                try
                {
                    _db.Entry(delQueue).State = EntityState.Modified;
                    int d = _db.SaveChanges();
                    return d;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}