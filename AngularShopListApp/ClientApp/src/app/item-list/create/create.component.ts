import { Component, OnInit } from '@angular/core';
import { ItemListService } from '../item-list.service';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  form: FormGroup;

  constructor(
    public itemListService: ItemListService,
    private router: Router
  ) { }

  ngOnInit(): void {
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
    this.itemListService.create(this.form.value).subscribe(res => {
      console.log('Item created successfully!');
      this.router.navigateByUrl('item-list/index');
    })
  }
}
