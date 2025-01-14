import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environments/environment';
import { Usuario, CorredorUpdate } from '../interfaces/usuario';

@Injectable({
  providedIn: 'root',
})
export class CorredorService {
  constructor(private http: HttpClient) {}
  private myAppUrl: string = environment.endpoint;
  private myApiUrl: string = 'api/Corredor';

  getCorredorByDni(dni: string): Observable<Usuario> {
    return this.http.get<Usuario>(`${this.myAppUrl}${this.myApiUrl}/${dni}`);
  }
  getCorredor(id: string): Observable<Usuario> {
    return this.http.get<Usuario>(
      `${this.myAppUrl}${this.myApiUrl}/GetCorredor/${id}`
    );
  }
  verificarDni(dni: string): Observable<boolean> {
    return this.http.get<boolean>(
      `${this.myAppUrl}${this.myApiUrl}/existe/${dni}`
    );
  }
  updateImagen(id: number, imagen: File) {
    const formData = new FormData();
    formData.append('imagen',imagen);
    formData.append('corredorID', id.toString());
    //const headers = new HttpHeaders({ 'Content-Type': 'application/json' });
    return this.http.post<any>(
      `${this.myAppUrl}${this.myApiUrl}/UploadImage`,
      formData
    );
  }
  getUserAge(currentUser: Usuario): number | null {
    console.log('fechaNac', currentUser.fechaNacimiento);
    if (currentUser && currentUser.fechaNacimiento) {
      const birthdate = new Date(currentUser.fechaNacimiento);
      console.log('birthday', birthdate);
      const ageDifMs = Date.now() - birthdate.getTime();
      console.log('agedif ms', ageDifMs);
      const ageDate = new Date(ageDifMs);
      console.log('agedif ms', ageDate.getUTCFullYear());
      return Math.abs(ageDate.getUTCFullYear() - 1970);
    }
    return null;
  }
  Update(corredorID: number, corredorDto: CorredorUpdate): Observable<any> {
    return this.http.put(`${this.myAppUrl}${this.myApiUrl}/${corredorID}`, corredorDto);
  }
}

