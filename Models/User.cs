using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "User name không được bỏ trống!")]
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được bỏ trống!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email không được trống!")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được bỏ trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "số điện thoại không hợp lệ")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Nhớ tài khoản?")]
        public bool NhoTK { get; set; }
    }
}
