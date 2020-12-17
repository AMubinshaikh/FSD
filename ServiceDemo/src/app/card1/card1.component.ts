import { MessageServiceService } from './../message-service.service';
import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'app-card1',
  templateUrl: './card1.component.html',
  styleUrls: ['./card1.component.css']
})
export class Card1Component implements OnInit {


  constructor( private msgService:MessageServiceService) { }
  product={};

  ngOnInit(): void {
    this.product = this.msgService.product;
    
  }
  btnClick()
  {
    this.msgService.messageAlert();
    
    
  //  const msgService = new MessageServiceService();
  //  msgService.messageAlert();
  }
}
