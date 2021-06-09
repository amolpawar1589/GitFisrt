using System;

namespace TestCSharp
{
    class Program
    {
        //constructor-Implict and explicit 
        //implicit -which is declare by compiler when developer is not declare anything
        //explicit is 
        int i; string s; bool b;
        public int add(int a,int b)
        {
            return (a + b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //explicit constructor
            Program p = new Program();
            p.add(1,1);
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
