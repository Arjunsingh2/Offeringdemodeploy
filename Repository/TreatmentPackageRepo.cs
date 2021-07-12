using IPTreatmentOffering.Model;
using IPTreatmentOffering.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTreatmentOffering.Repository
{
    public class TreatmentPackageRepo: ITreatmentPackageRepo
    {
        public TreatmentPackageRepo()
        { }
        public void AddTreatmentPackage(TreatmentContext cont)
        {
            List<TreatmentPackage> list = new List<TreatmentPackage>()
            {
                new TreatmentPackage("Orthopedic","Package1","Test 1",3000,2),
                new TreatmentPackage("Orthopedic","Package2","Test 2",5000,2),
                new TreatmentPackage("Skin","Package1","Test 2",4000,3),
                new TreatmentPackage("Skin","Package2","Test 1",6000,3),
                new TreatmentPackage("Gastro","Package1","Test 2",3000,5),
                new TreatmentPackage("Gastro","Package2","Test 1",5000,5),
                new TreatmentPackage("Dental","Package1","Test 2",2000,4),
                new TreatmentPackage("Dental","Package2","Test 1",4000,4),
                new TreatmentPackage("Respira","Package1","Test 2",1000,7),
                new TreatmentPackage("Respira","Package2","Test 2",5000,7),
                new TreatmentPackage("Urology","Package1","Test 1",2000,8),
                new TreatmentPackage("Urology","Package2","Test 2",3000,8),
                new TreatmentPackage("Neuro","Package1","Test 1",5000,15),
                new TreatmentPackage("Neuro","Package2","Test 2",8000,15),
                //new TreatmentPackage("Orthopedic","Package 1","Test 1",5000,2),
                //new TreatmentPackage("Orthopedic","Package 2","Test 2",5000,2),
                //new TreatmentPackage("Orthopedic","Package 1","Test 1",5000,2),
                //new TreatmentPackage("Orthopedic","Package 2","Test 2",5000,2),
            };
            foreach(var item in list)
            {
                cont.TreatmentPackages.Add(item);
            }
        }
    }
}
