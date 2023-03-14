using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorconsoleapps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            int a = 10; //declarasi variable a, dg nilai awal 10;
            int b = 6; //declarasi variable b, dg nilai awal 6;

            Console.WriteLine("hasil penambahan" + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}" , a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}" , a, b, pembagian(a, b));

            Console.WriteLine("\ntekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        {
            return a +b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
