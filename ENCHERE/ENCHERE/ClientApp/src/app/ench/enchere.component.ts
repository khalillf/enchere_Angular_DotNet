import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'enchere',
  templateUrl: './enchere.component.html',
})
export class EnchereComponent implements OnInit {
  data: any; // This will hold the fetched data

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.fetchDataFromServer();
  }

  fetchDataFromServer() {
    this.http.get('http://api/user').subscribe((response) => {
      this.data = response;
    });
  }
}
