import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent implements OnInit {

  constructor() { }

 
  ngOnInit(): void {
  }
  proSelected = false;
  selProductName:string
  addedProduct:any;
  selectProduct(product)
  {
    this.proSelected=true;
    this.selProductName = product;
  }

  onAddedProduct(prodData)
  {
    this.addedProduct = prodData;
  }
}
