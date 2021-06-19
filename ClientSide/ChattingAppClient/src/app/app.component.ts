import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

// import { Console } from 'console';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'ChattingAppClient';
  users:any;
  constructor(private http:HttpClient){}
  ngOnInit()
  {
       this.getUSers();
  }

  getUSers()
  {
    this.http.get('htpps://localhost:5001/api/Users').subscribe(response =>
      {
        this.users=response;
      },error =>
      {
        console.log(error);
      })
  }
}

