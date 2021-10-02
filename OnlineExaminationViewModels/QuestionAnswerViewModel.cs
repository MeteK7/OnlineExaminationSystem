using OnlineExaminationDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationViewModels
{
    public class QuestionAnswerViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Exam")]
        public int ExamsId { get; set; }
        [Required]
        [Display(Name = "Question")]
        public string Question { get; set; }
        [Required]
        [Display(Name = "Answer")]
        public int Answer { get; set; }

        [Required]
        [Display(Name = "Option 1")]
        public string Option1 { get; set; }

        [Required]
        [Display(Name = "Option 2")]
        public string Option2 { get; set; }

        [Required]
        [Display(Name = "Option 3")]
        public string Option3 { get; set; }

        [Required]
        [Display(Name = "Option 4")]
        public string Option4 { get; set; }

        public List<QuestionAnswerViewModel> QnAsList { get; set; }
        public IEnumerable<Exams> ExamList { get; set; }
        public int TotalCount { get; set; }
        public int SelectedAnswer { get; set; }

        public QuestionAnswerViewModel(QnAs qnAs)
        {
            Id = qnAs.Id;
            ExamsId = qnAs.ExamsId;
            Question = qnAs.Question ?? "";
            Option1 = qnAs.Option1 ?? "";
            Option2 = qnAs.Option2 ?? "";
            Option3 = qnAs.Option3 ?? "";
            Option4 = qnAs.Option4 ?? "";
            Answer = qnAs.Answer;
        }

        public QnAs ConvertViewModel(QuestionAnswerViewModel qnAsViewModel)
        {
            return new QnAs
            {
                Id = qnAsViewModel.Id,
                ExamsId = qnAsViewModel.ExamsId,
                Question = qnAsViewModel.Question ?? "",
                Option1 = qnAsViewModel.Option1 ?? "",
                Option2 = qnAsViewModel.Option2 ?? "",
                Option3 = qnAsViewModel.Option3 ?? "",
                Option4 = qnAsViewModel.Option4 ?? "",
                Answer = qnAsViewModel.Answer
            };
        }
    }
}
