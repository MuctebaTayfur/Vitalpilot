import { DoctorDto } from "./doctorDto";

export interface AppointmentDto{
    readonly friendlyId?: number;
	readonly uniqueId?: string;
	readonly appointmentDate?: string | null;
	doctor?: DoctorDto;
    clinic?:any
}