using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Palindrome
    {
        
        static void Main(string[] args)
        {
            string name = "", reversestring = "";         //create two variables 

            Console.WriteLine("Enter the String");       // for instrcution to enter the string 
            name = Console.ReadLine();                   // input string through keyboard 
            for (int i = name.Length-1; i>=0; i--)       //created for loop to reverse the string 
            {
                reversestring += name[i];
            }

            if (reversestring == name)                                                      //if condition for checking the name string is equal or not 
            {                                                                                
                Console.WriteLine($"The String is palindrome:"+reversestring);
            }
            else
            {
                Console.WriteLine("The String is not Palindrome:"+reversestring); 
            }
            Console.ReadLine();                                     
           
        }
    }
}
