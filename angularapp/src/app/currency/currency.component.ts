import { Component } from '@angular/core';
import { CurrencyService } from '../currency.service';

@Component({
  selector: 'app-currency',
  templateUrl: './currency.component.html',
  styleUrls: ['./currency.component.css']
})
export class CurrencyComponent {
  selectedYear!: number;
  currencyData!: any[];

  constructor(private currencyService: CurrencyService) {}

  getCurrencyData(): void {
    this.currencyService.getCurrencyData(this.selectedYear)
      .subscribe(data => {
        this.currencyData = data;
      });
  }

  getObjectEntries(obj: any): any[] {
    return Object.entries(obj);
  }

  formatDate(dateString: string): string {
    const date = new Date(dateString);
    const year = date.getFullYear();
    const month = (date.getMonth() + 1).toString().padStart(2, '0');
    const day = date.getDate().toString().padStart(2, '0');

    return `${year}-${month}-${day}`;
  }
}
