using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EmployeeProcessor
    {
        public static int CreateEmployee(int EmployeeId, string firstName, string lastName, 
            string email)
        {
            EmployeeModel data = new EmployeeModel
            {
                EmployeeID = EmployeeId,
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = email
            };
            string sql = @"insert into dbo.employees(EmployeeID, FirstName, LastName, EmailAddress)
                         values (@EmployeeID, @FirstName, @LastName, @EmailAddress);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"select EmployeeID, FirstName, LastName, EmailAddress 
                           from dbo.employees";

            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
    }
}
