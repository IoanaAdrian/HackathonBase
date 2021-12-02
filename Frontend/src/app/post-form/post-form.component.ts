import { CommandService } from './../services/command.service';
import { Component, OnInit } from '@angular/core';
import { postCommand } from '../models/postCommand.model';

@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent implements OnInit {
  _commandService:CommandService ;
  left_value :boolean=false;
  right_value :boolean=false;
  key :string="";
  constructor(service:CommandService) { this._commandService = service;}

  ngOnInit(): void {
   // document.body.classList.add("light-dark-theme", "mat-app-background");
  }
  addCommand(){
    console.log(this.left_value,this.right_value,this.key)
    this._commandService.postComponent(new postCommand(false,false,true,"pula")).subscribe( (data:postCommand)=>{
      console.log(data)
    })
  }

}
