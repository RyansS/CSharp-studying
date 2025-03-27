using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class student
    {
        public string name;
        public int year;
        public double grade;

        public student (string name, int year, double grade)
        {
            this.name = name;
            this.year = year;
            this.grade = grade;
        }

        public void study ()
        {
            Console.WriteLine(name + " from the *"+ year + " is studying");
        }
        public void obgrade()
        {
            Console.WriteLine(name + " got " + grade + " in the grade");
        }
    }
}
