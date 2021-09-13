using OnlineExaminationDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Exam Name")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Time { get; set; }
        public int GroupsId { get; set; }
        public List<ExamViewModel> ExamList { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<Groups> GroupList { get; set; }

        public ExamViewModel(Exams exam)
        {
            Id = exam.Id;
            Title = exam.Title ?? "";
            Description = exam.Description ?? "";
            StartDate = exam.StartDate;
            Time = exam.Time;
            GroupsId = exam.GroupsId;
        }

        public Exams ConvertViewModel(ExamViewModel examViewModel)
        {
            return new Exams
            {
                Id = examViewModel.Id,
                Title = examViewModel.Title ?? "",
                Description = examViewModel.Description ?? "",
                StartDate = examViewModel.StartDate,
                Time = examViewModel.Time,
                GroupsId = examViewModel.GroupsId
            };

        }
    }
}
