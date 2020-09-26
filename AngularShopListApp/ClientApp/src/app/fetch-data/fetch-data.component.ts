import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, Subject } from 'rxjs';

import {
  debounceTime, distinctUntilChanged, switchMap
} from 'rxjs/operators';

import { Newitem } from '../newitem/newitem';
import { NewitemService } from '../newitem/newitem.service';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  items: Newitem[];


  constructor(private itemService: NewitemService) { }

  
  ngOnInit() {
    this.itemService.getAll()
      .subscribe(s => this.items = s);
  }

}
