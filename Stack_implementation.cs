using System;

namespace whole_stack
{
    class stack
    {
        int top;
        int max;
        int[] array_1;

        public stack(int size)
        {
            array_1= new int[size];
            top=-1;
            max=size;
        }
        public void push(int element)
        {
            if(top==max-1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                array_1[++top]=element;
            }
        }
        public int pop()
        {
            if(top==-1)
            {
                Console.WriteLine("Stak Underflow");
                return -1;
            }
            else
            {
                return array_1[top--];
            }
        }
        public void peek()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0}",array_1[top]);
            }
        }
        public void print_Stack()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            else
            {
                for(int i=top;i>-1;i--)
                {
                    Console.WriteLine("{0}",array_1[i]);
                }
            }
        }
    }
    class Main_Program
    {
        static void Main(string[] args)
        {
            stack st = new stack(5);
            st.push(10);
            st.push(20);
            st.push(30);
            st.push(40);
            st.peek();
            t.print_Stack();
            int poped_ele=st.pop();
            Console.WriteLine("{0}",poped_ele);
            st.peek();
        }
    }
}
