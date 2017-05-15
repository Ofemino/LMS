using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public class ItemApprovalsRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<ItemApproval> GetItemApprovals()
        {
            _db = new EnlLogistiicsEntities();
            return _db.ItemApprovals.ToList();
        }

        public int AddItemApproval(ItemApproval item)
        {
            _db = new EnlLogistiicsEntities();
            _db.ItemApprovals.Add(item);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}
