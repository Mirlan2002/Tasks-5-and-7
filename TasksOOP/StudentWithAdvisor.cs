using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    class StudentWithAdvisor : Student
    {
        public StudentWithAdvisor(Student s, Teacher myTeacher) : base(s.Name, s.SurName)
        {
            MyTeacher = myTeacher;
        }
        Teacher MyTeacher { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" Мой учитель: {MyTeacher.Name}";
        }
    }
}
