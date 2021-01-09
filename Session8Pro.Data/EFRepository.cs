using System;
using System.Collections.Generic;
using System.Linq;

namespace Session8Pro.Data
{
    public class EFRepository : IRepostory
    {
        private readonly DemoContext demoContext;

        public EFRepository(DemoContext demoContext)
        {
            this.demoContext = demoContext;
        }
        public Guid AddStudent(Student student)
        {
            student.StudentId = Guid.NewGuid();
            demoContext.Add(student);
            demoContext.SaveChanges();
            return student.StudentId;
        }

        public void DeleteStudent(Guid id)
        {

        }


        public Student UpdateStudent(Student student)
        {
            //var index = students.FindIndex(a => a.StudentId == student.StudentId);
            //students[index] = student;

            demoContext.Update(student);
            demoContext.SaveChanges();
            return student;
        }


        public IEnumerable<Student> GetAllStudents() => demoContext.Students.ToList();

        public Student GetStudent(Guid id) => demoContext.Students.Find(id);
    }
}
