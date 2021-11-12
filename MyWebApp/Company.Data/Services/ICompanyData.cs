using Company.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Services
{
   public interface ICompanyData
    {
        IEnumerable<Employee> GetAll();
        void Add(Employee Employee);
        Employee Get(int id);
        void Update(Employee Employee);
        void Update(int id);
        void Delete(int id);
    }
}
