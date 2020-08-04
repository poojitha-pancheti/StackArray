using System;
using System.Collections.Generic;
using System.Text;

namespace StackArrayProject
{
    class StackA
    {
        private int[] stackArray;
        private int top;
        public StackA()
        {
            stackArray = new int[10];
            top = -1;
        }
        public StackA(int maxSize)
        {
            stackArray = new int[maxSize];
            top = -1;

        }
        public int size()
        {
            return top + 1;
        }
        public bool IsEmpty()
        {
            return (top == -1);
        }
        public bool IsFull()
        {
            return (top == stackArray.Length - 1);
        }
        public void Push(int x)
        {
            if (IsFull()){
                Console.WriteLine("Stack Overflow");
                return;
            }
            top = top + 1;
            stackArray[top] = x;
        }
        public int Pop()
        {
            int x;
            if (IsEmpty())
                throw new System.InvalidOperationException("stack underflow");
            x = stackArray[top];
            top = top - 1;
            return x;
        } 
        public int Peek()
        {
            if (IsEmpty())
                throw new System.InvalidOperationException("stack underflow");
            return stackArray[top];
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Stack is :");
            for (int i = top; i >= 0; i--)
                Console.WriteLine(stackArray[i] + " ");
            Console.WriteLine();
        }
    }
}
