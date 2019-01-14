﻿/* tslint:disable */
//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v12.0.8.0 (NJsonSchema v9.13.9.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------
// ReSharper disable InconsistentNaming

import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

@Injectable()
export class Service {
    private http: HttpClient;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http;
        this.baseUrl = baseUrl ? baseUrl : "";
    }

    /**
     * @param model (optional) 
     * @return Success
     */
    register(model: RegistrationViewModel | null | undefined): Observable<ResultReponser> {
        let url_ = this.baseUrl + "/api/Accounts";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(model);

        let options_ : any = {
            body: content_,
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Content-Type": "application/json", 
                "Accept": "application/json"
            })
        };

        return this.http.request("post", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processRegister(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processRegister(<any>response_);
                } catch (e) {
                    return <Observable<ResultReponser>><any>_observableThrow(e);
                }
            } else
                return <Observable<ResultReponser>><any>_observableThrow(response_);
        }));
    }

    protected processRegister(response: HttpResponseBase): Observable<ResultReponser> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? ResultReponser.fromJS(resultData200) : new ResultReponser();
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<ResultReponser>(<any>null);
    }

    /**
     * @param credentials (optional) 
     * @return Success
     */
    login(credentials: CredentialsViewModel | null | undefined): Observable<ResultReponser> {
        let url_ = this.baseUrl + "/api/Auth/login";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(credentials);

        let options_ : any = {
            body: content_,
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Content-Type": "application/json", 
                "Accept": "application/json"
            })
        };

        return this.http.request("post", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processLogin(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processLogin(<any>response_);
                } catch (e) {
                    return <Observable<ResultReponser>><any>_observableThrow(e);
                }
            } else
                return <Observable<ResultReponser>><any>_observableThrow(response_);
        }));
    }

    protected processLogin(response: HttpResponseBase): Observable<ResultReponser> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? ResultReponser.fromJS(resultData200) : new ResultReponser();
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<ResultReponser>(<any>null);
    }

    /**
     * @param model (optional) 
     * @return Success
     */
    changePassword(model: ChangepassViewModel | null | undefined): Observable<ResultReponser> {
        let url_ = this.baseUrl + "/api/ChangePassword";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(model);

        let options_ : any = {
            body: content_,
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Content-Type": "application/json", 
                "Accept": "application/json"
            })
        };

        return this.http.request("post", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processChangePassword(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processChangePassword(<any>response_);
                } catch (e) {
                    return <Observable<ResultReponser>><any>_observableThrow(e);
                }
            } else
                return <Observable<ResultReponser>><any>_observableThrow(response_);
        }));
    }

    protected processChangePassword(response: HttpResponseBase): Observable<ResultReponser> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? ResultReponser.fromJS(resultData200) : new ResultReponser();
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<ResultReponser>(<any>null);
    }

    /**
     * @return Success
     */
    getVwsEmployees(): Observable<VwsEmployee[]> {
        let url_ = this.baseUrl + "/api/ViewEmployee";
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetVwsEmployees(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetVwsEmployees(<any>response_);
                } catch (e) {
                    return <Observable<VwsEmployee[]>><any>_observableThrow(e);
                }
            } else
                return <Observable<VwsEmployee[]>><any>_observableThrow(response_);
        }));
    }

    protected processGetVwsEmployees(response: HttpResponseBase): Observable<VwsEmployee[]> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            if (resultData200 && resultData200.constructor === Array) {
                result200 = [];
                for (let item of resultData200)
                    result200.push(VwsEmployee.fromJS(item));
            }
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<VwsEmployee[]>(<any>null);
    }

    /**
     * @return Success
     */
    getVwsEmployee(id: string): Observable<VwsEmployee> {
        let url_ = this.baseUrl + "/api/ViewEmployee/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetVwsEmployee(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetVwsEmployee(<any>response_);
                } catch (e) {
                    return <Observable<VwsEmployee>><any>_observableThrow(e);
                }
            } else
                return <Observable<VwsEmployee>><any>_observableThrow(response_);
        }));
    }

    protected processGetVwsEmployee(response: HttpResponseBase): Observable<VwsEmployee> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? VwsEmployee.fromJS(resultData200) : new VwsEmployee();
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<VwsEmployee>(<any>null);
    }

    /**
     * @return Success
     */
    getPayrollPeriod(id: number): Observable<VwsPayrollHeader[]> {
        let url_ = this.baseUrl + "/api/ViewPayrollHeader/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetPayrollPeriod(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetPayrollPeriod(<any>response_);
                } catch (e) {
                    return <Observable<VwsPayrollHeader[]>><any>_observableThrow(e);
                }
            } else
                return <Observable<VwsPayrollHeader[]>><any>_observableThrow(response_);
        }));
    }

    protected processGetPayrollPeriod(response: HttpResponseBase): Observable<VwsPayrollHeader[]> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            if (resultData200 && resultData200.constructor === Array) {
                result200 = [];
                for (let item of resultData200)
                    result200.push(VwsPayrollHeader.fromJS(item));
            }
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<VwsPayrollHeader[]>(<any>null);
    }
}

export class RegistrationViewModel implements IRegistrationViewModel {
    userName?: string | undefined;
    birthday?: string | undefined;
    middleInitial?: string | undefined;
    email?: string | undefined;
    password?: string | undefined;

    constructor(data?: IRegistrationViewModel) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.userName = data["userName"];
            this.birthday = data["birthday"];
            this.middleInitial = data["middleInitial"];
            this.email = data["email"];
            this.password = data["password"];
        }
    }

    static fromJS(data: any): RegistrationViewModel {
        data = typeof data === 'object' ? data : {};
        let result = new RegistrationViewModel();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userName"] = this.userName;
        data["birthday"] = this.birthday;
        data["middleInitial"] = this.middleInitial;
        data["email"] = this.email;
        data["password"] = this.password;
        return data; 
    }
}

