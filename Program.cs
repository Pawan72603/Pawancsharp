using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
 class Program
    {
     static void Palindrome()
     {
         string name = "", reversestring = "";                                                //create two variables 

         Console.WriteLine("Enter the String");                                              // for instrcution to enter the string 
         name = Console.ReadLine();                                                         // input string through keyboard 
         for (int i = name.Length - 1; i >= 0; i--)                                        //created for loop to reverse the string 
         {
             reversestring += name[i];
         }

         if (reversestring == name)                                                      //if condition for checking the name string is equal or not 
         {
             Console.WriteLine(name + "  is a palindrome Value and the reverse value is" + reversestring);
         }
         else
         {
             Console.WriteLine(name + " is not palindrome Value and the reverse value is :" + reversestring);
         }
         Console.ReadLine();                                                            //to shows the result on Consol screen
     }
        static void Main(string[] args)
        {
            Program.Palindrome();                                                       //call static method using Classname.
           
        }
    }
}