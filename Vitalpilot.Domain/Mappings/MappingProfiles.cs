using AutoMapper;
using Vitalpilot.Domain.Communication;
using Vitalpilot.Domain.Dtos;
using Vitalpilot.Domain.Models;

namespace Vitalpilot.Domain.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Appointment, AppointmentDto>()
                .ReverseMap();
            CreateMap<Clinic, ClinicDto>()
                .ReverseMap();
            CreateMap<Disease, DiseaseDto>()
                .ReverseMap();
            CreateMap<Doctor, DoctorDto>()
                .ReverseMap();
            CreateMap<Domain.Models.File, FileDto>()
                .ReverseMap();
            CreateMap<FileType, FileTypeDto>()
                .ReverseMap();
            CreateMap<Hospital, HospitalDto>()
                .ReverseMap();
            CreateMap<LabResult, LabResultDto>()
                .ReverseMap();
            CreateMap<NoteType, NoteTypeDto>()
                .ReverseMap();
            CreateMap<Patience, PatienceDto>()
                .ReverseMap();
            CreateMap<PatienceNote, PatienceNoteDto>()
                .ReverseMap();
            CreateMap<Prescription, PrescriptionDto>()
                .ReverseMap();
            CreateMap<Role, RoleDto>()
                .ReverseMap();
            CreateMap<Surgery, SurgeryDto>()
                .ReverseMap();
            CreateMap<User, UserDto>()
                .ReverseMap();
            CreateMap<UserRole, UserRoleDto>()
                .ReverseMap();

            CreateMap(typeof(BaseResponse<>), typeof(BaseResponseDto<>));
        }
    }
}