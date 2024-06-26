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
    public class AppointmentController(IService<Appointment, IRepository<Appointment>, BaseResponse<Appointment>> service, IRepository<Appointment> repository, IMapper mapper) : BaseEntityController<Appointment, AppointmentDto, EntityFilter<Appointment>>(repository, service, mapper)
    {
    }
}