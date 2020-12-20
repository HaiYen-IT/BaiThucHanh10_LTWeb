using Cau2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cau2.Controllers
{
    public class StudentController : Controller
    {
        private StudentList StudentLst = new StudentList();
        // GET: Student
        public ActionResult Index()
        {
            List<Student> myStudent = StudentLst.StudentGetAll();
            return View(myStudent);
        }
        

    }
}