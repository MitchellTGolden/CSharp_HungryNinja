using System;
using System.Collections.Generic;

namespace HungryNinja
{

    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string val, int cal, bool IsSp, bool IsSw)
        {
            Name = val;
            Calories = cal;
            IsSpicy = IsSp;
            IsSweet = IsSw;
        }
    }
    class Buffet
    {
        public static Random rand = new Random();

        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("RubixCubes", 100, false, false),
            new Food("Apple Pie", 400, false, true),
            new Food("Kimchi", 8, true, false),
            new Food("Nachos", 346, true, false),
            new Food("Soup", 90, false, false),
            new Food("Pizza", 285, false, false),
            new Food("Ice Cream", 137, false, true)
        };
        }

        public Food Serve()
        {
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
    class Ninja
    {
        public string Name;
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja(string val)
        {
            Name = val;
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool isFull
        {
            get
            {
                if (this.calorieIntake >= 1200)
                {
                    return isFull;
                }
                if (this.calorieIntake > 900 && this.calorieIntake < 1200)
                {
                    Console.WriteLine("Got a little bit of room left");
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if (this.isFull)
            {
                return;
            }
            else
            {
                {
                    Console.WriteLine(item.Name);
                    this.FoodHistory.Add(item);
                    this.calorieIntake += item.Calories;
                    Console.WriteLine($"Current Calories: {this.calorieIntake}");
                    return;
                }
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ninja mitchell = new Ninja("Mitchell");
            Buffet daBuffet = new Buffet();
            while (mitchell.isFull == false)
            {
                mitchell.Eat(daBuffet.Serve());
            }
            Console.WriteLine(mitchell.FoodHistory);
        }
    }
}
