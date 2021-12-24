using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    class Student : Person, IPrintable, IComparable<Student>, ICloneable
    {
        public Student(string name, string surName) : base(name, surName)
        {}

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Метод Print в классе Student");
        }


        public static Student RandomStudent(Student[] arr)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, arr.Length);
            return arr[index];
        }

        public override object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Student s)
        {
            return this.Name.CompareTo(s.Name);

        }


        public static IComparer sortByName { get;}
        public static IComparer sortBySurName { get; }

        public class StudentComparer : IComparer<Student>
        {
            IComparer sortingCriterion;
            public StudentComparer(IComparer sortingCriterion)
            {
                this.sortingCriterion = sortingCriterion;
            }

            public int Compare(Student x, Student y)
            {
                if(sortingCriterion == sortByName)
                {
                    if (x.Name.Length > y.Name.Length)
                        return 1;
                    else if (x.Name.Length == y.Name.Length)
                        return 0;
                    else
                        return -1;
                }
                else
                {
                    if (x.SurName.Length > y.SurName.Length)
                        return 1;
                    else if (x.SurName.Length == y.SurName.Length)
                        return 0;
                    else
                        return -1;
                }
            }
        }
    }
}
