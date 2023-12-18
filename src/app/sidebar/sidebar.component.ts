import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss'],
})
export class SidebarComponent implements OnInit {
  constructor() {}

  collapsed: boolean = false;

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
