using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {

        public string courseId { get; set; }
        public string title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
        public static int TotalCourses =0;

        public Course(string courseId, string title, string Duration, decimal Price)
        {
            this.courseId = courseId;
            this.title = title;
            this.Duration = Duration;
            this.Price = Price;
            TotalCourses++;
        }

        public override string ToString()
        {
            return $"courseId:{courseId}  title :{title} Duration:{Duration} Price: {Price}";
        }

        public virtual string DisplayCourseInfo()
        {
            return $"courseId:{courseId}  title :{title} Duration:{Duration} Price: {Price}";
        }
    }
}
