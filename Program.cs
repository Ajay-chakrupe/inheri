// See https://aka.ms/new-console-template for more information
using System;
namespace Demo
{
    class Mobile
    {
        public void see()
        {
            Console.WriteLine("There are multiple mobiles are present in world");
        }
    }
    class Samsung : Mobile
    { 
        public void seen()
        {
            Console.WriteLine("samsung has different modules");
        }
    }
    class Redmi : Samsung
    {
        public void show()
        {
            Console.WriteLine("redmi has different modules");
        }
    }
    class Disply
    {
        static void Main(String[] args)
        {
            Redmi re = new Redmi();
            re.show();
            re.seen();
            re.see();

        }
    }
}
