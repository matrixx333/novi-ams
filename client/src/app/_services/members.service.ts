import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, of } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Member } from '../_models/member';

@Injectable({
  providedIn: 'root',
})
export class MembersService {
  baseUrl = `${environment.apiUrl}/members`;
  members: Member[] = [];

  constructor(private http: HttpClient) {}

  getMembers() {
    if (this.members.length > 0) return of(this.members);
    return this.http.get<Member[]>(this.baseUrl).pipe(
      map((members) => {
        this.members = members;
        return members;
      })
    );
  }

  getMember(userGuid: string) {
    const member = this.members.find((m) => m.uniqueID === userGuid);
    if (member !== undefined) return of(member);
    return this.http.get<Member>(`${this.baseUrl}/${userGuid}`);
  } 
}
