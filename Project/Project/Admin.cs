using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Admin : User
    {
        private string jobDescription;

        public string JobDescription
        {
            get { return jobDescription; }
            set { jobDescription = value; }
        }

        public Admin(string jobDescription, string name, string surname) : base(name, surname)
        {
            this.jobDescription = jobDescription;
            this.Name = name;
            this.Surname = surname;
        }

        public void addAdmin()
        {

        }

        public void deleteAdmin()
        {

        }

        public void updateAdmin()
        {

        }

        public void selectAdmin()
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
