import { Component } from '@angular/core';

@Component({
  selector: 'app-appointments',
  templateUrl: './appointments.component.html',
  styleUrls: ['./appointments.component.scss']
})
export class AppointmentsComponent {
  links = [
    {
      path: './list',
      icon: 'format_list_bulleted',
      title: 'Appointments',
      rightRequired: null
    },
    {
      path: './create',
      icon: 'add',
      title: 'New Appointment',
      rightRequired: null
    }
  ]
}
