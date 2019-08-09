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

        public bool UpdateStudent(Student s) {
            var db = new AppEfdbContext();
            var sDB = GetStudent(s.Id);
            if (sDB == null) {
                throw new Exception("Student cannot be found!");
            }
            sDB.Firstname = s.Firstname;
            sDB.Lastname = s.Lastname;
            sDB.Gpa = s.Gpa;
            sDB.Sat = s.Sat;
            sDB.IsFulltime = s.IsFulltime;
            sDB.MajorId = s.MajorId; //see if it exist
            var major = db.Majors.Find(s.MajorId);
            if (major == null) {
                return false;
            }
            //or db.Students.Update(sDB);
            db.Update<Student>(s);
            db.SaveChanges();
            return true;
        }

        public bool DeleteStudent(Student s) {
            var db = new AppEfdbContext();
            var sdb = GetStudent(s.Id);
            if (sdb == null) {
                throw new Exception("No such student exist!");
            }
            db.Remove(s);
            db.SaveChanges();
            return true;
        }

        public bool InsertStudent(Student s) {
            var db = new AppEfdbContext();
            s.Id = 0;
            if (s.MajorId != null) {
                var major = db.Majors.Find(s.MajorId);
                if (major == null) {
                    return false;
                }
            }
                db.Update<Student>(s);
                db.SaveChanges();
                return true;
            }

        }
    }


