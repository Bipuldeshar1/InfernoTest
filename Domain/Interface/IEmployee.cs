using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IEmployee
    {
        Task  AddEmployee(Employee employee);
        Task  UpdateEmployee(Employee employee);
        Task  DeleteEmployee(Employee employee);
        Task  GetAllEmployee(Employee employee);
        Task  GetEmployeeById(Employee employee);

    }
}
