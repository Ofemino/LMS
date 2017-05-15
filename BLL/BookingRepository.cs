using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class BookingRepository
    {
        private EnlLogistiicsEntities _db;

        public IEnumerable<Booking> GetBookingGrid()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Bookings.OrderByDescending(b=>b.BookDate).ToList();
        }
    }
}