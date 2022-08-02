using HtmlHelperTagPractice.Depandancy;
using HtmlHelperTagPractice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HtmlHelperTagPractice.Controllers
{
    public class StudentController : Controller
    {
        private StudentOperations _student;

        public StudentController(StudentOperations student)
        {
            _student = student;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            var studentList= _student.GetAllStudents();
            return View(studentList);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View(_student.getById(id));
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Students student)
        {
            try
            {
                _student.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(_student.getById(id));
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Students student)
        {
            try
            {
                _student.EditStudents(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            _student.DeleteStudents(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: StudentController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
