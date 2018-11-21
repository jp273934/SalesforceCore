import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class DataService {
    constructor(private http : HttpClient){ }

    getData (type : string){
        return this.http.get('/api/' + type + 's');
    }
}