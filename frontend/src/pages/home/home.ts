import { PersonModel } from './../../models/PersonModel';
import { DataServiceProvider } from './../../providers/data-service/data-service';
import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  public persons: PersonModel[] = [];

  constructor(public navCtrl: NavController, private dataService: DataServiceProvider) {

  }

  onLoad() {
    this.dataService.getPersons().subscribe( r=> {
      console.log(r);
      this.persons = r;
    });
  }

}
