import { Component, OnInit } from '@angular/core';
import { NewitemService } from '../newitem.service';
import { Router } from '@angular/router';
import { FormGroup, FormControl, Validators} from '@angular/forms';

@Component({
  selector: 'app-create',
  templateUrl: './create.component.html',
  styleUrls: ['./create.component.css']
})
export class CreateComponent implements OnInit {
  form: FormGroup;
   

  constructor( public newitemService: NewitemService,
    private router: Router) { }

  ngOnInit(): void {
    this.form = new FormGroup({
      name: new FormControl('', [Validators.required]),
      barcode: new FormControl('', Validators.required),
      size: new FormControl(''),
      price: new FormControl('')
    });
  }
  get f(){
    return this.form.controls;
  }
    
  submit(){
    console.log(this.form.value);
    this.newitemService.create(this.form.value).subscribe(res => {
         console.log('Post created successfully!');
         this.router.navigateByUrl('newitem/index');
    })
  }

}
