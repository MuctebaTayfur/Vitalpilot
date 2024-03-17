using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.Domain.Validations
{
    public class HospitalValidation : AbstractValidator<Hospital>
    {
        public HospitalValidation()
        {
        }
    }
}