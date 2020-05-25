using System;  
// Arrayda-ki eyni elementlerin sayını tapan program - Farhad iskandarov - Number-1
public class DuplicateElement  
{  
    public static void Main()  
    {  
        //Initialize array   
        int [] arr = new int [] {1, 2, 3, 4, 2, 7, 8, 8, 3};   
          
        Console.WriteLine("Arrayda-ki eyni elementlerin sayı: ");
        for(int i = 0; i < arr.Length; i++) {  
            for(int j = i + 1; j < arr.Length; j++) {  
                if(arr[i] == arr[j])  
                    Console.WriteLine(arr[j]);  
            }  
        }  
    }  
}