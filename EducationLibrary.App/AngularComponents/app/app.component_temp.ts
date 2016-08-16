import { Component, OnInit } from '@angular/core';
//import {ContactFormComponent} from './contact-form.component';
import { HTTP_PROVIDERS} from '@angular/http';
import { Test } from './model';
import { TestService } from './test.service';
import 'rxjs/Rx';

@Component({
    selector: 'my-app',
    //directives: [Test],
    template: `
    <div class="row">
    <div class="col-md-offset-4 col-md-4">
    <h1>{{title}}</h1>
        <table class="table">
            <thead>
                <tr>
                    <th>Value ID</th>
                    <th>Value Name</th>
                    <th>Value Descriptio</th>
                    <th>Delete</th>
                </tr>
            </thead>
            <tbody>
                <tr *ngFor="let test of tests">
                    <td>{{test.id}}</td>
                    <td>{{test.name}}</td>
                    <td>{{test.description}}</td>
                    <td> <span class="glyphicon glyphicon-edit" aria-hidden="true"></span> </td>
                    <td> <span class="glyphicon glyphicon-remove" aria-hidden="true"></span> </td>
                </tr>
            </tbody>
        </table>
    </div>
    </div>
    `,
    providers: [
        HTTP_PROVIDERS,
        TestService
    ]

})
export class AppComponent implements OnInit {
    public title = 'Test list';
    public tests: Test[];

    constructor(private _testService: TestService) { }

    ngOnInit() {
        this._testService.getTest()
            .subscribe(
            tests => {
                this.tests = tests;
            }),
            error => alert(error);
    }
}
