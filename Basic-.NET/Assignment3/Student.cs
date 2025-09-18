using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_demo
{
    internal class Student
    {
        public int id;
        public string name;
        public int marks;

        public Student(int stdID, string stdName, int stdMarks)
        {
            this.id = stdID;
            this.name = stdName;
            this.marks = stdMarks;
        }

    }
}
