using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка", "Рыжий", 1);
            cat.Say();
            //cat.Age = -10;
            //cat.neme = "Мурка";
            //cat.color = "Рыжий";
            //cat.age = 1;
            //Console.WriteLine(cat.neme);
            //Console.WriteLine(cat.color);
            Console.ReadKey();
            //Cat cat2 = new Cat("Барсик");
            //Cat cat3 = new Cat();
            //Cat cat4 = new Cat();
        }
    }
    class Cat
    {
        //private string neme;
        //public string neme;
        //public string color;
        //private int age;
        //string neme;
        //string color;

        public string Neme { get; set; }

        public string Color { get; set; }

        int age;

        // public void SetAge(int age)
        public int Age
        {
            set
            {
                if (value > 0)
                //if (age > 0)
                {
                    //this.age = age;
                    age = value;
                }
                else
                {
                    Console.WriteLine("Возраст не может быть отрицательным");
                }

            }
            get
            {
                return age;
            }
        }
        public Cat(string neme, string color, int age)
        {
            Neme = neme;
            Color = color;
            Age = age;
        }
        // public int GetAge()
        // {
        //     return age;
        // }

        //public Cat (string n)
        //{
        //     neme = n;
        //     color = "Серый";
        //     age = 1;
        //}
        //public Cat(string n, string c, int a)
        // public Cat(string neme, string color = "Серый", int age = 1)
        // {
        //     this.neme = neme;
        //     this.color = color;
        //     this.age = age;
        // }

        public void Say()
        {
            Console.WriteLine("Мяу! Меня зовут {0}! У меня {1} цвет. Мне {2} лет", Neme, Color, Age);
        }


    }
}
