﻿using System.ComponentModel.DataAnnotations;

namespace Vitalpilot.Domain.Models
{
    public partial class Appointment
    {
        public Guid UniqueId { get; private set; }
        public long FriendlyId { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Guid CreatedById { get; private set; }
        public string CreatedBy { get; private set; } = null!;
        public DateTime LastModifiedDate { get; private set; }
        public Guid LastModifiedById { get; private set; }
        public string LastModifiedBy { get; private set; } = null!;
        public bool Deleted { get; private set; }
        public byte[] RowVersion { get; private set; } = null!;
        public DateTime AppointmentDate { get; private set; }
        public Guid PatienceId { get; private set; }
        public Guid DoctorId { get; private set; }
        public string? PatienceHistory { get; private set; }
        public int Status { get; private set; }
        public Guid ClinicId { get; set; }

        public Patience Patience { get; private set; } = null!;
        public Doctor Doctor { get; private set; } = null!;
        public Clinic Clinic { get; private set; } = null!;
    }
}