
import { Component, Input, OnInit, Output } from '@angular/core';
import { EventEmitter } from 'events';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent implements OnInit {

  constructor() { }
  @Input() productSelected = false;
  @Input() selectedProductName:string;

  @Output() addedProduct:any = new EventEmitter;

  ngOnInit(): void {
  }

    
  //@Input() placeHolderText:string = "mubin";
 
  onAddProduct()
  {
    this.addedProduct.emit(this.selectedProductName);
  }


  


 

   
 

 

}
