import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  nameSearch: string = '';
  products = [
    {
      sno: 1,
      name: 'Laptop',
      price: '7000',
      availability: 'Available'
    },
    {
      sno: 2,
      name: 'Mobile',
      price: '8000',
      availability: 'Not Available'
    },
    {
      sno: 3,
      name: 'Television',
      price: '10000',
      availability: 'available'
    }
  ]

}
