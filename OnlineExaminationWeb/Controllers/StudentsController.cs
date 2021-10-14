using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols;
using OnlineExaminationBLL.Services;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationWeb.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IExamService _examService;
        private readonly IQuestionAnswerService _questionAnswerService;

        public StudentsController(IStudentService studentService, IExamService examService, IQuestionAnswerService questionAnswerService)
        {
            _studentService = studentService;
            _examService = examService;
            _questionAnswerService = questionAnswerService;
        }

        public IActionResult Index(int pageNumber,int pageSize=10)
        {
            return View(_studentService.GetAll(pageNumber,pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentViewModel studentViewModel)
        {
            if (ModelState.IsValid)
            {
                await _studentService.AddAsync(studentViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(studentViewModel);
        }

        public IActionResult AttendExam()
        {
            var attendExamVM = new AttendExamViewModel();
            LoginViewModel loginSession = HttpContext.Session.Get<LoginViewModel>("loginvm");
            if (loginSession!=null)
            {
                attendExamVM.StudentId = Convert.ToInt32(loginSession.Id);
                attendExamVM.QuestionAnswer = new List<QuestionAnswerViewModel>();
                var todayExam = _examService.GetAllExams().Where(a => a.StartDate.Date == DateTime.Today.Date).FirstOrDefault();
                if (todayExam==null)
                {
                    attendExamVM.Message = "No exam scheduled today.";
                }

                else
                {
                    if (!_questionAnswerService.IsExamAttended(todayExam.Id,attendExamVM.StudentId))
                    {
                        attendExamVM.QuestionAnswer = _questionAnswerService.GetAllQuestionAnswersByExamId(todayExam.Id).ToList();
                        attendExamVM.ExamName = todayExam.Title;
                        attendExamVM.Message = "";
                    }
                    else
                    {
                        attendExamVM.Message = "You have already attended to this exam.";
                    }
                }

                return View(attendExamVM);
            }

            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public IActionResult AttendExam(AttendExamViewModel attendExamViewModel)
        {
            bool result = _studentService.SetExamResult(attendExamViewModel);
            return RedirectToAction("AttendExam");
        }

        public IActionResult Result(string studentId)
        {
            var model = _studentService.GetExamResults(Convert.ToInt32(studentId));
            return View(model);
        }

        public IActionResult ViewResult()
        {
            LoginViewModel loginSession = HttpContext.Session.Get<LoginViewModel>("loginvm");

            if (loginSession!=null)
            {
                var model = _studentService.GetExamResults(Convert.ToInt32(loginSession));
                return View(model);
            }

            return RedirectToAction("Login", "Account");
        }

        public IActionResult Profile()
        {
            LoginViewModel loginSession = HttpContext.Session.Get<LoginViewModel>("loginvm");

            if (loginSession!=null)
            {
                var model = _studentService.GetStudentDetails(Convert.ToInt32(loginSession.Id));
                if (model.PictureFileName!=null)
                {
                    model.PictureFileName = ConfigurationManager.GetFilePath() + model.PictureFileName;
                }
                model.CVFileName = ConfigurationManager.GetFilePath() + model.CVFileName;
                return View(model);
            }
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Profile([FromForm]StudentViewModel studentViewModel)
        {
            if (studentViewModel.PictureFileName != null)
                studentViewModel.PictureFileName = SaveStudentFile(studentViewModel.PictureFile);

            if(studentViewModel.CVFile!=null)
                studentViewModel.PictureFileName= SaveStudentFile(studentViewModel.CVFile);

            _studentService.UpdateAsync(studentViewModel);

            return RedirectToAction("Profile");
        }

        private string SaveStudentFile(IFormFile pictureFile)
        {
            throw new NotImplementedException();
        }
    }
}
