using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CourseManagementSystem_v1
{
    internal class OnPremisCourse:Course

    {

        public string Schedule;
        public int ClassroomCapacity;

        public OnPremisCourse(string courseId, string title, string Duration, decimal Price, string schedule, int classroomCapacity):base(courseId, title, Duration, Price)
        {
            Schedule = schedule;
            ClassroomCapacity = classroomCapacity;
        }
        public override string DisplayCourseInfo()
        {
            return base.DisplayCourseInfo()+$"Schedule {Schedule}  ClassroomCapacity{ClassroomCapacity}";
        }
    }
}
