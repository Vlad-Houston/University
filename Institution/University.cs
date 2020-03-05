using InternshipTest.Person;
using System.Collections.Generic;

namespace InternshipTest.Institution
{
    public class University
    {
        string nameUniversity;
        public University(string name) {
            this.nameUniversity = name;
        }

        public string getNameUniversity() {
            return this.nameUniversity;
        }

        public void AddStudent(Student student) {
            System.Console.WriteLine($"Name student: {student.getNameStudent()}");
            System.Console.WriteLine($"Level knowledge: {student.getLevelKnowledge()}");
        }
    }
}
