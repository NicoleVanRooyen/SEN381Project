using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class School
    {
        private string schoolName;

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        private string schoolAddress;

        public string SchoolAddress
        {
            get { return schoolAddress; }
            set { schoolAddress = value; }
        }

        private string schoolCity;

        public string SchoolCity
        {
            get { return schoolCity; }
            set { schoolCity = value; }
        }

        private int amountOfStudents;

        public int AmountOfStudents
        {
            get { return amountOfStudents; }
            set { amountOfStudents = value; }
        }

        public School(string schoolName, string schoolAddress, string schoolCity, int amountOfStudents)
        {
            this.schoolName = schoolName;
            this.schoolAddress = schoolAddress;
            this.schoolCity = schoolCity;
            this.amountOfStudents = amountOfStudents;
        }

        public void addSchool()
        {

        }

        public void deleteSchool()
        {

        }

        public void updateSchool()
        {

        }

        public void selectSchool()
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
