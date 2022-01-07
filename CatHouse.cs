using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tapsiriq_4
{
    class CatHouse
    {
   
        public Cat[] cats=new Cat[] {} ;
        public string housename { get; set; }


        public CatHouse()
        {
         
        }

        public CatHouse(string housename)
        {
            this.housename = housename;
        }

        public void Add( Cat c)
        {
            Array.Resize( ref cats, cats.Length + 1);
            cats[cats.Length-1] = c;
        }

        public void RemoveByNickname(string nick)
        {
            
            for (int i = 0, k = 0; i < cats.Length; i++)
            {

                if (cats[i].nickname == nick) continue;
                cats[k++] = cats[i];

            }

            Array.Resize(ref cats, cats.Length - 1);
            //cats = cats.Where(e => e.nickname != nick).ToArray();
        }


        public void show()
        {
            var k = 1;
            foreach (var item in cats)
            {
                Console.WriteLine($"==================={k++}====================");
                item.Show();
                Console.WriteLine("=======================================");

            }
        }
    }
}
