using System;
using System.Collections.Generic;

namespace Session8Pro.Data
{
    public interface IRepostory
    {
        Guid AddStudent(Student student);
        void DeleteStudent(Guid id);
        Student UpdateStudent(Student student);
        IEnumerable<Student> GetAllStudents();

        Student GetStudent(Guid id);
    }
}
