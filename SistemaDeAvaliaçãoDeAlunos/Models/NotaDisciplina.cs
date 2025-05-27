using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaDeAvaliaçãoDeAlunos.Models
{
    public class NotaDisciplina
    {
        public string NomeDisciplina { get; set; }

        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
        public double Nota { get; set; }
    }
}