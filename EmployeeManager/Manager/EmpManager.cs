using EmployeeManager.Interface;
using EmployeeModels;
using EmployeeRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager.Manager
{
   public class EmpManager:IEmpManager
    {
        readonly IEmpRepository Emprepository;
        public EmpManager(IEmpRepository Emprepository)
        {
            this.Emprepository = Emprepository;
        }

        public string EmployeeDetails(EmployeeDetails employeeDetails)
        {
            try
            {
                return this.Emprepository.EmployeeDetails(employeeDetails);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string Delete(string deleteData)
        {
            try
            {
                return this.Emprepository.Delete(deleteData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Edit(string edit)
        {
            throw new NotImplementedException();
        }

        public string Edit(string edit, string gender, string department, int salary, int startDate)
        {
            throw new NotImplementedException();
        }
    }
}
