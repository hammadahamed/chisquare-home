import { Component, Input, OnInit, AfterViewInit } from '@angular/core';
import Chart from 'chart.js/auto';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.scss'],
})
export class ChartComponent implements OnInit, AfterViewInit {
  @Input()
  chartIndex!: number;
  @Input()
  payload!: any;

  constructor() {}

  ngOnInit(): void {}

  ngAfterViewInit(): void {
    console.log(this.payload);
    
    setTimeout(() => {
      this.createChart();
    }, 200);
  }

  public chart: any;

  private labels: string[] = [
    'JAN',
    'FEB',
    'MAR',
    'APR',
    'MAY',
    'JUN',
    'JUL',
    'AUG',
    'SEP',
    'OCT',
    'NOV',
    'DEC',
  ];


  formatNumber(number: number): string {
    if (number >= 1000000) {
      const millions = (number / 1000000).toFixed(2);
      return millions + 'M';
    } else {
      return number.toString();
    }
  }

  getDataValues(type: string): string[] {
    return Object.values(this.payload.Monthly).map((_value: any) =>
      this.formatNumber(_value[type])
    );
  }

  borderStyle = {
    // borderWidth: 2,
    borderRadius: 10,
    borderSkipped: false,
    // borderColor: 'rgb(255, 99, 132)',
  };

  createChart() {
    this.chart = new Chart(`MyChart${this.chartIndex}`, {
      type: 'bar', //this denotes tha type of chart
      options: {
        scales: {
          x: {
            ticks: {
              maxRotation: 0,
              minRotation: 0,
              autoSkip: false,
              font: {
                size: 8,
              },
            },
          },
          y: {
            ticks: {
              maxRotation: 0,
              minRotation: 0,
              autoSkip: false,
              font: {
                size: 10,
              },
            },
          },
        },
        aspectRatio: 1.5,
        responsive: true,
        plugins: {
          legend: {
            position: 'bottom',
            display: false,
            align: 'center',
          },
          title: {
            display: false,
          },
        },
      },
      data: {
        labels: this.labels,
        datasets: [
          {
            data: this.getDataValues('CY'),
            label: 'Sales',
            // data: [
            //   '467',
            //   '576',
            //   '572',
            //   '79',
            //   '92',
            //   '574',
            //   '573',
            //   '576',
            //   '574',
            //   '573',
            //   '576',
            //   '79',
            // ],
            backgroundColor: '#9272f8',
            ...this.borderStyle,
          },
          {
            label: 'Profit',
            data: this.getDataValues('PY'),

            // data: [
            //   '542',
            //   '542',
            //   '536',
            //   '327',
            //   '17',
            //   '0.00',
            //   '538',
            //   '541',
            //   '327',
            //   '17',
            //   '541',
            //   '541',
            // ],
            backgroundColor: '#e1d5ff',
            ...this.borderStyle,
          },
        ],
      },
    });
  }
}
