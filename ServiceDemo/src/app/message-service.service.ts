import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MessageServiceService {
  product =[{Name:"Nokia", ModelNo:"234234"},
  {Name:"vivo", ModelNo:"345345"},
  {Name:"samsung", ModelNo:"69789789"},
  {Name:"1+", ModelNo:"789789"},
  {Name:"Mi", ModelNo:"C7897893"}
]

  constructor() { }

  messageAlert()
  {
    alert("Thanks for subscribe !!!!!!!!");
  }
  
  
}
