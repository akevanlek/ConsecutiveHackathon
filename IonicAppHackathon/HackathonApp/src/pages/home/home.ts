import { GlobalVariable } from './../../app/models';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  NumberInput : string;
  NumberConsecutiveGroup : any;
  constructor(public navCtrl: NavController,public http: HttpClient) {

  }

  FindConsecutive() {
    this.http.get("http://localhost:5000/api/Values/76/")
    .subscribe((data : any) => {
        
      this.NumberConsecutiveGroup = data.display;
      alert(data);
      console.log(data);
    });
  }

}
