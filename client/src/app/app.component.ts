import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Jay\'\s App';
  courses: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    //this.getCourses();
  }

  /*
  getCourses() {
    this.http.get('https://localhost:5001/api/courses').subscribe(response => {
      this.courses = response;
    }, error => {
      console.log(error);
    })
  }
  */
}
