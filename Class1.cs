using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        

        static void Main()
        {
            String Name = Console.ReadLine();
            int n = 1;
            for (int i = 0; i <Name.Length; i++)
            {
                for (int j = i+1; j <Name.Length ; j++)
                {
                    if (Name[i] == Name[j])
                    {
                        Console.WriteLine(Name[i]);
                        n++;
    ;                    }
                }
            }Console.WriteLine(n+"");
            
        }Console.ReadLine();


    }
}
