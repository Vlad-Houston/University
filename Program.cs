using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Alex");
            University university = new University("CH.U.I.");

            university.AddStudent(new Student("Andrew Kostenko"));
            // university.AddStudent(new Student("Julia Veselkina"));
            // university.AddStudent(new Student("Maria Perechrest"));
            
            // Console.WriteLine(university.getNameUniversity());
            // Console.WriteLine(s.getNameStudent());
            // Console.WriteLine(s.getLevelKnowledge());


            //Потрібно зразу вирішувати чи проходить 
            //студент інтернатуру по середньому балу чи ні.


            // Internship internship = new Internship("Interlink");
            // Console.WriteLine("List of internship's students:");

        }
    }
}
