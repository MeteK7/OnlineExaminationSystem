using Microsoft.AspNetCore.Http;
using OnlineExaminationDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Contact No")]
        public string Contact { get; set; }

        [Display(Name = "CV")]
        public string CVFileName { get; set; }

        public string PictureFileName { get; set; }

        public int? GroupsId { get; set; }

        public IFormFile PictureFile { get; set; }

        public IFormFile CVFile { get; set; }

        public int TotalCount { get; set; }

        public List<StudentViewModel> StudentList { get; set; }

        public StudentViewModel(Students student)
        {
            Id = student.Id;
            Name = student.Name ?? "";
            UserName = student.UserName;
            Password = student.Password;
            Contact = student.Contact ?? "";
            CVFileName = student.CVFileName ?? "";
            PictureFileName = student.PictureFileName ?? "";
            GroupsId = student.GroupsId;
        }

        public Students ConvertViewModel(StudentViewModel studentVM)
        {
            return new Students
            {
                Id = studentVM.Id,
                Name = studentVM.Name ?? "",
                UserName = studentVM.UserName,
                Password = studentVM.Password,
                Contact = studentVM.Contact ?? "",
                CVFileName = studentVM.CVFileName ?? "",
                PictureFileName = studentVM.PictureFileName ?? "",
                GroupsId = studentVM.GroupsId
            };
        }
    }
}
