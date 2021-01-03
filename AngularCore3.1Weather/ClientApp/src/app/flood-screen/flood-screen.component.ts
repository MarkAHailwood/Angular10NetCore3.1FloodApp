import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FormsModule, NgModel } from '@angular/forms';

@Component({
  selector: 'flood-screen',
  templateUrl: './flood-screen.component.html',
})

export class FloodScreenComponent {
  myText: string = '';
  Floods: FloodSummary[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<FloodSummary[]>(baseUrl + 'api/Flood').subscribe(result => {
      this.Floods = result;
    }, error => console.error(error));
  }

  clickFunction() {
    this.myText += "newText";
  }
}





interface FloodSummary {
  County: string,
  Description: string,
  Area: string,
  Message: string,
  SeverityLevel: number
}

