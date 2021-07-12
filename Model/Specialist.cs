using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPTreatmentOffering.Model
{
    public class Specialist
    {
        public Specialist()
        { this.Status = "Available"; }
        public Specialist(string name,string aof,string des,int exp,long ph)
        {
            this.Name = name;
            this.AreaOfExpertise = aof;
            this.Designation = des;
            this.Experience = exp;
            this.ContactNumber = ph;
            this.Status = "Available";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public String AreaOfExpertise { get; set; }
        public string Designation { get; set; }
        public int Experience { get; set; }
        public long ContactNumber { get; set; }
        public string Status { get; set; }
    }
}
