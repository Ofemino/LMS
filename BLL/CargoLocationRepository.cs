using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class CargoLocationRepository
    {
        private EnlLogistiicsEntities _db;

        public IEnumerable<Cargo_Location> GetCargoLocatios()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Cargo_Location.ToList();
        }
    }
}