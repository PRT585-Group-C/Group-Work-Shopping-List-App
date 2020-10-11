import { Component, OnInit } from '@angular/core';
import { ItemListService } from '../item-list.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Item } from '../item';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {


  id: number;
  item: Item;
  form: FormGroup;

  constructor(
    public itemListService: ItemListService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['itemId'];
    console.log(this.id)
    this.itemListService.find(this.id).subscribe((data: Item) => {
      this.item = data;
    });
    console.log(this.item)
    this.form = new FormGroup({
      Name: new FormControl('', [Validators.required]),
      Price: new FormControl('', Validators.required),
      Barcode: new FormControl('', Validators.required)
    });
  }

  get f() {
    return this.form.controls;
  }

  submit() {
    console.log(this.form.value);
    this.itemListService.update(this.id, this.form.value).subscribe(res => {
      console.log('Item updated successfully!');
      this.router.navigateByUrl('item_list/index');
    })
  }

}
