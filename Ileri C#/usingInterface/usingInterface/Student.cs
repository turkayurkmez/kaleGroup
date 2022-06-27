using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingInterface
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double AverageScore { get; set; }

        public int CompareTo(Student? other)
        {
            if (Age > other.Age)
            {
                return 1;
            }
            else if (Age<other.Age)
            {
                return -1;
            }

            return 0;

            
        }
    }

    public class ClassRoom : IEnumerable<Student>
    {
        //Syntactic sugar:
        private List<Student> students = new();
        public void Add(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var student in students)
            {
                yield return student;
            }
        }

        public void Sort()
        {
            students.Sort();         

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return  GetEnumerator();
        }
    }
}
