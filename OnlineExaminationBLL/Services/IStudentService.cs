using OnlineExaminationDAL;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationBLL.Services
{
    public interface IStudentService
    {
        PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize);
        Task<StudentViewModel> AddAsync(StudentViewModel studentViewModel);
        IEnumerable<Students> GetAllStudents();
        bool SetGroupIdToStudents(GroupViewModel groupViewModel);
        bool SetExamResult(AttendExamViewModel attendExamViewModel);
        IEnumerable<ResultViewModel> GetExamResults(int studentId);
        StudentViewModel GetStudentDetails(int studentId);
        Task<StudentViewModel> UpdateAsync(StudentViewModel studentViewModel);
    }
}
