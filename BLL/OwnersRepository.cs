using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BLL;
using BOL;

namespace BLL
{
    public class OwnersRepository
    {
        private EnlLogistiicsEntities _db;


        public IEnumerable<Vehicle_Owner> GetAllVehiclesOwners()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Vehicle_Owner.Where(r => !r.OwnerRef.Contains("_del")).OrderByDescending(d => d.DateAdded).ToList();
        }

        public int AddOwner(Vehicle_Owner owner)
        {
            _db = new EnlLogistiicsEntities();
            _db.Vehicle_Owner.Add(owner);
            int a = _db.SaveChanges();
            if (a > 0)
            {
                return a;
            }
            return 0;
        }

        public int UpdateOwner(Vehicle_Owner owner)
        {
            _db = new EnlLogistiicsEntities();
            if (owner != null)
            {
                try
                {
                    _db.Entry(owner).State = EntityState.Modified;
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