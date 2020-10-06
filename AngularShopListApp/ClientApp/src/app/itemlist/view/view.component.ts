import { Component, OnInit } from '@angular/core';
import { ItemlistService } from '../itemlist.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Itemlist } from '../itemlist';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {

  id: number;
  itemlist: Itemlist;


  constructor(
    public itemlistService: ItemlistService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    console.log(this.id);
    this.itemlistService.find(this.id).subscribe((data: Itemlist) => {
      this.itemlist = data;
      console.log('item list');
      console.log(this.itemlist);
    });
  }

}
