import { Component, OnInit } from '@angular/core';
import { FormArray, FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive',
  templateUrl: './reactive.component.html',
  styleUrls: ['./reactive.component.css']
})
export class ReactiveComponent implements OnInit {
 
  myReactiveForm:FormGroup;

  genders=[
    {id:'1', value:'Male'},
    {id:'2', value:'Female'}
  ];
  defaultGender='Male'; 

  constructor() { }

  ngOnInit(): void {
    this.myReactiveForm = new FormGroup({
      'userDetail': new FormGroup({
        'username': new FormControl(null, Validators.required),
      'email': new FormControl(null,[Validators.required, Validators.email])
      }),
      
      'course': new FormControl('Angular'),
      'gender': new FormControl('Male'),
      'skills': new FormArray([
        new FormControl(null)
      ])
    });
  }
  onSubmit(){
     console.log(this.myReactiveForm);
  }
  onAddSkills()
  {
    const control = new FormControl(null, Validators.required);
    (<FormArray>this.myReactiveForm.get('skills')).push(control)
  }

}
