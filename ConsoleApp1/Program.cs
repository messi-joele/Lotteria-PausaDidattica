﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Biglietto b1 = new Biglietto("Bergamo", 1000);
            Biglietto b2 = new Biglietto("Verona", 5000);
            Console.WriteLine("PRIMO BIGLIETTO:");
            Console.Write(b1.Serie);
            Console.WriteLine(b1.Numero);
            Console.WriteLine("SECONDO BIGLIETTO:");
            Console.Write(b2.Serie);
            Console.WriteLine(b2.Numero);


            Console.WriteLine(b1.VisualizzaSeVincente());
            


            //Console.ReadLine();

        }
    }
}
