import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
})
export class SidebarComponent implements OnInit {
  constructor() {}

  sideMenus: string[] = [
    'Overview',
    'KPY Evaluation',
    'Bench Performance',
    'Sales',
  ];

  collapsed: boolean = false;

  currentMenu: string = this.sideMenus[0];

  toggleSidebar() {
    this.collapsed = !this.collapsed;
    [
      document.getElementById('app-left'),
      document.getElementById('app-right'),
    ].forEach((_element) => {
      _element?.classList.toggle('collapsed');
    });
  }
  ngOnInit(): void {}
}
