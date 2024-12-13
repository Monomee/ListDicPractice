using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDicPractice
{
    public class Student
    {
        private int id;
        private string name;
        private double grade;

        public Student()
        {
        }

        public Student(int id, string name, double grade)
        {
            this.id = id;
            this.name = name;
            this.grade = grade;
        }

        public string Name { get => name; set => name = value; }
        public double Grade { get => grade; set => grade = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return Id + ". Name: " + Name + "\tGrade: " + Grade;
        }
    }
}
