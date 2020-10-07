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

    this.itemlistService.getAllItems().subscribe((data: Itemlist[]) => {
      this.data = data;
      console.log('getAllItems');
      console.log(this.data);
    });
  }

  keyword = 'name';
  data = [
    {
      id: 1,
      name: 'Usa'
    },
    {
      id: 2,
      name: 'England'
    }
  ];


  selectEvent(item) {
    // do something with selected item
    console.log('selectEvent');
    console.log(item);
    var object = {};
    object["ItemsListId"] = this.id;
    object["ItemId"] = item.id;
    console.log('object');
    console.log(object);
    this.itemlistService.createItemListItem(object).subscribe(res => {
      console.log('Item list item created successfully!');
      //this.router.navigateByUrl('itemlist/index');
      this.itemlistService.find(this.id).subscribe((data: Itemlist) => {
        this.itemlist = data;
        console.log('re fech item list');
        console.log(this.itemlist);
      });
    })

  }

  onChangeSearch(val: string) {
    // fetch remote data from here
    // And reassign the 'data' which is binded to 'data' property.
  }

  onFocused(e) {
    // do something when input is focused
  }

}
