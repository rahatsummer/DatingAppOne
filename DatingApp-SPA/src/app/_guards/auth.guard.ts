import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';
import { AltertifyService } from '../_services/altertify.service';
import { AuthService } from '../_services/auth.service';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private authService: AuthService,
              private router: Router,
              private alertify: AltertifyService){}
  canActivate():
     boolean  {
       if(this.authService.loggedIn()){
        return true;
       }
       this.alertify.error('you shall not pass!!!');
       this.router.navigate(['/home']);
       return false;
  };
}
