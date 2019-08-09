using System;
using StudentLibrary1;
using UtilityLibrary;

namespace StudentLibrary1 {
    class Program {
        static void Main(string[] args) {

            var about = StudentLib.About;
            UtilityLibrary.Console.Print(about);

            var lib = new StudentLib();
            var students = lib.ListStudents();
            foreach (var student in students) {
                System.Console.WriteLine($"{student.Firstname} {student.Lastname}");


            }
        }
    }
}
