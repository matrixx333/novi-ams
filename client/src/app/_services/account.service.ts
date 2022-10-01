import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ReplaySubject } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  baseUrl = `${environment.apiUrl}/account`;
  private currentUserSource = new ReplaySubject<User>(1);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient) { }

  login(model: any) {
    return this.http.post(`${this.baseUrl}/login`, model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {          
          this.setCurrentUser(user);
        }
      })
    )
  }

  register(model: any) {
    return this.http.post(`${this.baseUrl}/register`, model).pipe(
      map((response: User) => {
        const user = response;
        if (user) {          
          this.setCurrentUser(user);
        }
      })
    )
  }

  setCurrentUser(user: User) {
    localStorage.setItem('user', JSON.stringify(user));
    this.currentUserSource.next(user);
  }

  logout() {
    localStorage.removeItem('user');
    this.currentUserSource.next(null);
  }
}