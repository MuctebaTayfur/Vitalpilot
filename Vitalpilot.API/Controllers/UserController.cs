using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vitalpilot.Domain.Communication;
using Vitalpilot.Domain.Dtos;
using Vitalpilot.Domain.Filters;
using Vitalpilot.Domain.Models;
using Vitalpilot.Domain.Repositories;
using Vitalpilot.Domain.Services;

namespace Vitalpilot.API.Controllers
{
    public class UserController(IService<User, IRepository<User>, BaseResponse<User>> service, IRepository<User> repository, IMapper mapper) : BaseEntityController<User, UserDto, EntityFilter<User>>(repository, service, mapper)
    {
    }
}