using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petlaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            int i = 0;
            int l = 0;
            while (a < 100)
            {
                Console.WriteLine("Wpisz liczbę");
                l = System.Convert.ToInt16(Console.ReadLine());
                a = a + l; 
                i ++;
            } 

            Console.WriteLine("Doliczyłeś do 100. " + "Dodałeś "+ i + " liczb");
            Console.ReadKey();
        }
            
        

    }
}
