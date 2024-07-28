﻿using BE.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE.Dto
{
    public class TareaVoluntarioEstadoDto
    {
        

            [ForeignKey("Tarea")]
            public int TareaID { get; set; }

            [ForeignKey("Voluntario")]
            public int VoluntarioID { get; set; }

            public string Estado { get; set; }
        }


    }

