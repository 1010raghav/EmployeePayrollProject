using EmployeeManager.Interface;
using EmployeeModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeNote.Controller
{
    [ApiController]
    [Route("api/[Empcontroller]")]
    public class EmpController:ControllerBase
    {
        private readonly IEmpManager Empmanager;

        public EmpController(IEmpManager Empmanager)
        {
            this.Empmanager = Empmanager;
        }


        [HttpGet]
        [Route("api/EmployeeDetails")]
        public IActionResult EmployeeDetails([FromBody] EmployeeDetails EmployeeDetails)
        {
            try
            {
                string message = this.Empmanager.EmployeeDetails(EmployeeDetails);
                if (message.Equals("Employee Details Added Successfully"))
                {
                    return this.Ok(new { Status = true, Message = message });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = message });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }


        [HttpDelete]
        [Route("deleteData")]
        public IActionResult Delete(string deleteData)
        {
            try
            {
                string message = this.Empmanager.Delete(deleteData);
                if (message.Equals("Data Deleted Successfully"))
                {
                    return this.Ok(new { Status = true, Message = message });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = message });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }


        [HttpPut]
        [Route("editData")]
        public IActionResult EditDetails(string FullName, string Gender, string Department, int Salary, int StartDate)
        {
            try
            {
                string message = this.Empmanager.Edit(FullName, Gender, Department,Salary, StartDate);
                if (message.Equals("Information Edited Successfully"))
                {
                    return this.Ok(new { Status = true, Message = message });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = message });
                }
            }
            catch (Exception ex)
            {
                return this.NotFound(new { Status = false, ex.Message });
            }
        }


    }
}
