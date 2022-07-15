using Desingpattern01.classes;

using System;

namespace Desingpattern01
{
    class Program
    {
        public Program()
        {
            throw new System.NotImplementedException();
        }

        static void Main(string[] args)
        {
            //Yonetici yn = new Yonetici();
            //Cıktı cıktı01 = yn.FactoryMethod(CıktıTuru.cıktı1);
            //Console.WriteLine(cıktı01.EkranYapısı());

            Cıktı obj = null;
            Console.WriteLine("Hangi Ekranı istiyorsun?");
            string type = Console.ReadLine();
            if (type == "windows")
            {
                obj = new Cıktı1();
            }
            else if (type == "web")
            {
                obj = new Cıktı2();
            }
            else if(type == "Mobile")
            {
                obj = new Cıktı3();
            }
            Console.WriteLine(obj.EkranYapısı());
            Console.ReadLine();


        }
    }
}
