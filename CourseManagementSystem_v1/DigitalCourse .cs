using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class DigitalCourse:Course
    {
        public string CourseLink;
        public int FileSize;

        public DigitalCourse(string courseId, string title, string Duration,decimal Price, string courseLink, int fileSize):base(courseId, title, Duration, Price)
        {
            CourseLink = courseLink;
            FileSize = fileSize;
        }
    }
}
