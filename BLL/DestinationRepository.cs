using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class DestinationRepository
    {
        private EnlLogistiicsEntities _db;

        public IEnumerable<Destination> GetDestinations()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Destinations.OrderBy(c => c.City).ToList();
        }
    }
}