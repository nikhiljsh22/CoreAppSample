using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace CoreAppSample.Controllers
{
    public class StudentController : Controller
    {

        IConfiguration _configuration;
        public StudentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(_configuration.GetValue<string>("AppConfig:Url"));
            var result = client.GetStringAsync("/api/StudentService");
            List<Models.Student> students = JsonConvert.DeserializeObject<List<Models.Student>>(result.Result);

            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Guid id, [Bind("Name,FathersName,Age")]Models.Student student)
        {
            student.Id = Guid.NewGuid();
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(_configuration.GetValue<string>("AppConfig:Url"));
            System.Net.Http.ObjectContent content = new System.Net.Http.ObjectContent(typeof(Models.Student), student, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            var result = client.PostAsync("/api/StudentService/", content).Result;

            return RedirectToAction("Index");
        }

        public IActionResult Edit(Guid id)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(_configuration.GetValue<string>("AppConfig:Url"));
            var result = client.GetStringAsync("/api/StudentService/" + id);
            Models.Student student = JsonConvert.DeserializeObject<Models.Student>(result.Result);

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Guid id, [Bind("Id,Name,FathersName,Age")]Models.Student student)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(_configuration.GetValue<string>("AppConfig:Url"));
            System.Net.Http.ObjectContent content = new System.Net.Http.ObjectContent(typeof(Models.Student), student, new System.Net.Http.Formatting.JsonMediaTypeFormatter());
            var result = client.PutAsync("/api/StudentService/", content).Result;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(_configuration.GetValue<string>("AppConfig:Url"));
            var result = client.DeleteAsync("/api/StudentService/" + id).Result;

            return RedirectToAction("Index");
        }
    }
}