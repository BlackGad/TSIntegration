﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = new SomeReasonableLogic();
            Console.WriteLine(logic.RequestAnswer());
        }
    }
}
