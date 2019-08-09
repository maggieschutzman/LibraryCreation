using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary1 {
    public class StudentLib {
        public static string About = "About StudentLib";

        public List<Students> ListStudents() {
            var db = new AppEfdbContext();
            return db.Students.ToList();

        }

    }
}
