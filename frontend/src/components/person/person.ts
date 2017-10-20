import { PersonModel } from './../../models/PersonModel';
import { Component, Input } from '@angular/core';
import { Gender } from '../../models/Gender';

/**
 * Generated class for the PersonComponent component.
 *
 * See https://angular.io/api/core/Component for more info on Angular
 * Components.
 */
@Component({
  selector: 'person',
  templateUrl: 'person.html'
})
export class PersonComponent {

  @Input()
  person: PersonModel;

  constructor() {
  }

  getGenderIcon(): string {
    return this.person.gender === Gender.Male ? 'male' : 'female';
  }
}
