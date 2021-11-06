using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.id_generator;

namespace University.Services
{
    public class UniversityService
    {
        private StudentService _studentService;
        private  TeacherService _teacherService;
        public List<Teacher> _teachers = new List<Teacher>();
        public List<Student> _students = new List<Student>();

        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _studentService = studentService;
            _teacherService = teacherService;
        }
        public void GetTeacher()
        {
            for (int i = 0; i<_students.Count; i++)
            {
                _students[i]._teacher = _teachers[i % _teachers.Count];
            }
        }

        public void GetStudents(Teacher teacher)
        {
            List<Student> students = new List<Student>();
            int j = 0;
            for (int i = 0;  i<_students.Count; i++)
            {
                if (_students[i]._teacher==teacher)
                {
                    students[j] = _students[i];
                    j++;
                }
            }
        }
    }
}
