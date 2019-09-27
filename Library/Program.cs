using System;
using StudentLibrary1;
using UtilityLibrary;

namespace StudentLibrary1 {
    class Program {
        static void Main(string[] args) {

            //update 'imma' to 'zach' id = 1
            var lib = new StudentLib();
            var imma = lib.GetStudent(1);
            imma.Firstname = "Zach";
            var success = lib.UpdateStudent(imma);

            var ef1 = new Student {
                Id = 0,
                Firstname = "Elmer",
                Lastname = "Fudd",
                Sat = 500,
                Gpa = 1.4,
                IsFulltime = true,
                MajorId = 1
            };
            var ok = lib.InsertStudent(ef1);

            System.Console.WriteLine((ok ? "Insert Successful!" : "Insert Failed!"));


            c

        }
    }
    }


            //var about = StudentLib.About;
            //UtilityLibrary.Console.Print(about);

            //var lib = new StudentLib();
            //var students = lib.ListStudents();
            //foreach (var student in students) {
            //    System.Console.WriteLine($"{student.Firstname} {student.Lastname} {student.Major.Description}");
   
            //}

            //this should work
 //           var s1 = lib.GetStudent(1);
 //           if (s1 == null) {
 //               System.Console.WriteLine("Student not found!");
 //           }
 //           else {
 //               System.Console.WriteLine($"S1: {s1.Firstname} {s1.Lastname} {s1.Major.Description}");
 //           }
 //           //this should fail
 //           var s444 = lib.GetStudent(444);
 //           if (s444 == null) {
 //               System.Console.WriteLine("Student not found!");
 //           }
 //           else {
 //               System.Console.WriteLine($"S1: {s444.Firstname} {s444.Lastname} {s444.Major.Description}");
 //           }
 //       }
 //   }
 //}

