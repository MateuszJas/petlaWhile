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
                        
            int i = 0;
            int l = 0;
            while (l < 100)
            {
                Console.WriteLine("Wpisz liczbę");
                l += System.Convert.ToInt16(Console.ReadLine());
                i ++;
            } 
            
            Console.WriteLine("Doliczyłeś do  {0}. Dodałeś {1} liczb.", l, i);
            Console.ReadKey();
            
        }
            
        

    }
}
