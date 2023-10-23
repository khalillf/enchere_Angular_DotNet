import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
})
export class LoginComponent {
  username: string = '';
  password: string = '';
  errorMessage: string = ''; 

  constructor(private http: HttpClient, private router: Router) { }

  login() {
    const credentials = {
      username: this.username,
      password: this.password,
    };
    console.log(credentials);
    this.http.post('http://localhost:5157/api/login', credentials)
      .subscribe(
        (response: any) => {
          console.log("Login successful");
          this.router.navigate(['/enchere']);
        },
        (error) => {
          console.log("Login failed");
          this.errorMessage = 'Username or password is not correct.';
        }
      );

  }
}
