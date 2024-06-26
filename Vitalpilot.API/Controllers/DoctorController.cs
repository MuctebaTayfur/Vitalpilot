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
    public class DoctorController(IService<Doctor, IRepository<Doctor>, BaseResponse<Doctor>> service, IRepository<Doctor> repository, IMapper mapper) : BaseEntityController<Doctor, DoctorDto, EntityFilter<Doctor>>(repository, service, mapper)
    {
    }
}