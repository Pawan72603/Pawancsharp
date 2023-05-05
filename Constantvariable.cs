using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantvariable
{
    class Program
    {
        const string name = "Pawan Kumar Chaurasiya";
        static void Main(string[] args)
        {
            const int id = 7850;
            const string designation = "Trainee";
            const string full = name + designation;

            Console.WriteLine(full + " and havng Id No.:- " + id);
            Console.ReadLine();
        }
    }
}