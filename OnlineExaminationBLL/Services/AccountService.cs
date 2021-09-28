using Microsoft.Extensions.Logging;
using OnlineExaminationDAL;
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
        ILogger<StudentService> _iLogger;

        public AccountService(IUnitOfWork unitOfWork, ILogger<StudentService> iLogger)
        {
            _unitOfWork = unitOfWork;
            _iLogger = iLogger;
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
                    model.UserList = detailList;
                    model.TotalCount = _unitOfWork.GenericRepository<Users>().GetAll().Count(x => x.Role == (int)Roles.Teacher);
                }
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            var results = new PagedResult<UserViewModel>
            {
                Data = model.UserList,
                TotalItems = model.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return results;
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
