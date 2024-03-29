import { Component } from '@angular/core';

@Component({
  selector: 'app-servers',
  templateUrl: './servers.component.html',
  styleUrls: ['./servers.component.css']
})
export class ServersComponent {
  serverId:number=1001;
  serverStatus:string='Offline';

  addNewServer :Boolean=false;
  serverCreated:string="Not yet";
  serverName:string='';
  serversList=['SQL','Oracle'];

  onServerNameEntry(event:Event){
    console.log(event);
    this.serverName=(<HTMLInputElement>event.target).value;
  }

  onServerCreation(){
    this.serverCreated="Created";
    this.serversList.push(this.serverName);
  }
  constructor()
{
  setTimeout(()=>{
  this.addNewServer=true;
},5000);
}

// onServerCreation(){
//   this.serverCreated="Created";
// }

  getServerId(){
    return this.serverId;
  }
  getServerStatus(){
    return this.serverStatus;
  }
}

