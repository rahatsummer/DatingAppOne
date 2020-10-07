import { Component, OnInit } from '@angular/core';
import { AltertifyService } from '../_services/altertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  model: any = {};

  constructor(public authService: AuthService,
              private altertify: AltertifyService) { }

  ngOnInit() {
  }

  login(){
    this.authService.login(this.model).subscribe(next => {
      this.altertify.success('Logged in successfully');
    }, error => {
      this.altertify.error(error);
    });


  }

  loggedIn(){
    return this.authService.loggedIn();

  }

  logout(){
    localStorage.removeItem('token');
    this.altertify.message('logout successfully!');
  }

}
