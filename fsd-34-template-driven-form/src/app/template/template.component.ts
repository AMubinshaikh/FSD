import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})
export class TemplateComponent implements OnInit {
  @ViewChild('myForm') myForm:NgForm;
  defaultCourse='Angular';
  
  genders=[
    {id:'1', value:'Male'},
    {id:'2', value:'Female'}
  ];
  defaultGender='Male';
  submitted = false;
  formData = {
    username: '',
    email: '',
    course: '',
    gender: ''
  }

  constructor() { }

  ngOnInit(): void {
  }

  onSubmit(form:NgForm){
    console.log(this.myForm);
    this.submitted = true;
    this.formData.username = this.myForm.value.userDetail.username;
    this.formData.email = this.myForm.value.userDetail.email;
    this.formData.course = this.myForm.value.course;
    this.formData.gender = this.myForm.value.gender;

    this.myForm.reset();
  }
}
