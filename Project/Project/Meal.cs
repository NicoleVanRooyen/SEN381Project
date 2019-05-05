using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Meal
    {
        private string mealDescription;

        public string MealDescription
        {
            get { return mealDescription; }
            set { mealDescription = value; }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private int healthRating;

        public int HealthRating
        {
            get { return healthRating; }
            set { healthRating = value; }
        }

        public Meal(string mealDescription, float price, int healthRating)
        {
            this.mealDescription = mealDescription;
            this.price = price;
            this.healthRating = healthRating;
        }

 
        public void selectMeal()
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
