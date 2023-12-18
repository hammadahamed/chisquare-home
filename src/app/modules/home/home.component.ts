import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  constructor() {}

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

  dataCharts = [{}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}, {}];

  ngOnInit(): void {}
}
