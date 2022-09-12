using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string niz,niz1;
            Console.WriteLine("Unesite niz znakova: ","\n");
                niz=Console.ReadLine();
            niz1=niz.Replace(" ", "_");
            Console.WriteLine(niz1);
            Console.ReadLine();
        }
    }
}
