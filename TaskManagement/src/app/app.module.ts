import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AuthenticationComponent } from './authentication/authentication.component';
import { AppContainerComponent } from './app-container/app-container.component';
import { ProjectComponent } from './app-container/project/project.component';
import { TaskComponent } from './app-container/task/task.component';
import { CollaboratorComponent } from './app-container/collaborator/collaborator.component';
import { TeamComponent } from './app-container/team/team.component';
import { NavbarComponent } from './navbar/navbar.component';
import {AccordionModule} from 'primeng/accordion';   
import { Menubar, MenubarModule } from 'primeng/menubar';
import {MegaMenuItem,MenuItem} from 'primeng/api';
import { HomeComponent } from './app-container/home/home.component';
import { RouterModule, Routes } from '@angular/router';
import { DeveloperTeamComponent } from './app-container/developer-team/developer-team.component';

@NgModule({
  declarations: [
    AppComponent,
    AuthenticationComponent,
    AppContainerComponent,
    ProjectComponent,
    TaskComponent,
    CollaboratorComponent,
    TeamComponent,
    NavbarComponent,
    HomeComponent,
    DeveloperTeamComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MenubarModule,
    RouterModule.forRoot([
      { path: 'Home', component: HomeComponent },
      { path: 'DeveloperTeam', component: DeveloperTeamComponent }
      ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
