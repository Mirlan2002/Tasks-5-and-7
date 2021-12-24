using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    class Teacher : Person, ICloneable
    {
        public Teacher(string name, string surName, Student[] myStudents) : base(name, surName)
        {
            MyStudents = myStudents;
        }

        public Student[] MyStudents { get; set; }

        public string StudentsNames()
        {
            string str = "";
            foreach(Student s in this.MyStudents)
            {
                str += s.Name + ", ";
            }
            return str;
        }



        public override string ToString()
        {
            return base.ToString() + $" Мои студенты: {this.StudentsNames()}";
        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Teacher RandomTeacher(Teacher[] arr)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, arr.Length);
            return arr[index];
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
