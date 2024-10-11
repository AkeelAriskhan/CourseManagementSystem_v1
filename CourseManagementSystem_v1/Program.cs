using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course("C_001", "phython", "3months", 10);
            Console.WriteLine(course1.ToString());
        }
    }
}
