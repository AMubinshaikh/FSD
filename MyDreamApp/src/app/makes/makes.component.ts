import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-makes',
  templateUrl: './makes.component.html',
  styleUrls: ['./makes.component.css']
})
///string interpolation example
export class MakesComponent implements OnInit {
  serverId =10;
  serverStatus ='offline';

  getServerStatus()
  {
    return this.serverStatus;
  }

  constructor() {
    this.serverStatus = Math.random()>0.5 ? 'online' : 'offline'
   
   }
   getColor(){
    this.serverStatus === 'online' ? 'green' : 'red';
  }

  ngOnInit(): void {
  }
 

}
