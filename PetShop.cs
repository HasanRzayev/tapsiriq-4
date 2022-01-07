using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_4
{
    class PetShop
    {
        public CatHouse[] cats = new CatHouse[] { };


        public PetShop()
        {

        }

        public void Add(CatHouse c)
        {
            Array.Resize(ref cats, cats.Length + 1);
            cats[cats.Length - 1] = c;
        }

        public void show()
        {
            foreach (var item in cats)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine(item.housename);
                Console.WriteLine("=======================================");

            }
        }
    }
}
