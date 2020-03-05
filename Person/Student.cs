using System;
namespace InternshipTest.Person
{
    public class Student
    {
        string studentName;
        Knowledge levelStudent;
        public Student(string name) {
            this.studentName = name;
            SetKnowledge(new Knowledge(randLevelStudent()));
        }

        public string getNameStudent() {
            return this.studentName;
        }

        public int randLevelStudent() {
            Random rnd = new Random();
            return rnd.Next(2, 10);
        }

        public void SetKnowledge(Knowledge knowledge) {
            this.levelStudent = knowledge;
            // Console.WriteLine(knowledge.getLevel());
        }
    }
}