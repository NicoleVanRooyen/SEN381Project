using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Classroom : School
    {

        private int classNumber;

        public int ClassNumber
        {
            get { return classNumber; }
            set { classNumber = value; }
        }

        private string classDescription;

        public string ClassDescription
        {
            get { return classDescription; }
            set { classDescription = value; }
        }

        public Classroom(int classNumber, string classDescription, string schoolName, string schoolAddress, string schoolCity, int amountOfStudents) :base(schoolName, schoolAddress, schoolCity, amountOfStudents)
        {
            this.classNumber = classNumber;
            this.classDescription = classDescription;
        }

        public void selectClassroom()
        {

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
