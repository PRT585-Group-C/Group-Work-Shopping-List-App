import { Component, OnInit } from '@angular/core';
import { Newitem } from '../newitem';
import { NewitemService } from '../newitem.service';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  
  newitems: Newitem[] = [];
  

  constructor(public newitemService: NewitemService) { }

  ngOnInit(): void {
    this.newitemService.getAll().subscribe((data: Newitem[])=>{
      this.newitems = data;
      console.log(this.newitems);
    })  
  }

}
