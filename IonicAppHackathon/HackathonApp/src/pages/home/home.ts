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
    this.http.get("http://p-teerachai361566.codeanyapp.com:8000/api/values/GetStudent/" + this.NumberInput)
    .subscribe((data : any) => {
        
      this.NumberConsecutiveGroup = data.name;
      alert(data);
    });
  }

}
