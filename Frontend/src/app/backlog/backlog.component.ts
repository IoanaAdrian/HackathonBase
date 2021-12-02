import { Component, OnInit } from '@angular/core';
import { Command } from '../models/command.model';
import { CommandService } from '../services/command.service';

@Component({
  selector: 'app-backlog',
  templateUrl: './backlog.component.html',
  styleUrls: ['./backlog.component.css']
})
export class BacklogComponent implements OnInit {
  _commandService: CommandService;
  commandList : Array<Command> = new Array<Command>();
  displayedColumns: string[] = ['id', 'valid', 'left_value', 'right_value'];
  constructor(commandService: CommandService) { this._commandService = commandService; }

  ngOnInit(): void {
    
      this._commandService.getAllComponents().subscribe(data=>{
        this.commandList = data;
        console.log(data)
      });

  }
  
}
