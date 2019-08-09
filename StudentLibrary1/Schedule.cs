using System;
using System.Collections.Generic;

namespace StudentLibrary1
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int? MajorId { get; set; }

        public virtual Majors Major { get; set; }
        public virtual Student Student { get; set; }
    }
}
