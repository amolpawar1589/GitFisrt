using System;

namespace TestCSharp
{
    class Program
    {
        //constructor-Implict and explicit 
        //implicit -which is declare by compiler when developer is not declare anything
        //explicit is 
        int i; string s; bool b;


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //explicit constructor
            Program p = new Program();
            Console.WriteLine(p.i);
            Console.WriteLine(p.s);
            Console.WriteLine(p.b);
            Console.WriteLine(p.b);
            Console.WriteLine(p.b);
            Console.WriteLine(p.b);
            Console.ReadLine();
        }
    }
}
