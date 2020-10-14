import { Component } from '@angular/core';
import { AuthorizeService } from '../../api-authorization/authorize.service';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {

  user = null;
  isExpanded = false;
  constructor(public authorizeService: AuthorizeService) { }

  ngOnInit() {

    this.authorizeService.getUser()
      .subscribe(data => {
        console.log('authorizeService.getUser() nav bar');
        console.log(data); //You will get all your user related information in this field
        this.user = data;
      });
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
}
