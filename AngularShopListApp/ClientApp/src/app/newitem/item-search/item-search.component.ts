import { Component, OnInit } from '@angular/core';

import { Observable, Subject } from 'rxjs';

import {
  debounceTime, distinctUntilChanged, switchMap
} from 'rxjs/operators';

import { Newitem } from '../newitem';
import { NewitemService } from '../newitem.service';


@Component({
  selector: 'app-item-search',
  templateUrl: './item-search.component.html',
  styleUrls: ['./item-search.component.css']
})
export class ItemSearchComponent implements OnInit {

  items$: Observable<Newitem[]>;
  private searchTerms = new Subject<string>();

  constructor(private itemService:NewitemService) { }

  // Push a search term into the observable stream.
  search(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.items$ = this.searchTerms.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(300),

      // ignore new term if same as previous term
      distinctUntilChanged(),

      // switch to new search observable each time the term changes
      switchMap((term: string) => this.itemService.searchItems(term)),
    );

    this.itemService.searchItems("sss").subscribe((data: Newitem[]) => {
      console.log('data');
      console.log(data);
    }) 
  }

}
