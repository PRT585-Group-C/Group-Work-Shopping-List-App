
import { Component, OnInit } from '@angular/core';
import { NewitemService } from '../newitem.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Newitem } from '../newitem';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {

  id: number;
  newitem: Newitem;

  constructor(
    public newitemservce: NewitemService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['newiemId'];
    console.log(this.id);
    this.newitemservce.find(this.id).subscribe((data: Newitem) => {
      console.log('find');
      console.log(data[0]);
      this.newitem = data[0];
    });
  }

}
