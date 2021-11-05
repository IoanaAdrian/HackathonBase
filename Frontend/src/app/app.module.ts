import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { SteluteComponent } from './stelute/stelute.component';


@NgModule({
  declarations: [
  
    SteluteComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap:[SteluteComponent]
})
export class AppModule { }
