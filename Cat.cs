using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tapsiriq_4
{
    class Cat
    {
        public string nickname { get; set; }
        public string gender { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (age < 0) return;
                age = value;
            }
        }

        private int energy;

        public int Energy
        {
            get { return energy; }
            set
            {
                if (energy < 0) return;
                energy = value;
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (energy < 0) return;
                price = value;
            }
        }

        private int mealquantity;
        public Cat()
        {
            nickname = null;
            gender = null;
            age = 0;
            mealquantity = 0;
            price = 0;
            energy = 0;
        }
        public Cat(string nickname, string gender, int age, int mealquantity = 0, int price = 0, int energy = 0)
        {
            this.nickname = nickname;
            this.gender = gender;
            this.age = age;
            this.mealquantity = age*10;
            this.price = price;
            this.energy = energy;
        }

        public int Mealquantity
        {
            get { return mealquantity; }
            set
            {
                if (mealquantity < 0) return;
                mealquantity = value;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Nickname-----{nickname}");
            Console.WriteLine($"Age-----{age}");
            Console.WriteLine($"Gender-----{gender}");
            Console.WriteLine($"Energy-----{energy}");
            Console.WriteLine($"Price-----{price}");
            Console.WriteLine($"Mealquality-----{mealquantity}");
        }
        
        

        public void Play()
        {
            if (energy - 10 < 0) return;
            energy -= 10;
        }

        public void Eat()
        {
            if (energy + 10 > 100) return;
            energy += 10;
            mealquantity += 1;
            Price += 5;
            if (mealquantity==(age+1)*10)
            {

                age += 1;
                Console.Clear();
                Console.WriteLine($"Pisiyin {age} yasina kecdi !!!");
                Thread.Sleep(1000);
            }
        }
        
        public void Sleep()
        {
            Random rand = new Random();
            int number = rand.Next(7, 11);
            for (int i = 0; i < number; i++)
            {
                Console.Clear();
                Console.WriteLine($"Pisiyin durmasina {number-i} saniye qalib");
                Thread.Sleep(1000);

            }
            energy = 100;
        }


    }

}
