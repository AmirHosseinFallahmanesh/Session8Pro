using System;
using System.Collections.Generic;
using System.Linq;

namespace Session8Pro.Data
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public string Name { get; set; }
        public float Average { get; set; }
    }

    public class FakeRepository:IRepostory
    {

        private static new FakeRepository repo = new FakeRepository();

        public static FakeRepository Current { get => repo; }

        private List<Student> students = new List<Student>()
        {
        new Student(){Average=12.2f,Name="amir",StudentId=Guid.NewGuid()},
        new Student(){Average=115f,Name="reza",StudentId=Guid.NewGuid()},
        };

        public Guid AddStudent(Student student)
        {
            student.StudentId = Guid.NewGuid();
            students.Add(student);
            return student.StudentId;
        }

        public void DeleteStudent(Guid id)
        {
            var student = GetStudent(id);
            students.Remove(student);
        }


        public Student UpdateStudent(Student student)
        {
            //var index = students.FindIndex(a => a.StudentId == student.StudentId);
            //students[index] = student;

            var result = students.Where(a => a.StudentId == student.StudentId)
                  .Select(c => { c.Name = student.Name; c.Average = student.Average; return c; }).First();
            return result;
        }


        public IEnumerable<Student> GetAllStudents() => students;

        public Student GetStudent(Guid id) => students.First(a => a.StudentId == id);




    }
}
