import { Component } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [AppService]
})
export class AppComponent {
  title = 'Candidate statistics';

  statisticResult = {};

  constructor(private service : AppService) {
  	service
  	 .getStatistic()
  	 .subscribe((res:Response) => this.statisticResult = res.json());
  }
}
