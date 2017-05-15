using System;
using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class FreightRateRepository
    {
        private EnlLogistiicsEntities _db;

        public IEnumerable<FreightRate> GetFreightRate()
        {
            _db = new EnlLogistiicsEntities();
            return _db.FreightRates.OrderByDescending(d => d.CreatedDate).ToList();
        }

        public int AddFreightRate(FreightRate freightV)
        {
            _db = new EnlLogistiicsEntities();
            _db.FreightRates.Add(freightV);
            int s = _db.SaveChanges();
            if (s > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}