import {Component, OnInit} from '@angular/core';
import {TabMenuModule} from 'primeng/tabmenu';
import {MenubarModule} from 'primeng/menubar';
import {MegaMenuItem,MenuItem} from 'primeng/api';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  items: MenuItem[];
  activeItem: MenuItem;
  constructor() { }

  ngOnInit(): void {
    this.items = [
      {
          label: 'Home',icon:'pi pi-home',routerLink: "Home"
      },
      {
          label: 'Projets',icon: 'pi pi-user',routerLink: "DeveloperTeam"
      },
      {
        label:'Accueil',icon:'pi pi-home',routerLink: "Home"
        
      }
  ];
  }

}
