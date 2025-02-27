﻿using BE.Dto;
using BE.Models;

namespace BE.Interfaces
{
    public interface IInscripcionRepository
    {

        Task<InscRepository> Get(int eventoID, int corredorID);
        Task<Inscripcion> GetInscripcion(int id);
      
        Task UpdatePayment(int inscID, string estadoPago);
        Task<Inscripcion> CreateInscripcion(Inscripcion inscripcion);

        Task Acreditar(int inscID, Boolean estado);    
        Task UpdateInscripcion(Inscripcion inscripcion, int ID);

        Task DeleteInscripcion(Inscripcion inscripcion);
        Task<Inscripcion> CheckIfExists(int usuarioID, int eventoID);
        Task<List<Evento>> ObtenerEventosInscritosPorUsuario(int usuarioID);
    }
}
