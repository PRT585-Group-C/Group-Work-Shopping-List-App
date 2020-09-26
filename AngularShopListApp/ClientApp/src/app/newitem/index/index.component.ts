import { Component, OnInit } from '@angular/core';
import { Newitem } from '../newitem';
import { NewitemService } from '../newitem.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {
  
  newitems: Newitem[] = [];
  

  constructor(public newitemService: NewitemService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.newitemService.getAll().subscribe((data: Newitem[])=>{
      this.newitems = data;
      console.log(this.newitems);
    })  
  }
  deletePost(id) {
    this.newitemService.delete(id).subscribe(res => {
      this.newitems = this.newitems.filter(item => item.id !== id);
      console.log('New item deleted successfully!');
    })
  }

}
