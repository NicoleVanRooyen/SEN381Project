using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Teacher : User
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Teacher(int grade, string name, string surname) : base(name, surname)
        {
            this.grade = grade;
            this.Name = name;
            this.Surname = surname;
        }

        public void addTeacher()
        {

        }

        public void deleteTeacher()
        {

        }

        public void updateTeacher()
        {

        }

        public void selectTeacher()
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
