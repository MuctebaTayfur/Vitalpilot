import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { AppointmentService } from '../../services/appointment.service';
import { AppointmentDto } from 'src/app/shared/models/appointmentDto';



@Component({
  selector: 'app-appointment-list',
  templateUrl: './appointment-list.component.html',
  styleUrls: ['./appointment-list.component.scss']
})
export class AppointmentListComponent implements OnInit {

  entities$: AppointmentDto[];
  dataSource: MatTableDataSource<AppointmentDto>;
  displayedColumns: string[] = ['appointmentDate', 'doctor', 'clinic', 'hospital', 'status', 'actions'];

  constructor(protected appointmentService: AppointmentService) {
    this.dataSource = new MatTableDataSource([]);
  }

  ngOnInit() {
    this.appointmentService.getData().subscribe(data => {
      this.entities$ = data.data;
      this.dataSource.data = this.entities$;
      console.log(this.entities$);
    },
    error => {
      console.error('Error fetching data', error);
    });
  }
}
