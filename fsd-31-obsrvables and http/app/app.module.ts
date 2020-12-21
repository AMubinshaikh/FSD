import { BrowserModule } from '@angular/platform-browser';
import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ProductsComponent } from './products/products.component';
import { ContactComponent } from './contact/contact.component';
import { AboutComponent } from './about/about.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { LaptopComponent } from './products/laptop/laptop.component';
import { MobileComponent } from './products/mobile/mobile.component';

const appRoutes:Routes=[

  //{path:'', redirectTo:'Login' pathMatch:'full},
   {path:'', component: HomeComponent},// empty path for default route
  {path:'products', children:[
    {path:'', component: ProductsComponent},
    {path:'laptop', component: LaptopComponent},
    {path:'mobile', component: MobileComponent}
  ]},
  {path:'about', component: AboutComponent},
  {path:'contact', component: ContactComponent},
  {path:'**', component: PagenotfoundComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ProductsComponent,
    ContactComponent,
    AboutComponent,
    PagenotfoundComponent,
    LaptopComponent,
    MobileComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    //add httpModule for http and observables
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
