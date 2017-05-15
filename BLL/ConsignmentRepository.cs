using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class ConsignmentRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<Consignment> GetConsignments()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Consignments.Where(r=>!r.ConsignmentRef.Contains("_del")).OrderByDescending(d => d.DateAdded).ToList();
        }

        public int AddConsignment(Consignment consignment)
        {
            _db = new EnlLogistiicsEntities();
            _db.Consignments.Add(consignment);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int DeleteConsignment(int id)
        {
            _db = new EnlLogistiicsEntities();
            Consignment delConsignment = _db.Consignments.FirstOrDefault(i => i.Id.Equals(id));
            if (delConsignment != null)
            {
                delConsignment.ConsignmentRef += "_del";
                try
                {
                    _db.Entry(delConsignment).State = EntityState.Modified;
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
