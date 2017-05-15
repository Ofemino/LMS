using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class MachineRatesRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public IEnumerable<Equipments_Rate> GetMachineRate()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Equipments_Rate.Where(r => !r.RateRef.Contains("_del")).OrderByDescending(d => d.CreatedDate).ToList();
        }

        public int AddMachineRate(Equipments_Rate machineRate)
        {
            _db = new EnlLogistiicsEntities();
            _db.Equipments_Rate.Add(machineRate);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int UpdateMachineRateIsRated(int id)
        {
            _db = new EnlLogistiicsEntities();
            Machinery_Registration mIsRate = _db.Machinery_Registration.FirstOrDefault(i => i.Id.Equals(id));
            if (mIsRate != null)
            {
                mIsRate.IsRated = true;
                try
                {
                    _db.Entry(mIsRate).State = EntityState.Modified;
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

        public int DeleteMachineRate(int id)
        {
            _db = new EnlLogistiicsEntities();
            Equipments_Rate delRate = _db.Equipments_Rate.FirstOrDefault(i => i.Id.Equals(id));
            if (delRate != null)
            {
                delRate.RateRef += "_del";
                try
                {
                    _db.Entry(delRate).State = EntityState.Modified;
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