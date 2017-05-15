using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BOL;

namespace BLL
{
    public class ManifestRepository
    {
        private EnlLogistiicsEntities _db;
        private int _s;

        public List<Manifest> GetManifests()
        {
            _db = new EnlLogistiicsEntities();
            return _db.Manifests.Where(r=>!r.ManifestRef.Contains("_del")).OrderByDescending(d => d.DateAdded).ToList();
        }

        public int AddManifest(Manifest manifest)
        {
            _db = new EnlLogistiicsEntities();
            _db.Manifests.Add(manifest);
            _s = _db.SaveChanges();
            if (_s > 0)
            {
                return 1;
            }
            return 0;
        }

        public int DeleteManifest(int id)
        {
            _db = new EnlLogistiicsEntities();
            Manifest delManifest = _db.Manifests.FirstOrDefault(i => i.Id.Equals(id));
            if (delManifest != null)
            {
                delManifest.ManifestRef += "_del";
                try
                {
                    _db.Entry(delManifest).State = EntityState.Modified;
                    int d = _db.SaveChanges();
                    return d;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return 0;
        }

        public int SaveManifest(Manifest manifest1)
        {
            _db = new EnlLogistiicsEntities();
            if (manifest1 != null)
            {
                try
                {
                    _db.Entry(manifest1).State = EntityState.Modified;
                    int d = _db.SaveChanges();
                    return d;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}