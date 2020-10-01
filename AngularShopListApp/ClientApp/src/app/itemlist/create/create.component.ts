import { Component, OnInit } from '@angular/core';
import { ItemlistService } from '../itemlist.service';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {

  form: FormGroup;

  constructor(public itemlistService: ItemlistService,
    private router: Router) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      name: new FormControl('', [Validators.required])
    });
  }

  get f() {
    return this.form.controls;
  }


  submit() {
    console.log(this.form.value);
    this.itemlistService.create(this.form.value).subscribe(res => {
      console.log('Itemlist created successfully!');
      this.router.navigateByUrl('itemlist/index');
    })
  }

}
