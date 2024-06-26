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
    public class HospitalController(IService<Hospital, IRepository<Hospital>, BaseResponse<Hospital>> service, IRepository<Hospital> repository, IMapper mapper) : BaseEntityController<Hospital, HospitalDto, EntityFilter<Hospital>>(repository, service, mapper)
    {
    }
}