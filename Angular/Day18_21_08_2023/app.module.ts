import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { TemperatureConverterComponent } from './temperature/temperature.component';
import { MortgageCalculatorComponent } from './mortgage-calculator/mortgage-calculator.component';

@NgModule({
  declarations: [
    AppComponent,
    TemperatureConverterComponent,
    MortgageCalculatorComponent
    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
