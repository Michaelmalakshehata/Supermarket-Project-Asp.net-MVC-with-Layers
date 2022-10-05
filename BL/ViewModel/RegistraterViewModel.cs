using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.ViewModel
{
    public class RegisterViewodel
    {
        [Required]
        public string UserName { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
    }
}
