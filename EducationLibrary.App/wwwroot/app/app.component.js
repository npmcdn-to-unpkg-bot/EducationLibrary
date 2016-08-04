"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require('@angular/core');
//import {ContactFormComponent} from './contact-form.component';
var http_1 = require('@angular/http');
var test_service_1 = require('./test.service');
require('rxjs/Rx');
var AppComponent = (function () {
    function AppComponent(_testService) {
        this._testService = _testService;
        this.title = 'Test list';
    }
    AppComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._testService.getTest()
            .subscribe(function (tests) {
            _this.tests = tests;
        }),
            function (error) { return alert(error); };
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            //directives: [Test],
            template: "\n    <div class=\"row\">\n    <div class=\"col-md-offset-4 col-md-4\">\n    <h1>{{title}}</h1>\n        <table class=\"table\">\n            <thead>\n                <tr>\n                    <th>Value ID</th>\n                    <th>Value Name</th>\n                    <th>Value Descriptio</th>\n                    <th>Delete</th>\n                </tr>\n            </thead>\n            <tbody>\n                <tr *ngFor=\"let test of tests\">\n                    <td>{{test.id}}</td>\n                    <td>{{test.name}}</td>\n                    <td>{{test.description}}</td>\n                    <td> <span class=\"glyphicon glyphicon-edit\" aria-hidden=\"true\"></span> </td>\n                    <td> <span class=\"glyphicon glyphicon-remove\" aria-hidden=\"true\"></span> </td>\n                </tr>\n            </tbody>\n        </table>\n    </div>\n    </div>\n    ",
            providers: [
                http_1.HTTP_PROVIDERS,
                test_service_1.TestService
            ]
        }), 
        __metadata('design:paramtypes', [test_service_1.TestService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map