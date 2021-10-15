﻿using Microsoft.AspNetCore.Mvc;
using OnlineExaminationBLL.Services;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationWeb.Controllers
{
    public class GroupsController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IStudentService _studentService;

        public GroupsController(IGroupService groupService, IStudentService studentService)
        {
            _groupService = groupService;
            _studentService = studentService;
        }

        public IActionResult Index(int pageNumber=1,int pageSize=10)
        {
            return View(_groupService.GetAllGroups(pageNumber,pageSize));
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(GroupViewModel groupViewModel)
        {
            if (ModelState.IsValid)
            {
                groupViewModel.UsersId = 1;
                await _groupService.AddGroupAsync(groupViewModel);
                return RedirectToAction(nameof(Index));
            }

            return View(groupViewModel);
        }

        public IActionResult Details(string groupId)
        {
            var model = _groupService.GetById(Convert.ToInt32(groupId));
            model.StudentCheckList = _studentService.GetAllStudents().Select(
                std => new StudentCheckBoxListViewModel()
                {
                    Id = std.Id,
                    Name = std.Name,
                    Selected = std.GroupsId==Convert.ToInt32(groupId)
                }).ToList();

            return View(model);
        }
    }
}
