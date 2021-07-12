using IPTreatmentOffering.Provider;

namespace IPTreatmentOffering.Repository
{
    public interface ITreatmentPackageRepo
    {
        void AddTreatmentPackage(TreatmentContext cont);
    }
}