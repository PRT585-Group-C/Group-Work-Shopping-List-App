import { Component, OnInit } from '@angular/core';
import { ItemlistService } from '../itemlist.service';

import { AuthorizeService } from '../../../api-authorization/authorize.service';
import { Itemlist } from '../itemlist';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  itemlist: Itemlist[] = [];

  constructor(public itemlistService: ItemlistService, public authorizeService: AuthorizeService ) { }

  ngOnInit() {

    this.authorizeService.getUser()
      .subscribe(data => {
        console.log(data); //You will get all your user related information in this field
      });

    this.itemlistService.getAll().subscribe((data: Itemlist[]) => {
      this.itemlist = data;
      console.log(this.itemlist);
    })  
  }

}
