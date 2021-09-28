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

        public List<StudentViewModel> GroupListInfo(List<Students> modelList)
        {
            return modelList.Select(o => new StudentViewModel(o)).ToList();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            try
            {
                var students = _unitOfWork.GenericRepository<Students>().GetAll();
                return students;
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return Enumerable.Empty<Students>();
        }

        public IEnumerable<ResultViewModel> GetExamResults(int studentId)
        {
            try
            {
                var examResults = _unitOfWork.GenericRepository<ExamResults>().GetAll()
                    .Where(a => a.StudentsId == studentId);
                var students = _unitOfWork.GenericRepository<Students>().GetAll();
                var exams = _unitOfWork.GenericRepository<ExamResults>().GetAll();
                var qnAs = _unitOfWork.GenericRepository<QnAs>().GetAll();
                var requiredData = examResults.Join(students, er => er.StudentsId, s => s.Id,
                    (er, st) => new { er, st }).Join(exams, erj => erj.er.ExamsId, ex => ex.Id,
                    (erj, ex) => new { erj, ex }).Join(qnAs, exj => exj.erj.er.QnAsId, q => q.Id,
                    (exj, q) => new ResultViewModel()
                    {
                        StudentId=studentId,
                        ExamName=exj.ex.Title,
                        TotalQuestion=examResults.Count(a=>a.StudentsId==studentId && a.ExamsId==exj.ex.Id),
                        CorrectAnswer=examResults.Count(a=>a.StudentsId==studentId && a.ExamsId=exj.ex.Id && a.Answer==q.Answer),
                        WrongAnswer=examResults.Count(a=>a.StudentsId==studentId && a.ExamsId==exj.ex.Id && a.Answer!=q.Answer)
                    });

                return requiredData;
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }

            return Enumerable.Empty<ResultViewModel>();
        }

        public StudentViewModel GetStudentDetails(int studentId)
        {
            try
            {
                var student = _unitOfWork.GenericRepository<Students>().GetById(studentId);
                return student != null ? new StudentViewModel(student) : null;
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return null;
        }

        public bool SetExamResult(AttendExamViewModel attendExamViewModel)
        {
            try
            {
                foreach (var item in attendExamViewModel.QnAs)
                {
                    ExamResults examResults = new ExamResults();
                    examResults.StudentsId = attendExamViewModel.StudentId;
                    examResults.QnAsId = item.Id;
                    examResults.ExamsId = item.ExamsId;
                    examResults.Answer = item.SelectedAnswer;
                    _unitOfWork.GenericRepository<ExamResults>().AddAsync(examResults);
                }
                _unitOfWork.Save();
                return true;
            }

            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return false;
        }

        public bool SetGroupIdToStudents(GroupViewModel groupViewModel)
        {
            try
            {
                foreach (var item in groupViewModel.StudentCheckList)
                {
                    var student = _unitOfWork.GenericRepository<Students>().GetById(item.Id);
                    if (item.Selected)
                    {
                        student.GroupsId = groupViewModel.Id;
                        _unitOfWork.GenericRepository<Students>().Update(student);
                    }
                    else
                    {
                        if (student.GroupsId==groupViewModel.Id)
                        {
                            student.GroupsId = null;
                        }
                    }
                    _unitOfWork.Save();
                    return true;
                }
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return false;
        }

        public Task<StudentViewModel> UpdateAsync(StudentViewModel studentViewModel)
        {
            try
            {
                Students student = _unitOfWork.GenericRepository<Students>().GetById(studentViewModel.Id);
                student.Name = studentViewModel.Name;
                student.UserName = studentViewModel.UserName;
                student.PictureFileName = studentViewModel.PictureFileName != null ?
                    studentViewModel.PictureFileName : student.PictureFileName;
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
        }
    }
}
