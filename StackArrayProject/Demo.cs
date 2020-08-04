﻿using System;
using System.Net.Http.Headers;

namespace StackArrayProject
{
    class Demo
    {
        static void Main(string[] args)
        {
            int choice, x;
            StackA st = new StackA(8);
            while (true)
            {
                Console.WriteLine("1.Push an element on the stack");
                Console.WriteLine("2.Pop an element to the stack");
                Console.WriteLine("3.Display the top element");
                Console.WriteLine("4.Display all stack elements");
                Console.WriteLine("5.Display size of the stack");
                Console.WriteLine("6.Quit");
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the element to be pushed:");
                        x = Convert.ToInt32(Console.ReadLine());
                        st.Push(x);
                        break;
                    case 2:
                        x=st.Pop();
                        Console.WriteLine("Popped element is:"+x);
                        break;
                    case 3:
                        Console.WriteLine("Element at the top:" + st.Peek());
                        break;
                    case 4:
                        st.Display();
                        break;
                    case 5:
                        Console.WriteLine("Size of the stack:" + st.size());
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("");
            }
        }
    }
}
