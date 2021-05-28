using System;

namespace C__prog
{
    class Program
    {
        
        static void Main(string[] args)

        { 
            int[] arr = {10,60,20,100,5};
            Console.WriteLine("before sorting");
            foreach(int ele in arr){
                Console.WriteLine(ele);
            }
            Array.Sort(arr);
            Console.WriteLine("after sorting");
            foreach(int ele in arr){
                Console.WriteLine(ele);
            }
            
 
        }
    }
}
