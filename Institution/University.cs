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
            
        }
    }
}
