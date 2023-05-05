using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticReadOnly
{
    class Program
    {
        static Program()
        {
            designation = "Trainee";
        }
        static readonly int Id = 84;
        static readonly string name = "Pawan Kumar Chaurasiya";
        static readonly string designation = "";
        Program()
        {
            Console.WriteLine(Program.name + "designation is " + Program.designation + " holding id is " + Program.Id);

        }
        static void Main()
        {
            Program obj = new Program();
            
            Console.ReadLine();

        }
    }
}