using OnlineExaminationDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }

        public int Id { get; set; }

        [Required]
        [Display(Name="Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public int Role { get; set; }
        public List<UserViewModel> UserList { get; set; }
        public int TotalCount { get; set; }

        public UserViewModel(Users user)
        {
            Id = user.Id;
            Name = user.Name ?? "";
            UserName = user.UserName;
            Password = user.Password;
            Role = user.Role;
        }

        public Users ConvertViewModel(UserViewModel userVM)
        {
            return new Users
            {
                Id = userVM.Id,
                Name = userVM.Name ?? "",
                UserName = userVM.UserName,
                Password = userVM.Password,
                Role = userVM.Role
            };
        }
    }
}
