﻿using Microsoft.AspNetCore.Mvc;
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

                    }
                }
            }
        }
    }
}
