﻿using OnlineExaminationDAL;
using OnlineExaminationDAL.UnitOfWork;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationBLL.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork _unitOfWork;
        public AccountService()
        {

        }
        public bool AddTeacher(UserViewModel userViewModel)
        {
            throw new NotImplementedException();
        }

        public PagedResult<UserViewModel> GetAllTeachers(int pageNumber, int pageSize)
        {
            var model = new UserViewModel();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<UserViewModel> detailList = new List<UserViewModel>();
                var modelList = _unitOfWork.GenericRepository<Users>().GetAll().Where(x => x.Role == (int)Roles.Teacher).Skip(ExcludeRecords).Take(pageSize).ToList();
                detailList = ListInfo(modelList);
                if (detailList!=null)
                {
                    model.
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<UserViewModel> ListInfo(List<Users> modelList)
        {
            throw new NotImplementedException();
        }

        public LoginViewModel Login(LoginViewModel loginVM)
        {
            if (loginVM.Role==(int)Roles.Admin || loginVM.Role==(int)Roles.Teacher)
            {
                var user = _unitOfWork.GenericRepository<Users>().GetAll()
                    .FirstOrDefault(a => a.UserName == loginVM.UserName.Trim() 
                    && a.Password == loginVM.Password.Trim() 
                    && a.Role == loginVM.Role);

                if (user!=null)
                {
                    loginVM.Id = user.Id;
                    return loginVM;
                }
            }
            else
            {
                var student = _unitOfWork.GenericRepository<Students>().GetAll()
                    .FirstOrDefault(a => a.UserName == loginVM.UserName.Trim() && a.Password == loginVM.Password.Trim());
                if (student!=null)
                {
                    loginVM.Id = student.Id;
                }
                return loginVM;
            }
            return null;
        }
    }
}
