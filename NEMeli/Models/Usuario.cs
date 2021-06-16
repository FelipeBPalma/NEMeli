using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEMeli.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Cargo { get; set; }

        public string Pais { get; set; }

        public string Equipe { get; set; }

        public DateTime DataEntrada { get; set; }

        public DateTime DataAlteracao { get; set; }
    }
}
