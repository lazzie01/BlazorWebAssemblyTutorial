using BlazorProject.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorProject.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await httpClient
               .GetFromJsonAsync<IEnumerable<Employee>>($"api/employees/all");
        }

        public Task<Employee> GetEmployee(int employeeId)
        {
            throw new NotImplementedException();

        }

        public Task<Employee> GetEmployeeByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<EmployeeDataResult> GetEmployees(int skip, int take, string orderBy)
        {
            return await httpClient
                .GetFromJsonAsync<EmployeeDataResult>($"api/employees?skip={skip}&take={take}&orderBy={orderBy}");
        }

        public Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            //var x1 = httpClient.PostAsJsonAsync<Employee>("api/employees", employee);
            throw new NotImplementedException();
        }
    }
}
