using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Many_To_Many.Models
{
    public class Stu
    {
        public Stu()
        {
            this.Courses = new HashSet<Course>();
        }

        public int StudentId { get; set; }
 
        public string StudentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }




    }
    public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Stu>();
        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<Stu> Students { get; set; }
    }





}