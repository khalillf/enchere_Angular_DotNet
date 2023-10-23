import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-user',
  templateUrl: './users.component.html'
})
export class UserComponent implements OnInit {
  users: Users[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get<Users[]>('http://localhost:5157/api/users').subscribe((data) => {
      this.users = data;
      console.log(this.users);
    });
  }
}

export class Users {
  id?: number;
  username?: string;
  firstName?: string;
  lastName?: string;
  email?: string;
  password?: string;
  registrationDate?: Date;
}
