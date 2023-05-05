import {Inject, Injectable} from "@angular/core";
import {HttpClient, HttpHeaders} from "@angular/common/http";
import {catchError, Observable, tap} from "rxjs";
import {UserLogin, UserLoginResponse, UserRegister} from "../interfaces/auth-interfaces";

@Injectable()
export class AuthApiService {


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  get token(): string | null {
    return localStorage.getItem('token')
  }

  login(user: UserLogin): Observable<any> {
    return this.http.post(this.baseUrl + 'api/auth/login', user  )


  }

  autoLogin(token: string | null): Observable<any> | void{
    if (token) {
      return this.http.post(this.baseUrl + 'api/auth/login', token)
    }
  }

  register(user: UserRegister): Observable<any> {
    console.log(user)
    return this.http.post(this.baseUrl + 'api/auth/register', user)
  }

  logout() {
    this.setToken(null)
  }

  isAuthenticated(): boolean {
    return !!this.token
  }

  private setToken(response: UserLoginResponse | null) {
    if (response) {
      localStorage.setItem('token', response.token)
    } else {
      localStorage.clear()
    }
  }
}