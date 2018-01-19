using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public class MethodClass
    {
        public void Method1(string mess) { Console.WriteLine($"First method call {mess}"); }
        public void Method2(string mess) { Console.WriteLine($"Second method call {mess}"); }
    }

    class Program
    {
        public delegate void Display(string message);

        public static void DelegateMethod(string message) {

            Console.WriteLine($"My name is : {message}  !!!");
        }

        public static void MethodWithCallabck(int para0, int para1, Display call)
        {
            call(para0 + "/" + para1);
        }

        static void Main(string[] args)
        {
            Display handler = DelegateMethod;
            handler("Sekou Dioubate");

            MethodWithCallabck(1977, 12, handler);

            MethodClass obj = new MethodClass();
            Display d1 = obj.Method1;
            Display d2 = obj.Method2;
            Display d3 = DelegateMethod;

            // another way of displaying all delegate method

            Console.WriteLine("Calling delegate.....\n");

            Display allMeth = d1 + d2;
            allMeth += d3;

            allMeth("Indianapolis");

            Console.WriteLine(allMeth.GetInvocationList().GetLength(0));




            Console.Read();
        }
    }
}
