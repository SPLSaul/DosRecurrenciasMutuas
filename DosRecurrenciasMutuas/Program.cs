using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DosRecurrenciasMutuas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(f(n));
            Console.ReadKey();

        }
        public static int f(int n)
        {
            if(n > 0) { 
                return f(n-1) - g(n); 
            }
            else { return 1; }
        }
        public static int g(int n)
        {
            if (n <= 2)
            {
                return -2;
            }
            else { 
                return f(n-2)-1; 
            }
        }
    }
}
