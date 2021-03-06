﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start

            //TestWithString();


            TestWithInt();
            //TestWithDouble();
            Console.WriteLine();
            Console.ReadLine();
            



        }
        static void TestWithInt()
        {
            Stack<int> test = new Stack<int>();

            test.Push(2);
            test.Push(3);
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push(4);

            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());
        }

        static void TestWithString()
        {
            Stack<string> test = new Stack<string>();

            test.Push("E1");
            test.Push("E2");
            Console.WriteLine("read: '{0}'", test.Peek());
            test.Push("E3");

            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("{0} removed", test.Pop());
            Console.WriteLine("read: '{0}'", test.Peek());
            Console.WriteLine("{0} removed", test.Pop());

        }

        static void TestWithDouble()
        {
            Stack<double> test = new Stack<double>();
            test.Push(5.2);
            test.Push(3.14);
            test.Push(9.9);
            test.Pop();
            test.Pop();
            test.Pop();
            Console.WriteLine("read: '{0}'", test.Pop());

        }
    }
}
