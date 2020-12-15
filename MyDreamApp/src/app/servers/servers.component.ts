import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent implements OnInit {
  allowNewServers = false;
serverCreationStatus = "No server was created";
serverCreated = false;
serverName ='maz';
servers =['Testserver', 'Testserver2'];

  constructor() {

    setTimeout(() => {
      this.allowNewServers = true;
    }, 2000);
   }

  ngOnInit(): void {
 
    }
    onCreateServer(){
      this.servers.push(this.serverName);
      this.serverCreated = true;
      this.serverCreationStatus = "server was created! Name is" + this.serverName;
  }

  // event binding
  // OnUpdateServerName(event: Event){
  //  this.serverName = (<HTMLInputElement>event.target).value;
    
  //}

}
