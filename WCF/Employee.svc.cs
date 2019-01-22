
using BusinessObjects;
using System;
using System.Collections.Generic;

namespace MyServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Employee.svc or Employee.svc.cs at the Solution Explorer and start debugging.
    public class Employee : IEmployee
    {
        public List<string> getEmpNames()
        {
            BOEmployee bo = new BOEmployee() ;
            return bo.GetEmployeeNames();
            

        }
         
        public List<SimpleEmployee> getEmployees()
        {
            BOEmployee bo = new BOEmployee();
            return bo.getEmployees();
        }

    }
}
