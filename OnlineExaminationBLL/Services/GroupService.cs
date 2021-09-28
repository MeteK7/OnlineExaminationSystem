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
    public class GroupService : IGroupService
    {
        IUnitOfWork _unitOfWork;
        ILogger<GroupService> _iLogger;

        public GroupService(IUnitOfWork unitOfWork, ILogger<GroupService> iLogger)
        {
            _unitOfWork = unitOfWork;
            _iLogger = iLogger;
        }

        public async Task<GroupViewModel> AddGroupAsync(GroupViewModel groupVM)
        {
            try
            {
                Groups objGroup = groupVM.ConvertGroupsViewModel(groupVM);
                await _unitOfWork.GenericRepository<Groups>().AddAsync(objGroup);
                _unitOfWork.Save();
            }
            catch (Exception)
            {
                return null;
            }
            return groupVM;
        }

        public PagedResult<GroupViewModel> GetAllGroups(int pageNumber, int pageSize)
        {
            var model = new GroupViewModel();

            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<GroupViewModel> detailList = new List<GroupViewModel>();
                var modelList = _unitOfWork.GenericRepository<Groups>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();
                var totalCount = _unitOfWork.GenericRepository<Groups>().GetAll().ToList();
                detailList = GroupListInfo(modelList);
                if (detailList!=null)
                {
                    model.GroupList = detailList;
                    model.TotalCount = totalCount.Count();
                }
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
                throw;
            }

            var result = new PagedResult<GroupViewModel>
            {
                Data = model.GroupList,
                TotalItems = model.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return result;
        }

        private List<GroupViewModel> GroupListInfo(List<Groups> modelList)
        {
            return modelList.Select(o => new GroupViewModel(o)).ToList();
        }

        public IEnumerable<Groups> GetAllGroups()
        {
            try
            {
                var groups = _unitOfWork.GenericRepository<Groups>().GetAll();
                return groups;
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return Enumerable.Empty<Groups>();
        }

        public GroupViewModel GetById(int groupId)
        {
            try
            {
                var group = _unitOfWork.GenericRepository<Groups>().GetById(groupId);
                return new GroupViewModel(group);
            }
            catch (Exception ex)
            {
                _iLogger.LogError(ex.Message);
            }
            return null;
        }
    }
}
