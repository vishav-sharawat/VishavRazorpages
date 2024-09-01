using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer
{
    public class EmpServices : IEmpServices
    {
        private List<Employee> _emp;
        public EmpServices()
        {
            _emp = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Vishav",
                    Department = Dept.HR,
                    Email = "svishav026@gmail.com",
                    photopath = "vishav.png"
                }
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _emp;
        }
    }
}
