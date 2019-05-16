using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentServiceController : ControllerBase
    {
        Models.StudentData _students;

        public StudentServiceController(Models.StudentData student)
        {
            _students = student;
        }
        /// <summary>
        /// Get all student data
        /// </summary>
        /// <returns></returns>
        public List<Models.Student> Get()
        {
            return _students.Students;
        }

        /// <summary>
        /// Get student by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Models.Student Get(Guid id)
        {
            return _students.GetStudent(id);
        }

        /// <summary>
        /// Create a new student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public bool Post(Models.Student student)
        {
            return _students.Add(student);
        }

        /// <summary>
        /// Edit an existing student
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPut]
        public bool Put(Models.Student student)
        {
            return _students.Update(student);
        }

        /// <summary>
        /// Delete a student
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public bool Delete(Guid id)
        {
            return _students.Delete(id);
        }
    }
}