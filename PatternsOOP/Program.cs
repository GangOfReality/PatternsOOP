﻿using System;
using System.Collections.Generic;
using System.Text;

using Composite;
using Strategy;
using Decorator;

namespace PatternsOOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Patterns!\n");

            ClientComposite.ExecuteScript();
            ClientStrategy.ExecuteScript();
            ClientDecorator.ExecuteScript();
        }
    }
}
