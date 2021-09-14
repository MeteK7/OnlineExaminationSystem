using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationBLL.Services
{
    public interface IAccountService
    {
        LoginViewModel Login(LoginViewModel loginViewModel);
        bool AddTeacher(UserViewModel userViewModel);
        PagedResult<UserViewModel> GetAllTeacher(int pageNumber, int pageSize);
    }
}
