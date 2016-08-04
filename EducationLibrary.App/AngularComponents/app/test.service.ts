import { Injectable }     from '@angular/core';
import { Http, Response } from '@angular/http';
import { Test } from './model';
import { Observable }     from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/operator/delay';
import 'rxjs/operator/mergeMap';
import 'rxjs/operator/switchMap';
import 'rxjs/Rx';

@Injectable()
export class TestService {
    _url = 'http://localhost:18888/api/test';
    constructor(private _http: Http) { }

    getTest() {
        return this._http.get(this._url)
            .map(function (response) { return <Test[]>response.json(); })
            .catch(error => {
                console.log(error);
                return Observable.throw(error);
            });
    }

    //private extractData(res: Response) {
    //    let body = res.json();
    //    return body.data || {};
    //}
    //private handleError(error: any) {
    //    // In a real world app, we might use a remote logging infrastructure
    //    // We'd also dig deeper into the error to get a better message
    //    let errMsg = (error.message) ? error.message :
    //        error.status ? `${error.status} - ${error.statusText}` : 'Server error';
    //    console.error(errMsg); // log to console instead
    //    return Observable.throw(errMsg);
    //}
}