import { Photo } from './photo';

export interface User {
  id: number;
  username: string;
  knownAs: string;
  age: number;
  gender: string;
  created: Date;
  lastActive: Date;
  photoUrl: string;
  city: string;
  country: string;
  interests?: string;   // Optional Property Comes after the requried property.
  introduction?: string;
  lookingFor?: string;
  photos?: Photo[];
}



