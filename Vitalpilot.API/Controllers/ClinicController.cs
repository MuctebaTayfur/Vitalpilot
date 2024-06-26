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
    public class ClinicController(IService<Clinic, IRepository<Clinic>, BaseResponse<Clinic>> service, IRepository<Clinic> repository, IMapper mapper) : BaseEntityController<Clinic, ClinicDto, EntityFilter<Clinic>>(repository, service, mapper)
    {
    }
}