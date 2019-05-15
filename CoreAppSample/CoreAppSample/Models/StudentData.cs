using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreAppSample.Models
{
    public class StudentData
    {
        public List<Student> Students { get; private set; }

        public StudentData()
        {
            Students = new List<Student>();
            Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Alex", FathersName = "Steve", Age = 10 });
            Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Bran", FathersName = "Mark", Age = 12 });
            Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Jon", FathersName = "Dean", Age = 9 });
            Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Linda", FathersName = "Bran", Age = 11 });
            Students.Add(new Student() { Id = Guid.NewGuid(), Name = "Rachel", FathersName = "Jack", Age = 15 });
        }

        public Models.Student GetStudent(Guid id)
        {
            Models.Student student = Students.Where(x => x.Id == id).First();
            return student;
        }

        public bool Add(Models.Student student)
        {
            Students.Add(student);
            return true;
        }

        public bool Update(Models.Student student)
        {
            Models.Student std = Students.Where(x => x.Id == student.Id).First();
            std.Name = student.Name;
            std.FathersName = student.FathersName;
            std.Age = student.Age;
            return true;
        }

        public bool Delete(Guid id)
        {
            Students.Remove(Students.Where(x => x.Id == id).First());
            return true;
        }
    }
}
