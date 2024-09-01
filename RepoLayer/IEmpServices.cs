using BusinessLogicLayer;

namespace RepoLayer
{
    public interface IEmpServices
    {
        IEnumerable<Employee> GetAllEmployee();
    }
}
