using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class TruckRequestRepository
    {
        private EnlLogistiicsEntities _db;

        public List<TruckRequest> GetAllTruckRequest()
        {
            _db = new EnlLogistiicsEntities();
            return _db.TruckRequests.OrderByDescending(d => d.CreatedAt).ToList();
        }

        public List<TruckBatch> GetAllTruckBatches()
        {
            _db = new EnlLogistiicsEntities();
            return _db.TruckBatches.ToList();
        }


    }
}