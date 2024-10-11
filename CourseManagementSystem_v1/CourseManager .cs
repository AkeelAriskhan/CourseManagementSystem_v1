using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {

          List<Course> courses=new List<Course>();
        public void CreateCourse(string courseId, string title, string Duration, decimal Price)
        {
            var newcourse =new Course(courseId, title, Duration, Price);
            courses.Add(newcourse);
            Console.WriteLine("Course Added sucseefully");
        }
        public void  ReadCourses()
        {
            Console.WriteLine("courses list");
            foreach (var item in courses) 
            {
             Console.WriteLine(item);
            }
        }
        public void UpdateCourse(string courseId, string title, string Duration, decimal Price)
        {
             var  course=courses.Find(x => x.courseId == courseId);
               course.title = title;
            course.Duration = Duration; 
            course.Price = Price;
            Console.WriteLine("Course Added Updated");
        }
        public void DeleteCourse(string courseId) 
        {
            var course = courses.Find(x => x.courseId == courseId);
            courses.Remove(course);
            Console.WriteLine("Course Deleted");

        }
        public decimal ValidateCoursePrice()
        {
            decimal price = 0;
            while (true)
            {
                Console.Write("enter a course price");
                 decimal proprice =decimal.Parse(Console.ReadLine());
                if (proprice > 0)
                {
                    price = proprice;
                    break;
                }else
                {
                    Console.WriteLine("price must be positive number");
                }
               

            }
            return price;
        }
    }
}
