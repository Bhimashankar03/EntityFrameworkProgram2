using EntityFrameworkProgram2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkProgram2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeDbContext db = new EmployeeDbContext();
            var employee = db.Employees.ToList();
            return View(employee);
        }
        [HttpGet]
        public IActionResult Create()
        {
            Employee employee = new Employee();

            return View(employee);
            
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            var employee=db.Employees.FirstOrDefault(x=>x.EmpId==id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            var employee = db.Employees.FirstOrDefault(x => x.EmpId == id);
           
           

            return View(employee);
        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            //EmployeeDbContext db = new EmployeeDbContext();
            //var employeeToUpdate = db.Employees.FirstOrDefault(x => x.EmpId == employee.EmpId);

            //employeeToUpdate.EmpName = employee.EmpName;
            //employeeToUpdate.EmpName = employee.Address;
            //employeeToUpdate.EmpName = employee.EmpMail;
            //db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
