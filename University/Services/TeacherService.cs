using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;

namespace University.Services
{
    public class TeacherService
    {

        public List<Teacher> _teachers = new List<Teacher>();
        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public Teacher Get(string id)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == id)
                    return _teachers[i];
            }
            return default(Teacher);
        }
        public List<Teacher> GetAll()
        {
            return _teachers;
        }

        public void Remove(Teacher teacher)
        {
            _teachers.Remove(teacher);
        }

        public void Update(Teacher teacher)
        {
            for (int i = 0; i < _teachers.Count; i++)
            {
                if (_teachers[i]._id == teacher._id)
                {
                    _teachers[i] = teacher;
                }
            }
        }
    }
}
