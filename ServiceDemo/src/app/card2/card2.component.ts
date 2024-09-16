import { Component, OnInit } from '@angular/core';
import { MessageServiceService } from '../message-service.service';

@Component({
  selector: 'app-card2',
  templateUrl: './card2.component.html',
  styleUrls: ['./card2.component.css']
})
export class Card2Component implements OnInit {
  

  constructor( private msgService:MessageServiceService) { }
  product={};

  ngOnInit(): void {
    this.product = this.msgService.product;
    // this.Name.Name = this.msgService.Name.Name;
    // this.Name.ModelNo =  this.msgService.Name.ModelNo;
  }
  btnClick()
  {
    this.msgService.messageAlert();
  //  const msgService = new MessageServiceService();
  //  msgService.messageAlert();
  }
}
