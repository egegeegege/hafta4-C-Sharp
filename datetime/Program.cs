﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih);
            Thread.Sleep(1000);

            Console.ReadLine();

        }
    }
}
