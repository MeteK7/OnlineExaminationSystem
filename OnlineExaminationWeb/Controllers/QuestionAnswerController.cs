using Microsoft.AspNetCore.Mvc;
using OnlineExaminationBLL.Services;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationWeb.Controllers
{
    public class QuestionAnswerController : Controller
    {
        private readonly IExamService _examService;
        private readonly IQuestionAnswerService _questionAnswerService;

        public QuestionAnswerController(IExamService examService, IQuestionAnswerService questionAnswerService)
        {
            _examService = examService;
            _questionAnswerService = questionAnswerService;
        }

        public IActionResult Index(int pageNumber=1,int pageSize=10)
        {
            return View(_questionAnswerService.GetAll(pageNumber,pageSize));
        }

        public IActionResult Create()
        {
            var model = new QuestionAnswerViewModel();
            model.ExamList = _examService.GetAllExams();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(QuestionAnswerViewModel questionAnswerViewModel)
        {
            if (ModelState.IsValid)
            {
                await _questionAnswerService.AddAsync(questionAnswerViewModel);
                return RedirectToAction(nameof(Index));
            }

            return View(questionAnswerViewModel);
        }
    }
}
