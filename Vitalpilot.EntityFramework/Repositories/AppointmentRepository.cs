using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Models;
using Vitalpilot.EntityFramework.Context;

namespace Vitalpilot.EntityFramework.Repositories
{
    public class AppointmentRepository(VitalpilotDbContext vitalpilotDbContext) : Repository<Appointment>(vitalpilotDbContext)
    {
    }
}