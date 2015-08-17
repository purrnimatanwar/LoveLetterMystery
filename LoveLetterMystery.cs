using System;
using System.Collections.Generic;
using System.IO;
class Solution {
  
    static int stringReduction(string words)
        {
           int reduction=0;
           int values=words.Length;
             int mid= values/2;

        
           System.Text.StringBuilder strBuilder = new System.Text.StringBuilder(words);
            for(int i=0,j=values-1; i<=mid; i++, j--)
                {
                if(j>=mid)
                    {
                 int a=System.Convert.ToInt32(strBuilder[i])-System.Convert.ToInt32(strBuilder[j]) ;
                     if(a>0)
                    {
                       reduction=reduction+a; 
                    }
                    if(a<0)
                        {
                        reduction=reduction+(-a);
                    }
                }
            }
          
            return reduction;
       }
    
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int testcase= Convert.ToInt32(Console.ReadLine());
        string[] letter= new string[testcase];
        
        for(int i=0;i<testcase;i++)
            {
            letter[i]=Console.ReadLine();
        
            }
        for(int i=0;i<testcase;i++)
            {
         
            Console.WriteLine(stringReduction(letter[i]));
        }
    }
}