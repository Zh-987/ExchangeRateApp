import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { CurrencyComponent } from './currency/currency.component';
import { FormsModule } from '@angular/forms';
import { CurrencyService } from './currency.service';

@NgModule({
  declarations: [
    AppComponent,
    CurrencyComponent,
    
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule
  ],
  providers: [CurrencyService],
  bootstrap: [AppComponent]
})
export class AppModule { }
