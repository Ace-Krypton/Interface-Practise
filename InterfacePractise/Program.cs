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
            //Getting instance and creating object from Human class
            Human h1 = new Human();
            h1.Run();
            h1.Eat();

            //Getting instance and creating object from Animal class
            Animal a1 = new Animal();
            a1.Run();
            a1.Eat();

        }

        //Interface
        interface IEatable //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            void Eat(); //Methods in interface do not have bodies, so you have to implement it on your inherited class (It is about C# 7.3 and lower versions)
        }

        //Interface
        interface Sum //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            int Sum(int x, int y);//Methods in interface do not have bodies, so you have to implement it on your inherited class (It is about C# 7.3 and lower versions)
        }

        //Interface
        interface IRunnable //Interfaces do not have method bodies like abstract classes, But in C# 8 and higher versions, you can add method body in your interface.
        {
            void Run(); //Methods in interface do not have bodies, so you have to implement it on your inherited class (It is about C# 7.3 and lower versions)
        }

        class Human : IRunnable //Interfaces do not have fields, but they have properties. Remember properties are also methods, so you can use them in interfaces
        {
            public void Run() //You cannot give private or protected access modifier to interface methods in your class, they have to be public
            {
                Console.WriteLine("Run as Human");
            }

            public void Eat()
            {
                Console.WriteLine("Eat as a Human"); //You cannot give private or protected access modifier to interface methods in your class, they have to be public
            }

        }

        class Animal : IRunnable, IEatable //The main difference between abstract class and interface is, you can get inheritance from several classes 
        {
            public void Run() //You cannot give private or protected access modifier to interface methods in your class, they have to be public
            {
                Console.WriteLine("Run as Animal");
            }

            public void Eat() //You cannot give private or protected access modifier to interface methods in your class, they have to be public
            {
                Console.WriteLine("Eat as Animal");
            }
        }

    }
}
