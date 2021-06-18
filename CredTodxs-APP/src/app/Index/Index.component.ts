import { Component, OnInit } from '@angular/core';
import { OfertaService } from '../_services/oferta.service';

@Component({
  selector: 'app-Index',
  templateUrl: './Index.component.html',
  styleUrls: ['./Index.component.css']
})
export class IndexComponent implements OnInit {

  Ofertas: any = [];

  constructor(private ofertaService: OfertaService) { }

  ngOnInit() {
    this.getOfertas();
  }

  getOfertas(){
    this.ofertaService.getOfertas().subscribe(response => {
      this.Ofertas = response;
      console.log(this.Ofertas)
    }, error => {
      console.log(error)
    });
  }

}
