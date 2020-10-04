using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthSystem.ViewModels
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Username required.", AllowEmptyStrings = false)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password required.", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}