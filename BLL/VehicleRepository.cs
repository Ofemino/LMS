using System;
using System.Collections.Generic;
using System.Linq;
using BOL;

namespace BLL
{
    public class VehicleRepository
    {
        private EnlLogistiicsEntities _db;

        public IEnumerable<Vehicle_Registration> GetAllRegisteredVehicles()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Vehicle_Registration.Where(r=>!r.v_ref.Contains("_del")).ToList();
        }

        public IEnumerable<Vehicle_Model> GetAllVehiclesModel()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Vehicle_Model.ToList();
        }

        public IEnumerable<Vehicle_Make> GetAllVehiclesMake()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Vehicle_Make.ToList();
        }

        public int AddMake(Vehicle_Make vm)
        {
            _db = new EnlLogistiicsEntities();
            if (vm.make != null)
            {
                _db.Vehicle_Make.Add(vm);
                _db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int AddModel(Vehicle_Model vModel)
        {
            _db = new EnlLogistiicsEntities();
            if (vModel.model_name != null)
            {
                _db.Vehicle_Model.Add(vModel);
                _db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int AddVehicleRegistration(Vehicle_Registration vReg)
        {
            try
            {
                _db = new EnlLogistiicsEntities();
                _db.Vehicle_Registration.Add(vReg);
                _db.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;

            }
        }
    }
}