using OCD_task.ViewModel;

namespace OCD_task.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<EmployeeVM>> GetEmployees();
        Task<EmployeeVM> GetEmployeeById(int productId);
        Task<bool> GetProductByEmail(string email);
        Task<EmployeeVM> CreateUpdateProduct(EmployeeVM productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
