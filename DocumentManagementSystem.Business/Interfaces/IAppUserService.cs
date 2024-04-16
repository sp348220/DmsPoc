using DocumentManagementSystem.Common;
using DocumentManagementSystem.Dtos;
using DocumentManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManagementSystem.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto);
        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
    }
}
/*
 Return Type: Task<IResponse<AppUserListDto>> is the return type of the method. 
 It indicates that the method returns a Task object that, when completed, will produce an IResponse<AppUserListDto> result. 
The Task<T> type represents an asynchronous operation that will produce a result of type T when completed.
 */
