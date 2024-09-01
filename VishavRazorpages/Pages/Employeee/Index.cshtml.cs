using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RepoLayer;

namespace VishavRazorpages.Pages.Employeee
{
    public class IndexModel : PageModel
    {
        private readonly IEmpServices _emp;
        public IEnumerable<Employee> Employees { get; set; }
        public IndexModel(IEmpServices emp) 
        {
            _emp = emp;
        } 
        public void OnGet()
        {
            Employees = _emp.GetAllEmployee();
        }
    }
}
