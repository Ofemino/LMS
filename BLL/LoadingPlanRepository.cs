using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class LoadingPlanRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public IEnumerable<LoadingPlan> GetLoading()
        {
            _db = new EnlLogistiicsEntities();
            return _db.LoadingPlans.OrderBy(n => n.BatchNumber).ToList();
        }

        public int AddLoadingPlan(List<LoadingPlan> loadingPlan)
        {
            _db = new EnlLogistiicsEntities();
            foreach (var p in loadingPlan)
            {
                _db.LoadingPlans.Add(p);
                _s = _db.SaveChanges();
            }
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public IEnumerable<LoadingPlanTransporter> GetPlanTransporters()
        {
            _db = new EnlLogistiicsEntities();
            return _db.LoadingPlanTransporters.OrderBy(n => n.CreatedDate).ToList();
        }

        public int PlanTransporter(List<LoadingPlanTransporter> nPlan)
        {
            _db = new EnlLogistiicsEntities();
            foreach (var p in nPlan)
            {
                _db.LoadingPlanTransporters.Add(p);
                _s = _db.SaveChanges();
            }
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }
    }
}