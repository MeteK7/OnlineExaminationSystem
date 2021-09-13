using OnlineExaminationDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class GroupViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Group Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        public int UsersId { get; set; }
        public List<GroupViewModel> GroupList { get; set; }
        public int TotalCount { get; set; }
        public GroupViewModel(Groups group)
        {
            Id = group.Id;
            Name = group.Name ?? "";
            Description = group.Description ?? "";
            UsersId = group.UsersId;
        }
        public Groups ConvertGroupsViewModel(GroupViewModel groupViewModel)
        {
            return new Groups
            {
                Id = groupViewModel.Id,
                Name = groupViewModel.Name ?? "",
                Description = groupViewModel.Description ?? "",
                UsersId = groupViewModel.UsersId
            };
        }
    }
}
