import { Component, OnInit } from '@angular/core';
import { ItemListService } from '../item-list.service';
import { Item } from '../item';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  items: Item[] = [];

  constructor(public itemListService: ItemListService) { }

  ngOnInit(): void {
    this.itemListService.getAll().subscribe((data: Item[]) => {
      this.items = data;
      console.log(this.items);
    })
  }

  deleteItem(Id) {
    console.log(Id);
    this.itemListService.delete(Id).subscribe(res => {
      this.items = this.items.filter(item => item.Id !== Id);
      console.log(this.items);
      console.log('Post deleted successfully!');
    })
  }

}
