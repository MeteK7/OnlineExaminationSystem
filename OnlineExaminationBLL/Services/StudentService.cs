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
    public class StudentService : IStudentService
    {
        IUnitOfWork _unitOfWork;
        ILogger<StudentService> _iLogger;

        public StudentService(IUnitOfWork unitOfWork, ILogger<StudentService> iLogger)
        {
            _unitOfWork = unitOfWork;
            _iLogger = iLogger;
        }

        public async Task<StudentViewModel> AddAsync(StudentViewModel studentVM)
        {
            try
            {
                Students students = studentVM.ConvertViewModel(studentVM);
                await _unitOfWork.GenericRepository<Students>().AddAsync(students);
            }
            catch (Exception)
            {
                return null;
            }

            return studentVM;
        }

        public PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize)
        {
            var studentVM = new StudentViewModel();

            try
            {
                int excludeRecords = (pageSize * pageNumber) - pageSize;
                List<StudentViewModel> detailList = new List<StudentViewModel>();
                var modelList = _unitOfWork.GenericRepository<Students>().GetAll()
                    .Skip(excludeRecords).Take(pageSize).ToList();
                var totalCount = _unitOfWork.GenericRepository<Students>().GetAll().ToList();
                detailList = GroupListInfo(modelList);
                if (detailList!=null)
                {
                    studentVM.StudentList = detailList;
                    studentVM.TotalCount = totalCount.Count();
                }
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }

            var result = new PagedResult<StudentViewModel>
            {
                Data = studentVM.StudentList,
                TotalItems = studentVM.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };

            return result;
        }

        public IEnumerable<Students> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ResultViewModel> GetExamResults(int studentId)
        {
            throw new NotImplementedException();
        }

        public StudentViewModel GetStudentDetails(int studentId)
        {
            throw new NotImplementedException();
        }

        public bool SetExamResult(AttendExamViewModel attendExamViewModel)
        {
            throw new NotImplementedException();
        }

        public bool SetGroupIdToStudents(GroupViewModel groupViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<StudentViewModel> UpdateAsync(StudentViewModel studentViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
