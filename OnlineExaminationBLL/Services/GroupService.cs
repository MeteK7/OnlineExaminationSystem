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
            throw new NotImplementedException();
        }

        public IEnumerable<Groups> GetAllGroups()
        {
            throw new NotImplementedException();
        }

        public GroupViewModel GetById(int groupId)
        {
            throw new NotImplementedException();
        }
    }
}
