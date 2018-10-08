using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Yacht01.exercises
{
    class EnumerableExcercise : IEnumerable<EnumerableExcercise.Person>
    {
        public static void Run(string[] args)
        {
            EnumerableExcercise excercise = new EnumerableExcercise(new Person[] {
                new Person("a", "a"),
                new Person("b", "b"),
                new Person("c", "c"),
                new Person("d", "d"),
            });
            
            foreach (Person p in excercise)
            {
                Debug.WriteLine(p);
            }
        }

        public Person[] People { get; set; }

        public EnumerableExcercise(Person[] people)
        {
            this.People = people;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            foreach(Person person in People)
            {
                yield return person;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public Person(String firstName, String lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }

            public override string ToString()
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
