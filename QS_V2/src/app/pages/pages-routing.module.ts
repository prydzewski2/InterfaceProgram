import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PagesPage } from './pages.page';
import {HomePage} from "./home/home.page";
import { ConfigurationPage } from './configuration/configuration';

const routes: Routes = [
  {
    path: 'pages',
    component: PagesPage,
    children: [
      {
        path: 'home',
        component: HomePage
      },
      {
        path: 'configuration',
        component: ConfigurationPage
      },
      {
        path: '',
        redirectTo: '/pages/home',
        pathMatch: 'full'
      }
    ]
  },
  {
    path: '',
    redirectTo: '/pages/home',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
})
export class PagesPageRoutingModule {}
