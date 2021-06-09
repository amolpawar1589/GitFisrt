using System;

namespace TestCSharp
{
    class Program
    {
        //constructor-Implict and explicit 
        //implicit -which is declare by compiler when developer is not declare anything
        //explicit is 
        int i; string s; bool b;
        public int add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Multi(int a, int b)
        {
            return a * b;
        }

        public int div(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //explicit constructor
            Program p = new Program();
            int total = 0;
            total = Convert.ToInt32(p.add(1, 1));
            Console.WriteLine("addition is  " + total);

            total = Convert.ToInt32(p.Sub(1, 1));
            Console.WriteLine("Substraction is  " + total);

            total = Convert.ToInt32(p.Multi(1, 1));
            Console.WriteLine("Multiplication  is  " + total);

            total = Convert.ToInt32(p.div(1, 1));
            Console.WriteLine("Division  is  " + total);

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
