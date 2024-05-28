import { Component, Input } from '@angular/core';
import { LeftNavLink } from '../models/leftNavLink';

@Component({
  selector: 'app-base-content-with-sidenav',
  templateUrl: './base-content-with-sidenav.component.html',
  styleUrls: ['./base-content-with-sidenav.component.scss']
})
export class BaseContentWithSidenavComponent {
  @Input() links!: Array<LeftNavLink>;
}
