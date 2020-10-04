using AuthSystem.DataAccess.DBModels;
using AuthSystem.DataAccess.Repository.Interface;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.DataAccess.Repository.Implementation
{
    public class AuthRepository : IAuthRepository
    {
        EmployeeDBContext _dbContext = new EmployeeDBContext();
        public bool AuthenticateUser(Models.Employee user)
        {
            bool IsUserAuthenticated = _dbContext.Employees
                .Any(u => u.Username.ToLower() == user
                .UserName.ToLower() && user
                .Password == user.Password);

            return IsUserAuthenticated;
        }
    }
}
