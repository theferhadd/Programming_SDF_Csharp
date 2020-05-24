using System;
/*2.Her hansı bir sözün unique elementlerden ibaret olub olmadığını yoxlayan proqram*/
class Helloworld{
    static void Main(){
        Console.WriteLine("** Number 2 **");
        var myStr1="AZERBAYCAN";
        IsUnique(myStr1);
        var myStr2="KARANTIN";
        IsUnique(myStr2);
        var myStr3="KİTAB";
        IsUnique(myStr3);
        var myStr4="FERHAD";
        IsUnique(myStr4);
        var myStr5="dünya";
        IsUnique(myStr5);
        var myStr6="PROGRAMLAŞDIRMA";
        RevertConsonants(myStr6);
    
    }
    static void  IsUnique(string word)
    {
        for( int t=0;t<word.Length;t++)
        {
            for( int j=0;j<word.Length;j++)
            {
                if(t!=j && word[t]==word[j]) 
                {
                    Console.WriteLine(word + "---is not Unique");
                    return;
                
                }
               
            }
        }
      
        Console.WriteLine(word + "---is Unique");
     
    }
  
    /*3.Her hansı bir sözün yalnız samitlerini ters istiqametde yazan proqram.*/
    static void RevertConsonants(string word)
    {
       
        char [] saitler = {'A','I','E','E','İ','Ö','Ü','a','ı','o','u','e','E','i','ö','ü'};
        string soz ="";
        Console.WriteLine("*** Number 3 ***");
        Console.WriteLine("PROGRAMLAŞDIRMA");
        for(int i=word.Length-1;i>=0;i--)
        {
            if(Array.IndexOf(saitler,word[i])== -1) 
            {
                soz += word[i]; 
            }
        }
        Console.WriteLine(soz);  
    }
}