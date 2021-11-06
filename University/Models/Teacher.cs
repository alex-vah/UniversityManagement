using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.id_generator;

namespace University.Models
{
    public class Teacher
    {
        public Teacher(string name, int age)
        {
            _name = name;
            _age = age;
            _students = new List<Student>();
            Id idGen = new Id();
            _id = idGen.NewTeacherId();
        }
        public Teacher()
        {
            Id idGen = new Id();
            _id = idGen.NewTeacherId();
        }
        public string _id;
        public string _name;
        public int _age;
        public List<Student> _students;
    }
}
