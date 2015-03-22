using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF.Models
{

    public class Student 
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }

    }
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}