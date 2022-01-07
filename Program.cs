using System;
using System.Text;
using System.Threading;
using tapsiriq_4;


Console.OutputEncoding = System.Text.Encoding.UTF8;

Encoding unicode = Encoding.Unicode;
Console.WriteLine();

PetShop shop = new();


CatHouse happycat = new("Happy Cat");
CatHouse buycat = new("BUY Cat");
CatHouse bravocat = new("BRAVO Cat");

Cat max = new("Max","kisi",5,0,10,10);
Cat loki = new("Loki","kisi",5, 0, 10, 10);
Cat tiger = new("Tiger", "kisi",5, 0, 10, 10);
Cat oscar = new("Oscar", "kisi",5, 0, 10, 10);
Cat sam = new("Sam", "kisi",5, 0, 10, 10);
Cat bob = new("Bob", "kisi",5, 0, 10, 10);
Cat teddy = new("Teddy", "kisi",5, 0, 10, 10);
Cat kitty = new("Kitty", "qadin",5, 0, 10, 10);
Cat ruby = new("Ruby", "qadin", 5, 0, 10, 10);
Cat ella = new("Ella", "qadin", 5, 0, 10, 10);
Cat annie = new("Annie", "qadin", 5, 0, 10, 10);
Cat mila = new("Mila", "qadin", 5, 0, 10, 10);
Cat poppy = new("Poppy", "qadin", 5, 0, 10, 10);
Cat emma = new("Emma", "qadin", 5, 0, 10, 10);
Cat belle = new("Belle", "qadin", 5, 0, 10, 10);
Cat hunter = new("Hunter", "kisi", 5, 0, 10, 10);
Cat kevin = new("Kevin", "kisi", 5, 0, 10, 10);

happycat.Add(max);
happycat.Add(loki);
happycat.Add(tiger);
happycat.Add(ella);
happycat.Add(emma);
happycat.Add(belle);
happycat.Add(hunter);
////////////////////////////
buycat.Add(oscar);
buycat.Add(sam);
buycat.Add(kitty);
buycat.Add(annie);
buycat.Add(kevin);
////////////////////////////
bravocat.Add(ruby);
bravocat.Add(bob);
bravocat.Add(teddy);
bravocat.Add(poppy);
bravocat.Add(mila);

shop.Add(happycat);
shop.Add(buycat);
shop.Add(bravocat);
var choose = 0;
var chose = 0;
var option = 0;
while (true)
{

    Console.Clear();

    Console.BackgroundColor = ConsoleColor.Black;
    Console.ForegroundColor = ConsoleColor.Yellow;


    Console.WriteLine("\u263A "+"PETSHOP"+ " \u263A ");
    shop.show();
    Console.WriteLine(" Secim edin----");
    choose = int.Parse(Console.ReadLine());
    if(choose<0 || choose > shop.cats.Length)
    {
        Console.WriteLine("Duzgun daxil edin");
        Thread.Sleep(1000);
        continue;
    }
    else
    {
        while (true)
        {
            Console.Clear();
            shop.cats[choose-1].show();
            
            Console.WriteLine("Geri qayitmaq isteyirsinizse 0 sifir daxil edin");

            Console.WriteLine($"{shop.cats[choose - 1].cats.Length + 1} ------Add");
            Console.WriteLine($"{shop.cats[choose - 1].cats.Length + 2} ------RemovebyNickname");
            chose = int.Parse(Console.ReadLine());
            if (choose < 0 || choose > shop.cats[choose - 1].cats.Length + 2)
            {
                Console.WriteLine("Duzgun daxil edin");
                Thread.Sleep(1000);
                continue;
            }
            else if (chose == shop.cats[choose - 1].cats.Length + 1)
            {
                string name;
                string gender;
                int age;
                Console.WriteLine("Yeni pisyin adini daxil edin");
                name = Console.ReadLine();
                Console.WriteLine("Yeni pisyin cinsini daxil edin");
                gender = Console.ReadLine();
                Console.WriteLine("Yeni pisyin yasini daxil edin");
                age = int.Parse(Console.ReadLine());
                Cat c = new(name, gender, age);
                shop.cats[choose - 1].Add(c);
            }
            else if (chose == shop.cats[choose - 1].cats.Length + 2)
            {
                if (shop.cats[choose - 1].cats.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Housun ici bosdu !!!!");
                    Thread.Sleep(1000);
                    continue;
                }
                string name;
                Console.WriteLine("Silmek istediyiniz pisyin adini daxil edin");
                name = Console.ReadLine();
                shop.cats[choose - 1].RemoveByNickname(name);
            }
            else if (chose == 0) break;


            else
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Geri qayitmaq isteyirsinizse 0 sifir daxil edin");

                    Console.WriteLine("Pisiyin energisi 0 olduqda  avtomatik olaraq yatir");
                    shop.cats[choose - 1].cats[chose - 1].Show();
                    //Console.WriteLine($"Pisiyin adi-----{shop.cats[choose - 1].cats[chose - 1].nickname}");
                    //Console.WriteLine($"Pisiyin energisi-----{shop.cats[choose - 1].cats[chose - 1].Energy}");
                    //Console.WriteLine($"Pisiyin yediklerinin kutlesi-----{shop.cats[choose - 1].cats[chose - 1].Mealquantity}");
                    Console.WriteLine("Oyna");
                    Console.WriteLine("Yemek ver");
                    if (shop.cats[choose - 1].cats[chose - 1].Energy == 0)
                    {
                        shop.cats[choose - 1].cats[chose - 1].Sleep();
                        continue;
                    }
                    option = int.Parse(Console.ReadLine());

                    if (option < 0 || option > 2)
                    {
                        Console.WriteLine("Duzgun daxil edin");
                        Thread.Sleep(1000);
                        continue;
                    }
                    else if (option == 0) break;
                    else if (option == 1)
                    {
                        shop.cats[choose - 1].cats[chose - 1].Play();

                    }
                    else if (option == 2)
                    {
                        shop.cats[choose - 1].cats[chose - 1].Eat();

                    }

                }
            }
        }
        

    }
}






