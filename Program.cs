using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastables1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable studentTable = new Hashtable();

            Student stud1 = new Student(1,"mTTT",99);
            Student stud2 = new Student(2, "mDDDTTT", 76);
            Student stud3 = new Student(3, "mTTdwdwdT", 43);
            Student stud4 = new Student(4, "mTTdwdwdwT", 55);

            studentTable.Add(stud1.Id,stud1);
            studentTable.Add(stud2.Id, stud2);
            studentTable.Add(stud3.Id, stud3);
            studentTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentTable[stud1.Id];

            foreach (DictionaryEntry entry in studentTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID:{0}",temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);

            }

        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name,float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA=GPA;

        }
    }

}
