using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentLibrary1 {
    public class StudentLib {
        public static string About = "About StudentLib";

        public List<Student> ListStudents() {
            var db = new AppEfdbContext();
            return db.Students.ToList();

        }
        public Student GetStudent(int id) {
            var db = new AppEfdbContext();
            db.Students.Find(id);
            return db.Students.Find(id);

        }

    }
}
