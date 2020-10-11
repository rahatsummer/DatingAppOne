
import {Injectable} from '@angular/core';
import { User } from '../_models/user';
import {Resolve, Router, ActivatedRouteSnapshot} from '@angular/router';
import { UserService } from '../_services/user.service';
import { AltertifyService } from '../_services/altertify.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';



@Injectable()
export class MemberDetailResolver implements Resolve<User>{
  constructor(private userService: UserService, private alertify: AltertifyService,
              private route: Router){}

  resolve(route: ActivatedRouteSnapshot) : Observable<User>{
    return this.userService.getUser(route.params['id']).pipe(
      catchError( error => {
        this.alertify.error('Problem retrieving data');
        this.route.navigate(['/members']);
        return of(null);
      })
    );
  }

}