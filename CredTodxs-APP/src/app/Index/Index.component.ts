import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Index',
  templateUrl: './Index.component.html',
  styleUrls: ['./Index.component.css']
})
export class IndexComponent implements OnInit {

  Ofertas: any = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getOfertas();
  }

  getOfertas(){
    this.http.get('http://localhost:5000/api/oferta/').subscribe(response => {
      this.Ofertas = response;
      console.log(this.Ofertas)
    }, error => {
      console.log(error)
    }
    );
  }

}
