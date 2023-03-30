using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Model_ViewModel__HomeWork_.Models;

namespace Model_ViewModel__HomeWork_.Controllers
{
    public class StudentController : Controller
    {
        List<Student> _students;
        List<Group> _groups;
        public StudentController()
        {
            _students = new List<Student>
            {
                new Student { Id = 1, FullName = "Rashad Abbasov", Point = 75,GroupId=2,GroupName="Back-End Programming" },
                new Student { Id = 2, FullName = "Nicat Abbasov", Point = 95,GroupId=1,GroupName="Cyber Security"  },
                new Student { Id = 3, FullName = "Jamil Safarov", Point = 65,GroupId=2,GroupName="Front-End Programming"  },
                new Student { Id = 4, FullName = "Rovshan Suleymanov", Point = 45,GroupId=2,GroupName="Design"  },
            };

          
        }



        public IActionResult Index()
        {


            ViewBag.Students = _students;
         

            return View();
        }

        public IActionResult Detail(int id)
        {
            Student std = _students.Find(x => x.Id == id);
            ViewBag.Students = std;
            return View();
        }
    }
}
