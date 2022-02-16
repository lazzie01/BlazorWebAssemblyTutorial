using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

namespace BlazorProject.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            if(employee.Department != null)
            {
                appDbContext.Entry(employee.Department).State = EntityState.Unchanged;
            }
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employees.FirstOrDefaultAsync(e => e.EmployeeId == employeeId);

            if(result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await appDbContext.Employees
                                     .Include(e => e.Department)
                                     .FirstOrDefaultAsync(e => e.EmployeeId == employeeId);
        }

        public async Task<Employee> GetEmployeeByEmail(string email)
        {
            return await appDbContext.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip = 0, int take = 5, string orderBy = "EmployeeId")
        {
            EmployeeDataResult result = new EmployeeDataResult
            {
                Employees = appDbContext.Employees.OrderBy(orderBy).Skip(skip).Take(take),
                Count = await appDbContext.Employees.CountAsync()
            };
            return result;
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = appDbContext.Employees;

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }

            if(gender != null)
            {
                query = query.Where(e => e.Gender == gender);
            }

            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
           var result = await appDbContext.Employees
                                          .FirstOrDefaultAsync(e => e.EmployeeId == employee.EmployeeId);

            if(result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateOfBirth = employee.DateOfBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
