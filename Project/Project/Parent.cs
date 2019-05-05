using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Parent : User
    {
        private int numberOfChildren;

        public int NumberOfChildren
        {
            get { return numberOfChildren; }
            set { numberOfChildren = value; }
        }

        public Parent(int numberOfChildren, string name, string surname) :base(name, surname)
        {
            this.numberOfChildren = numberOfChildren;
            this.Name = name;
            
        }

        public void addParent()
        {

        }

        public void deleteParent()
        {

        }

        public void updateParent()
        {

        }

        public void selectParent()
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
