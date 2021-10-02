﻿using Microsoft.Extensions.Logging;
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
    public class QuestionAnswerService : IQuestionAnswerService
    {
        IUnitOfWork _unitOfWork;
        ILogger<QuestionAnswerService> _iLogger;

        public QuestionAnswerService(IUnitOfWork unitOfWork, ILogger<QuestionAnswerService> iLogger)
        {
            _unitOfWork = unitOfWork;
            _iLogger = iLogger;
        }

        public async Task<QuestionAnswerViewModel> AddAsync(QuestionAnswerViewModel questionAnswerVM)
        {
            try
            {
                QuestionAnswers objQuestionAnswer = questionAnswerVM.ConvertViewModel(questionAnswerVM);
                await _unitOfWork.GenericRepository<QuestionAnswers>().AddAsync(objQuestionAnswer);
                _unitOfWork.Save();
            }
            catch (Exception)
            {
                return null;
            }
            return questionAnswerVM;
        }

        public PagedResult<QuestionAnswerViewModel> GetAll(int pageNumber, int pageSize)
        {
            var model = new QuestionAnswerViewModel();

            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<QuestionAnswerViewModel> detailList = new List<QuestionAnswerViewModel>();
                var modelList = _unitOfWork.GenericRepository<QuestionAnswers>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();
                var totalCount = _unitOfWork.GenericRepository<QuestionAnswers>().GetAll().ToList();
                detailList = ExamListInfo(modelList);
                if (detailList != null)
                {
                    model.QuestionAnswerList = detailList;
                    model.TotalCount = totalCount.Count();
                }
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
                throw;
            }

            var result = new PagedResult<QuestionAnswerViewModel>
            {
                Data = model.QuestionAnswerList,
                TotalItems = model.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        private List<QuestionAnswerViewModel> ExamListInfo(List<QuestionAnswers> modelList)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<QuestionAnswerViewModel> GetAllQuestionAnswers(int examId)
        {
            throw new NotImplementedException();
        }

        public bool IsExamAttended(int examId, int studentId)
        {
            throw new NotImplementedException();
        }
    }
}