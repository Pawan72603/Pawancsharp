using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{
    class Program
    {
        static int Salary;
        static string name = "Pawan Kumar Chaurasiya";
        static string designation = "";
        static void Main()
        {
            Program.designation = "Trainee";
            Program.Salary = 7850;
            Console.WriteLine(Program.name + "  designation is " + Program.designation + "  and his salary is  " + Program.Salary);
            Console.ReadLine();

        }
    }
}

