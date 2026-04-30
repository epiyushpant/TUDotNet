using LearnADODotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LearnADODotnet.Controllers
{
    //[Route("Employee")]
    public class EmployeeController : Controller
    {
        EmployeeDataAccessLayer objemployee;

        public EmployeeController(IConfiguration configuration)
        {
            objemployee = new EmployeeDataAccessLayer(configuration);
        }

        // GET: /Employee/Index (conventional)
        public IActionResult Index()
        {
            List<Employee> lstEmployee = objemployee.GetAllEmployees().ToList();
            int totalEmployees = objemployee.GetTotalEmployee();

            var viewModel = new EmployeeIndexViewModel
            {
                Employees = lstEmployee,
                TotalEmployees = totalEmployees
            };

            return View(viewModel);
        }

        // GET: /Employee/Create (conventional)
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Employee/Create (conventional)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Employee employee)
        {
            if (ModelState.IsValid)
            {
                objemployee.AddEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: /Employee/Edit/5 (conventional)
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: /Employee/Edit/5 (conventional)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objemployee.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: /Employee/Details/5 (attribute routing)
        [Route("Employee/Details/{id}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: /Employee/Delete/5 (conventional)
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Employee employee = objemployee.GetEmployeeData(id);

            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: /Employee/Delete/5 (conventional)
        [HttpPost]
        [ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            objemployee.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}