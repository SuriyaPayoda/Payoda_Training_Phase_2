import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class CalculatorComponent {

  constructor(){}

  num1: number=0;
  num2: number=0;
  operator: string = 'add';
  result: number = 0;

  calculate() {
    switch (this.operator) {
      case 'add':
        this.result = this.num1 + this.num2;
        break;
      case 'subtract':
        this.result = this.num1 - this.num2;
        break;
      case 'multiply':
        this.result = this.num1 * this.num2;
        break;
      case 'divide':
        this.result = this.num1 / this.num2;
        break;
      default:
        this.result = 0;
    }
  }

}