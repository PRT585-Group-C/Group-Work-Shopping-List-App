import { Component, OnInit } from '@angular/core';
import { ItemListService } from '../item-list.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Item } from '../item';
@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {

  id: number;
  item: Item;

  constructor(
    public itemListService: ItemListService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['itemId'];

    this.itemListService.find(this.id).subscribe((data: Item) => {
      this.item = data;
    });
  }

}
