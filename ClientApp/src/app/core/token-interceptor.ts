import { Injectable } from '@angular/core';
import {
    HttpRequest,
    HttpHandler,
    HttpEvent,
    HttpInterceptor
} from '@angular/common/http';

import { AuthService } from '../shared/authentication/auth.service';
import { Observable } from 'rxjs';

@Injectable()
export class TokenInterceptor {

    constructor(public authService: AuthService) { }

    /**
     * Intercept all HTTP request to add JWT token to Headers
     * @param {HttpRequest<any>} request
     * @param {HttpHandler} next
     * @returns {Observable<HttpEvent<any>>}
     * @memberof TokenInterceptor
     */
    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        if (request.url.includes('/login')) {
            return next.handle(request);
        }
        request = request.clone({
            setHeaders: {
                Authorization: `Bearer ${this.authService.getCurrentUser().token}`
            }
        });
        return next.handle(request);
    }
}
