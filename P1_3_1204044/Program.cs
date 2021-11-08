using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_3_1204044
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("ANAK AYAM TURUN ");
            
            int Ayam = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            int Anak = Ayam;

            for (int i = Ayam; i > 0; i--)
                {
                if (Anak - 1 == 0)
                {
                    Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya");
                    continue;
                }
                Console.WriteLine("Anak ayam turunlah " + Convert.ToString(Anak) + 
                    ", mati satu tinggallah " + Convert.ToString(Anak - 1));
                Anak--;

              
            }

            
        }
    }
}
 
