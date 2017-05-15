using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public class TruckCallupRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public IEnumerable<TruckCallup> GetLoading()
        {
            _db = new EnlLogistiicsEntities();
            return _db.TruckCallups.OrderBy(n => n.CreatedAt).ToList();
        }

        public int AddTruckCallup(TruckCallup truckCallup)
        {
            _db = new EnlLogistiicsEntities();
            _db.TruckCallups.Add(truckCallup);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

    }
}
