import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  title = 'chisqaure-home';
  currentTheme: string = 'light';

  setTheme() {
    console.log('clicked');
    const themeToSet = this.currentTheme == 'dark' ? 'light' : 'dark';
    document.documentElement.setAttribute('data-theme', themeToSet);
    this.currentTheme = themeToSet;
  }
}
