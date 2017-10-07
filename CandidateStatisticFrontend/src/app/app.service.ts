import { Injectable } from '@angular/core';
import { Http, Response} from '@angular/http';
import { Observable } from "rxjs/Rx";

@Injectable()
export class AppService {

  constructor(private http : Http) { }

  getStatistic() : Observable<any> {
  	return this.http
  			.get('http://localhost:51317/api/CandidateStatistic')
  }

}
