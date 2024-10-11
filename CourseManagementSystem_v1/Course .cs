using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {

          public string courseId {  get; set; }
           private string title { get; set; }
           private string Duration { get; set; }
            private decimal Price { get; set; }

        public Course(string courseId, string title, string Duration, decimal Price)
        {
            this.courseId = courseId;
            this.title = title;
            this. Duration = Duration;
            this. Price = Price;
        }

        public override string ToString()
        {
            return $"courseId:{courseId}  title :{title} Duration:{Duration} Price: {Price}";
        }
    }
}
