using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class MachineriesRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<Machinery_Registration> GetMachineries()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Machinery_Registration.Where(r=>!r.MachineRef.Contains("_del")).OrderByDescending(d => d.CreatedDate).ToList();
        }

        public int AddMachinery(Machinery_Registration machineReg)
        {
            _db = new EnlLogistiicsEntities();
            _db.Machinery_Registration.Add(machineReg);
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
            Machinery_Registration delReg = _db.Machinery_Registration.FirstOrDefault(i => i.Id.Equals(id));
            if (delReg != null)
            {
                delReg.MachineRef += "_del";
                try
                {
                    _db.Entry(delReg).State = EntityState.Modified;
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