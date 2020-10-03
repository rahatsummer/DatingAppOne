import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
  model: any = {}; // Initiates an empty object

  @Output() canelRegister = new EventEmitter();

  constructor(private authService: AuthService) { }

  ngOnInit() {
  }

  register(){
    this.authService.register(this.model).subscribe(() =>{
      console.log('registration successful');
    }, error => {
      console.log(error);
    })
   // console.log(this.model);
  }

  cancel(){
    this.canelRegister.emit(false);
    console.log('cancelled');
  }

}