export interface IRegistrationViewModel {
    userName?: string | undefined;
    birthday?: string | undefined;
    middleInitial?: string | undefined;
    email?: string | undefined;
    password?: string | undefined;
}

export class ResultReponser implements IResultReponser {
    result?: string | undefined;
    message?: string | undefined;
    responseData?: any | undefined;

    constructor(data?: IResultReponser) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.result = data["result"];
            this.message = data["message"];
            this.responseData = data["responseData"];
        }
    }

    static fromJS(data: any): ResultReponser {
        data = typeof data === 'object' ? data : {};
        let result = new ResultReponser();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["result"] = this.result;
        data["message"] = this.message;
        data["responseData"] = this.responseData;
        return data; 
    }
}

export interface IResultReponser {
    result?: string | undefined;
    message?: string | undefined;
    responseData?: any | undefined;
}

export class CredentialsViewModel implements ICredentialsViewModel {
    userName?: string | undefined;
    password?: string | undefined;

    constructor(data?: ICredentialsViewModel) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.userName = data["userName"];
            this.password = data["password"];
        }
    }

    static fromJS(data: any): CredentialsViewModel {
        data = typeof data === 'object' ? data : {};
        let result = new CredentialsViewModel();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userName"] = this.userName;
        data["password"] = this.password;
        return data; 
    }
}

export interface ICredentialsViewModel {
    userName?: string | undefined;
    password?: string | undefined;
}

export class ChangepassViewModel implements IChangepassViewModel {
    id?: string | undefined;
    oldPassword?: string | undefined;
    newPassword?: string | undefined;

    constructor(data?: IChangepassViewModel) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.id = data["id"];
            this.oldPassword = data["oldPassword"];
            this.newPassword = data["newPassword"];
        }
    }

    static fromJS(data: any): ChangepassViewModel {
        data = typeof data === 'object' ? data : {};
        let result = new ChangepassViewModel();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["oldPassword"] = this.oldPassword;
        data["newPassword"] = this.newPassword;
        return data; 
    }
}

export interface IChangepassViewModel {
    id?: string | undefined;
    oldPassword?: string | undefined;
    newPassword?: string | undefined;
}

export class VwsEmployee implements IVwsEmployee {
    employeeNo?: string | undefined;
    lastName?: string | undefined;
    firstName?: string | undefined;
    middleName?: string | undefined;
    middleInitial?: string | undefined;
    suffixName?: string | undefined;
    employeeName?: string | undefined;
    birthday?: Date | undefined;

    constructor(data?: IVwsEmployee) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.employeeNo = data["employeeNo"];
            this.lastName = data["lastName"];
            this.firstName = data["firstName"];
            this.middleName = data["middleName"];
            this.middleInitial = data["middleInitial"];
            this.suffixName = data["suffixName"];
            this.employeeName = data["employeeName"];
            this.birthday = data["birthday"] ? new Date(data["birthday"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): VwsEmployee {
        data = typeof data === 'object' ? data : {};
        let result = new VwsEmployee();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["employeeNo"] = this.employeeNo;
        data["lastName"] = this.lastName;
        data["firstName"] = this.firstName;
        data["middleName"] = this.middleName;
        data["middleInitial"] = this.middleInitial;
        data["suffixName"] = this.suffixName;
        data["employeeName"] = this.employeeName;
        data["birthday"] = this.birthday ? this.birthday.toISOString() : <any>undefined;
        return data; 
    }
}

export interface IVwsEmployee {
    employeeNo?: string | undefined;
    lastName?: string | undefined;
    firstName?: string | undefined;
    middleName?: string | undefined;
    middleInitial?: string | undefined;
    suffixName?: string | undefined;
    employeeName?: string | undefined;
    birthday?: Date | undefined;
}

export class VwsPayrollHeader implements IVwsPayrollHeader {
    employeeNo?: string | undefined;
    payrollPeriod?: string | undefined;
    netPay?: number | undefined;
    validated?: string | undefined;

    constructor(data?: IVwsPayrollHeader) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.employeeNo = data["employeeNo"];
            this.payrollPeriod = data["payrollPeriod"];
            this.netPay = data["netPay"];
            this.validated = data["validated"];
        }
    }

    static fromJS(data: any): VwsPayrollHeader {
        data = typeof data === 'object' ? data : {};
        let result = new VwsPayrollHeader();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["employeeNo"] = this.employeeNo;
        data["payrollPeriod"] = this.payrollPeriod;
        data["netPay"] = this.netPay;
        data["validated"] = this.validated;
        return data; 
    }
}

export interface IVwsPayrollHeader {
    employeeNo?: string | undefined;
    payrollPeriod?: string | undefined;
    netPay?: number | undefined;
    validated?: string | undefined;
}

export class SwaggerException extends Error {
    message: string;
    status: number; 
    response: string; 
    headers: { [key: string]: any; };
    result: any; 

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isSwaggerException = true;

    static isSwaggerException(obj: any): obj is SwaggerException {
        return obj.isSwaggerException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
    if(result !== null && result !== undefined)
        return _observableThrow(result);
    else
        return _observableThrow(new SwaggerException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
    return new Observable<string>((observer: any) => {
        if (!blob) {
            observer.next("");
            observer.complete();
        } else {
            let reader = new FileReader(); 
            reader.onload = event => { 
                observer.next((<any>event.target).result);
                observer.complete();
            };
            reader.readAsText(blob); 
        }
    });
}