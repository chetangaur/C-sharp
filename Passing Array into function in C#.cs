using System;
class HelloWorld {
    static void Find_min(int[] arr){
        int min=arr[0];                        // Program to find minimum element in an array
        for(int i=0;i<arr.Length;i++)
        {
            if(min>arr[i])
            {
                min=arr[i];
            }
            
            
        }
        Console.WriteLine(min);
        
    }
  static void Main() {
    int[] arr1={15,3,23,5,6};
    Find_min(arr1);
  }
}
