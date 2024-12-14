
using System;

namespace stack
{
    class Program
    {
        static int[] stack = new int[5];
        static int top = -1;
        static int result;

        public static void Push(int item)
        {
            if (top == stack.Length - 1)
            {
                Console.WriteLine("Stack overflow: Cannot push " + item);
                return;
            }
            stack[++top] = item;
        }

        public static int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow: Cannot pop from empty stack");
                return -1; 
            }
            return stack[top--];
        }

        public static int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty: Cannot peek");
                
            }
            return stack[top];
        }

        public static bool IsEmpty()
        {
            return top == -1;
        }
        public static void  converttoqueue()
        {
            int[] queue = new int[stack.Length ];
            int w = top;//w=5
            Console.WriteLine("convert to queue");
            for(int i = 0 ; i <= w ; i++)
            {
                queue[i] = stack[i];
            }
            for(int i = 0 ; i <= queue.Length ; i++)
            {
                
                Console.Write(queue[i]);
            }
            
            
            
        }

        static void Main(string[] args)
        {
            Push(1);
            Push(2);
            Push(3);
            Push(4);
            Push(5);
            

            Console.WriteLine("Top item: " + Peek()); // Display the top item

            Pop(); 
            Console.WriteLine("Top item after pop: " + Peek());
            Push(5);
            Console.WriteLine("pushing the 6 and overflow");
            Push(6);
            converttoqueue();
            
          
        }
    }
}
