import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './modules/home/home.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { ChartComponent } from './common/chart/chart.component';

@NgModule({
  declarations: [AppComponent, HomeComponent, SidebarComponent, ChartComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
