using Company.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Services
{
  public   class SqlCompanyData : ICompanyData
    {
        private readonly CompanyDbContext db;

        public SqlCompanyData(CompanyDbContext db)
        {
            this.db = db;
        }

        public void Add(Employee Employee)
        {
            db.Employee.Add(Employee);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var employee = db.Employee.Find(id);
            db.Employee.Remove(employee);
            db.SaveChanges();

        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employee;
        }

        public void Update(Employee Employee)
        {
            var entry = db.Entry(Employee);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
