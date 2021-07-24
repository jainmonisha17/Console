using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program : Parent
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Student obj = new Student(); 
            obj.name = "monisha";
            obj.studentId = 1;
            obj.rollNo = "3BSC40";
            Console.WriteLine("Name : " + obj.name);
            Console.WriteLine("Student id : " + studentId);
            Console.ReadLine();
        }
    }
}
