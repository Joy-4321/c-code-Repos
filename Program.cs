//using System.Data;
//using Internal;
// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Configuration.Assemblies;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace program
{
    class  Beauty{
        static void Main(string[]args)
        {
            string fname,lname;
            Console.Write("Enter your First name: ");
            fname = Console.ReadLine();
            Console.Write("Enter your Last name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Hi, am joyful welcome to my world!, you are "+fname+" "+lname);
 
        }
    }
}

