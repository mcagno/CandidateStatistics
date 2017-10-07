import { Injectable } from '@angular/core';
import { Http, Response} from '@angular/http';
import { Observable } from "rxjs/Rx";

@Injectable()
export class AppService {

  constructor(private http : Http) { }

  baseServerUrl = 'http://localhost:51317/';

  getStatistic() : Observable<any> {
  	return this.http
  			.get(this.baseServerUrl + '/api/CandidateStatistic')
  }

}
