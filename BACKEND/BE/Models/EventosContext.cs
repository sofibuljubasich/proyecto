﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BE.Models
{
    public class EventosContext : DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options) : base(options)
        { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Distancia> Distancias { get; set; }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Inscripcion> Inscripciones { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        public DbSet<TipoEvento> TiposEventos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Corredor> Corredores { get; set; }

        public DbSet<Voluntario> Voluntarios { get; set; }  







    }
}
