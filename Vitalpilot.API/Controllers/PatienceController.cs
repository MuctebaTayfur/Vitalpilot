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
    public class PatienceController : BaseEntityController<Patience, PatienceDto, BaseEntityFilter<Patience>>
    {
        public PatienceController(IService<Patience, IRepository<Patience>, BaseResponse<Patience>> service, IRepository<Patience> repository, IMapper mapper) : base(repository, service, mapper)
        {
        }
    }
}