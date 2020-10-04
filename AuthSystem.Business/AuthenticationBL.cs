using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using AuthSystem.DataAccess.Repository.Implementation;

namespace AuthSystem.Business
{
    public class AuthenticationBL
    {
        AuthRepository authRepository = new AuthRepository();
        public bool AuthenticateUser(Employee user)
        {
            return authRepository.AuthenticateUser(user);
        }
    }
}
