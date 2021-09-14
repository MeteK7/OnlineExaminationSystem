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

        public PagedResult<UserViewModel> GetAllTeacher(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public LoginViewModel Login(LoginViewModel loginViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
