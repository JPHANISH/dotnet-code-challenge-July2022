using CodeChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Services
{
    public interface IEmployeeService
    {
        Employee GetById(String id);
        Employee Create(Employee employee);
        ReportingStructure GetReportingStructureById(string id);
        Employee Replace(Employee originalEmployee, Employee newEmployee);
        Compensation GetCompensationByEmployee(String id);
        Compensation CreateCompensation(Compensation compensation);
    }
}
