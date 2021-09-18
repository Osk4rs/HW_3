using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_3_ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public string Hobby { get; set; }

        public string Sex { get; set; }

        public int YearToday = 2021;
        
        public int getAge()
        {
            return YearToday - Year;

        }

        
        public string PersonShowGreating()
        {
            string PersonGreating = "Hello my name is " + Name + " " + SurName + " and I am " + getAge() + " years old";
            return PersonGreating;
        }

    }
}
