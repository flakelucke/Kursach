import { Component, OnInit } from '@angular/core';
import { App } from '../models/user.model';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user-item',
  templateUrl: './user-item.component.html',
  styleUrls: ['./user-item.component.css']
})

export class UserItemComponent implements OnInit {

  user: App.User;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.user = new App.User();
    this.user.name = "tom";
    this.http
      .get('https://localhost:5001/api/persons/1')
      .subscribe((data: any) => {
        this.user.name = data.name;
      }
      )
  }
}
