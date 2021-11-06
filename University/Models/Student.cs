using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.id_generator;

namespace University.Models
{
    public class Student
    {
        public Student(string name, int age)
        {
            _name = name;
            _age = age;
            Id idGen = new Id();
            _id = idGen.NewStudentId();
        }
        public Student()
        {
            Id idGen = new Id();
            _id = idGen.NewStudentId();
        }
        public string _id;
        public int _age;
        public string _name;
        public Teacher _teacher;
    }
}
