using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
    internal class Student
    {
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public bool isInvalidCgpa { get; set; }

        public void StudentName(string name)
        {
            if (name.Length >= 5)
            {
                Name = name;
            }
            else
            {
                Name = " ";
            }
        }
        
        public void StudentCgpa(double cgpa)
        {
            if (cgpa >= 1 && cgpa <= 10)
            {
                Cgpa = cgpa;
                isInvalidCgpa = true;
            }
            else
            {
                isInvalidCgpa = false;
            }
        }

        public double StudentPercentage()
        {
            return Cgpa * 10;
        }
    }
}
