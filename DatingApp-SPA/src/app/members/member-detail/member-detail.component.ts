import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { User } from 'src/app/_models/user';
import { AltertifyService } from 'src/app/_services/altertify.service';
import { UserService } from 'src/app/_services/user.service';
import {NgxGalleryOptions} from '@kolkov/ngx-gallery';
import {NgxGalleryImage} from '@kolkov/ngx-gallery';
import {NgxGalleryAnimation} from '@kolkov/ngx-gallery';

@Component({
  selector: 'app-member-detail',
  templateUrl: './member-detail.component.html',
  styleUrls: ['./member-detail.component.scss']
})
export class MemberDetailComponent implements OnInit {
  user: User;
  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

  constructor(private userService: UserService,
              private alertify: AltertifyService,
              private route: ActivatedRoute) { }


  ngOnInit() {
   this.route.data.subscribe(data => {
     this.user = data['user'];
   });
   this.galleryOptions = [
     {
       width: '500px',
       height: '500px',
       imagePercent: 100,
       thumbnailsColumns: 4,
       imageAnimation: NgxGalleryAnimation.Slide,
       preview: false

     }
   ];
   this.galleryImages = this.getImages();
  }

  getImages(){
    const imageUrls = [];
    // tslint:disable-next-line: prefer-for-of
    for (let i = 0; i < this.user.photos.length; i++) {
      imageUrls.push({
        small: this.user.photos[i].url,
        medium: this.user.photos[i].url,
        big: this.user.photos[i].url,
        description: this.user.photos[i].description
      });
    }
    return imageUrls;
  }
}
