import { Component } from '@angular/core';
import { Busqueda } from 'src/app/interfaces/busqueda';
import { EventoResponse } from 'src/app/interfaces/evento';
import { EventoService } from 'src/app/services/evento.service';

@Component({
  selector: 'app-proximos-eventos',
  templateUrl: './proximos-eventos.component.html',
  styleUrl: './proximos-eventos.component.css',
})
export class ProximosEventosComponent {
  eventosActivos: any[] = [];
  eventos: any[] = [];
  textoBusqueda: string = '';
  constructor(private _eventoService: EventoService) {}

  ngOnInit(): void {
    this.obtenerEventos();
  }
  obtenerEventos(): void {
    this._eventoService.buscar(this.parametrosBusqueda).subscribe(
      (data: any[]) =>{
      this.eventos=data
      this.filtrarEventos();
    });
  }
  parametrosBusqueda: Busqueda = {
    texto: '',
    fechaIni: '',
    fechaFin: '',
    tipoEvento: '',
    lugar: '',
  };


  // ver que los eventos inactivos tengan resultados
  filtrarEventos(): void {
    let eventosFiltrados = this.eventos.filter((evento) =>
      evento.nombre.toLowerCase().includes(this.textoBusqueda.toLowerCase())
    );
    this.eventosActivos= eventosFiltrados.filter(
      (evento) => evento.estado === 'Activo'
    );
  }
}
