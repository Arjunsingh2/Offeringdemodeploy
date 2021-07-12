using IPTreatmentOffering.Model;
using IPTreatmentOffering.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTreatmentOffering.Repository
{
    public class SpecialistRepo:ISpecialistRepo
    {
        public SpecialistRepo()
        { }
        public void Addspecialist(TreatmentContext cont)
        {
            List<Specialist> list = new List<Specialist>
            {
                new Specialist("Arjun","Orthopedic","Senior",1,8448677710),
                new Specialist("Vikash","Skin","Senior",1,454545),
                new Specialist("Harsh","Gastro","Senior",1,825577710),
                new Specialist("Sandeep","Dental","Senior",1,4575678568),
                new Specialist("Divyanshu","Respira","Senior",1,345345),
                new Specialist("Ruchitha","Urology","Senior",1,3453677),
                new Specialist("Vivek","Neuro","Senior",1,9678574),
                new Specialist("Gaurav","Orthopedic","Junior",1,1242345325),
                new Specialist("Rahul","Skin","Junior",1,78567456),
                new Specialist("Karan","Gastro","Junior",1,54735345),
                new Specialist("Vishal","Dental","Junior",1,78967454),
                new Specialist("Shubham","Respira","Junior",1,234235345),
                new Specialist("Abhishek","Urology","Junior",1,235346576),
                new Specialist("Vineet","Neuro","Junior",1,34667567),
            };
            foreach(var item in list)
            {
                cont.Specialists.Add(item);
            }
        }
    }
}
