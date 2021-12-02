import { Component, Injectable } from '@angular/core';
import { Command } from '../models/command.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { postCommand } from '../models/postCommand.model';

@Injectable({
  providedIn: 'root'
})
export class CommandService {

  _http : HttpClient;
  constructor(http : HttpClient) {this._http = http }
  
  getAllComponents():Observable<Array<Command>>{

    return this._http.get<Array<Command>>('http://localhost:29949/api/Blinker');
  }

  postComponent(command: postCommand): Observable<postCommand>{
    console.log("coaieeee ",command)
    return this._http.post<postCommand>('http://localhost:29949/api/Blinker',command,{
      headers: new HttpHeaders({
        'Content-Type':'application/json'
      })
    })
  }
}
