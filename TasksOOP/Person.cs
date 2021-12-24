using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    public interface IPrintable
    {
        void Print();
    }


    public class Person : IPrintable, ICloneable, IDisposable
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Person(string name, string surName)
        {
            this.Name = name;
            this.SurName = surName;
        }


        public override string ToString()
        {
            return $"Имя:{Name}, Фамилия:{SurName}";
        }
        public virtual void Print()
        {
            Console.WriteLine(this);
        }

        void IPrintable.Print()
        {
            Console.WriteLine("Метод Print в классе Person");
        }



        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public static Person RandomPerson(Person[] arr)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, arr.Length);
            return arr[index];
        }


        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Dispose()
        {
            Console.WriteLine("Метод Dispose вызывается");
        }
    }

    public class PersonContainer : IEnumerable
    {
        List<Person> list = new List<Person>();

        public void Add(Person p)
        {
            list.Add(p);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

    }
}
