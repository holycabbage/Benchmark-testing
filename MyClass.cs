using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_testing
{
    public class MyClass
    {
        //Declare five private variables
        private int staffID;
        private string name;
        private string dateOfBirth;
        private string email;
        private int annualSalary;


        //Add five public poperties
        public int StaffID { get => staffID; set => staffID = value; }
        public string Name { get => name; set => name = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public int AnnualSalary { get => annualSalary; set => annualSalary = value; }

        public MyClass()
        {
            //Add a constructor with default values
            StaffID = 0;
            Name = "NA";
            DateOfBirth = "NA";
            Email = "NA";
            AnnualSalary = 0;

        }

        //It is a method to display the Name
        public override string ToString()
        {
            return Name;
        }
    }
}
