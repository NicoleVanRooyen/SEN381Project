using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student
    {
        private string studentName;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        private string studentSurname;

        public string StudentSurname
        {
            get { return studentSurname; }
            set { studentSurname = value; }
        }

        private string studentID;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        private string classCode;

        public string ClassCode
        {
            get { return classCode; }
            set { classCode = value; }
        }

        private bool  atSchool;

        public bool  AtSchool
        {
            get { return atSchool; }
            set { atSchool = value; }
        }

        private float accountBalance;

        public float AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }


        public Student(string studentName, string studentSurname, string studentID, string classCode, bool atSchool, float accountBalance)
        {
            this.studentName = studentName;
            this.studentSurname = StudentSurname;
            this.studentID = studentID;
            this.classCode = classCode;
            this.atSchool = atSchool;
            this.accountBalance = accountBalance;
        }

        public int daysAbsent(bool atSchool)
        {
            int daysAbsent = 0;
            return daysAbsent;
        }

        public int getAge()
        {
            int age = 0;
            return age;
        }

        public void updateBalance()
        {

        }

        public void addStudent()
        {

        }

        public void deleteStudent()
        {

        }

        public void updateStudent()
        {

        }

        public void selectStudent()
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
