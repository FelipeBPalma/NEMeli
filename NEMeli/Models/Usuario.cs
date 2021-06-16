using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NEMeli.Models
{
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Column("Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Column("Cargo")]
        [Display(Name = "Cargo")]
        public string Cargo { get; set; }

        [Column("Pais")]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Column("Equipe")]
        [Display(Name = "Equipe")]
        public string Equipe { get; set; }

        [Column("DataEntrada")]
        [Display(Name = "Data de Entrada")]
        public DateTime DataEntrada { get; set; }

        [Column("DataAlteracao")]
        [Display(Name = "Última Alteracão")]
        public DateTime DataAlteracao { get; set; }
    }
}
