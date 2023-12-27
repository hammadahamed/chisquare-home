import { Component, OnInit } from '@angular/core';
import { ChartsService } from '../../charts.service';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor(private chartsService: ChartsService) {}

  metrics = [
    {
      label: 'Total Branches',
      value: '12',
    },
    {
      label: 'Total Invoices',
      value: '6039',
    },
    {
      label: 'Unique Customers',
      value: '2049',
    },
  ];

  dataCharts:any = [];

  ngOnInit(): void {
    this.chartsService.getChartData('Revenue').subscribe(
      (data) => {
        console.log(data);
        
        this.dataCharts.push(...data);
      },
      (error) => {
        console.error(error);
      }
    );

    this.chartsService.getChartData('Stock Turnover Ratio').subscribe(
      (data) => {
        this.dataCharts.push(...data);
      },
      (error) => {
        console.error(error);
      }
    );

  }
}
