using System;
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
        interface IEatable
        {
            void Eat();
        }

        //Interface
        interface IRunnable
        {
            void Run();
        }

        class Human : IRunnable
        {
            public void Run()
            {
                Console.WriteLine("Run as Human");
            }
        }

        class Animal : IRunnable, 
        {
            public void Run()
            {
                Console.WriteLine("Run as Animal");
            }
        }

    }
}
