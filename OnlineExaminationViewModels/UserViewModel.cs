﻿using OnlineExaminationDAL;
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
        public UserViewModel(Users user)
        {
            Id = user.Id;
            Name = user.Name ?? "";
            UserName = user.UserName;
            Password = user.Password;
            Role = user.Role;
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
    }
}
