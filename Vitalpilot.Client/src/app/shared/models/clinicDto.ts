export interface DoctorDto{
    readonly friendlyId?: number;
	readonly uniqueId?: string;
	firstName: string | null;
	middleName?: string | null;
	lastName: string;
	title: string | null;
}