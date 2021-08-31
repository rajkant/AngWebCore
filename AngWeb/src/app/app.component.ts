import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'; 


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  constructor(private _httpService: Http) { }
  apiValues: string[] = [];
  columnDefs = [
    { headerName: 'Customer', field: 'customer_name' },
    { headerName: 'Routing', field: 'routing_number' },
    { headerName: 'Address', field: 'address' },
    { headerName: 'City', field: 'city' },
    { headerName: 'Zip', field: 'zip' },
    { headerName: 'State', field: 'state' },
    { headerName: 'Telephone', field: 'telephone' },
    { headerName: 'Date', field: 'change_date' },
    { headerName: 'Status', field: 'institution_status_code' },
    { headerName: 'Office', field: 'office_code' },
    { headerName: 'Data', field: 'data_view_code' },
    { headerName: 'Message', field: 'message' },
    { headerName: 'New Routing', field: 'new_routing_number' },
    { headerName: 'Rn', field: 'rn' },
    { headerName: 'Code', field: 'code' },
    { headerName: 'Type', field: 'record_type_code' }
  ];
  rowData = [];
  countries = ['USA', 'Canada', 'Uk'];
 
  ngOnInit() {
    this._httpService.get('/api/values/GetDropDown').subscribe(values => {
      this.apiValues = values.json() as string[];
    });
    this._httpService.get('/api/values/GetRoutingNums?test=test').subscribe(values => {
      this.rowData = values.json();
    });
  }
  onClickSubmit(datain) {
    const req = this._httpService.post('/api/values/Post', {
      datain
    })
      .subscribe(
        res => {
          alert(res);
        },
        err => {
          alert("Error occured");
        }
      );
  }

}


