using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public class VechicleCallUpRequestRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<VechicleCallUpRequest> GetAllCallUpRequest()
        {
            _db = new EnlLogistiicsEntities();
            return _db.VechicleCallUpRequests.ToList();
        }


        public int AddCallUpRequest(VechicleCallUpRequest callUp)
        {
            _db = new EnlLogistiicsEntities();
            _db.VechicleCallUpRequests.Add(callUp);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }


        public int UpdateCallUpRequest(VechicleCallUpRequest callUp)
        {
            _db = new EnlLogistiicsEntities();
            try
            {
                _db.Entry(callUp).State = EntityState.Modified;
                int d = _db.SaveChanges();
                return d;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DoCallUp(int sId)
        {


            return 0;
        }

    }
}
