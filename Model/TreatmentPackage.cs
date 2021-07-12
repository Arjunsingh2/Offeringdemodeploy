using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTreatmentOffering.Model
{
    public class TreatmentPackage
    {
        public TreatmentPackage()
        { }
        public TreatmentPackage(string a,string p,string t,int c,int d)
        {
            this.Ailment = a;
            this.Package = p;
            this.TestDetail = t;
            this.Cost = c;
            this.duration = d;
        }
        public int Id { get; set; }
        public string Ailment { get; set; }
        public string Package { get; set; }
        public string TestDetail { get; set; }
        public int Cost { get; set; }
        public int duration { get; set; }
    }
}
