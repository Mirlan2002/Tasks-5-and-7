using System;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using static TasksOOP.Student;
using System.Collections;

namespace TasksOOP
{
    class Program 
    {
        static void Main(string[] args)
        {
            Student p1 = new Student("Mirlan", "Daniiaruulu");
            Student p2 = new Student("Maks", "Maksimov");

            Student[] list = { p1, p2 };

            Console.WriteLine(MinIndex(list));

            Teacher teacher1 = new Teacher("Ирина", "Хмелева", list);
            //teacher1.Print();


            StudentWithAdvisor s1 = new StudentWithAdvisor(p1, teacher1);
            //s1.Print();


            Person per1 = new Person("Kemran", "Abdrashid");
            Person per2 = new Person("Nikita", "Vlasov");
            Person per3 = new Person("Miradil", "Kalygulov");

            Person[] arr = { per1, per2, per3 };

            foreach(Person p in arr)
            {
                Console.WriteLine(p);
            }

            Array.Sort(list);
            foreach (Student s in list)
            {
                Console.WriteLine(s);
            }
            using(Person n=new Person("hj","gvhvj"))
            {
                Console.WriteLine("hello world");
            }
            PersonContainer pc = new PersonContainer();
            pc.Add(per2);
            pc.Add(per3);
            pc.Add(per1);
            foreach (Person p in pc)
            {
                Console.WriteLine(p.Name);
            }
        }

        public static (int, T) MinIndex<T>(T[] arr) where T : IComparable<T>
        {
            if (arr.Length >= 1)
            {
                T min = arr.Min();
                int index = Array.IndexOf(arr, min);
                return (index, min);
            }
            else
            {
                return (-1, default(T));
            }
        }
    }

}
