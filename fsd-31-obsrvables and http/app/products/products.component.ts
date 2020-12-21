import { DataService } from './../data.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  constructor(private dataService: DataService) { 
   
  }
  products={};
  

  ngOnInit(): void {
    this.dataService.product().subscribe(productData => this.products = productData);
  }

}
