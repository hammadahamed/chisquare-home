import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  title = 'chisqaure-home';
  currentTheme: string = 'dark';

  ngOnInit(): void {
    document.documentElement.setAttribute('data-theme', 'dark');
  }
  setTheme() {
    const themeToSet = this.currentTheme === 'dark' ? 'light' : 'dark';
    document.documentElement.setAttribute('data-theme', themeToSet);
    this.currentTheme = themeToSet;
  }
}
