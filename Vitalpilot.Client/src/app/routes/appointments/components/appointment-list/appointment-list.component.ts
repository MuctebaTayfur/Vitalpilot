import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { AppointmentService } from '../../services/appointment.service';
import { AppointmentDto } from 'src/app/shared/models/appointmentDto';



@Component({
  selector: 'app-appointment-list',
  templateUrl: './appointment-list.component.html',
  styleUrls: ['./appointment-list.component.scss']
})
export class AppointmentListComponent {

  entities$: AppointmentDto[];

  dataSource: MatTableDataSource<AppointmentDto>;
  displayedColumns: string[] = ['appointmentDate', 'doctor', 'clinic', 'hospital', 'status', 'actions'];

  constructor(protected appointmentService: AppointmentService) {

    this.dataSource = new MatTableDataSource(this.entities$);
  }
  ngOnInit() {
    this.appointmentService.getData().subscribe(data => {
      this.entities$ = data;
    });

    console.log(this.entities$)
  }
}
