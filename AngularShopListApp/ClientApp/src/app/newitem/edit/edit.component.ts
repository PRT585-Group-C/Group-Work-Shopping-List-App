import { Component, OnInit } from '@angular/core';
import { NewitemService } from '../newitem.service';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl, Validators,FormBuilder } from '@angular/forms';
import { Newitem } from '../newitem';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {
  form: FormGroup;

  id: number;
  newitem: Newitem;
  name = '';
  barcode = '';
  size = '';
  price = '';

  constructor(public newitemService: NewitemService,
    private route: ActivatedRoute,
    private router: Router, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params['newiemId'];
    this.getCasesById(this.id);

    this.form = this.formBuilder.group({
      name: [null, Validators.required],
      barcode: [null],
      size: [null],
      price: [null]
    });
  }
  getCasesById(id: any) {
    this.newitemService.find(this.id).subscribe((data: any) => {
      //this.id = data[0].id;
      this.form.setValue({
        name: data[0].name,
        barcode: data[0].barcode,
        size: data[0].size,
        price: data[0].price
      });
    });
  }
    get f(){
      return this.form.controls;
    }

  submit() {
    this.form.value['id'] = Number(this.id);
      console.log(this.form.value);
      this.newitemService.update(this.id, this.form.value).subscribe(res => {
        console.log('new item updated successfully!');
        this.router.navigateByUrl('newitem/index');
      })
  }
}
