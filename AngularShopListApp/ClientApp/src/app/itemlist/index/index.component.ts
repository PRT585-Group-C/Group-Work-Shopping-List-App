import { Component, OnInit } from '@angular/core';
import { ItemlistService } from '../itemlist.service';
import { Itemlist } from '../itemlist';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  itemlist: Itemlist[] = [];

  constructor(public itemlistService: ItemlistService) { }

  ngOnInit() {
    this.itemlistService.getAll().subscribe((data: Itemlist[]) => {
      this.itemlist = data;
      console.log(this.itemlist);
    })  
  }

}
