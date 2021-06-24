﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractise
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        //Interface
        interface IEatable //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            void Eat();
        }

        //Interface
        interface Sum //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            int Sum();
        }

        //Interface
        interface IRunnable //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            void Run(); //
        }

        class Human : IRunnable 
        {
            public void Run()
            {
                Console.WriteLine("Run as Human");
            }
        }

        class Animal : IRunnable, IEatable //The main difference between abstract class and interface is, you can get inheritance from several classes 
        {
            public void Run()
            {
                Console.WriteLine("Run as Animal");
            }

            public void Eat()
            {
                Console.WriteLine("Eat as Animal");
            }
        }

    }
}
