import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AltertifyService } from '../_services/altertify.service';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  model: any = {}; // Initiates an empty object

  @Output() canelRegister = new EventEmitter();

  constructor(private authService: AuthService,
              private alertify: AltertifyService) { }

  ngOnInit() {
  }

  register(){
    this.authService.register(this.model).subscribe(() => {
      this.alertify.success('registration successful');
    }, error => {
      this.alertify.error(error);
    });
   // console.log(this.model);
  }

  cancel(){
    this.canelRegister.emit(false);
  }

}
