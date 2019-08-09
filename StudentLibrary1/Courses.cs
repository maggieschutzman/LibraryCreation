using System;
using System.Collections.Generic;

namespace StudentLibrary1
{
    public partial class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public int? MajorId { get; set; }
        public int Grade { get; set; }
        public int StudentId { get; set; }

        public virtual Majors Major { get; set; }
    }
}
