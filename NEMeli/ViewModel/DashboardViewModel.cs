using NEMeli.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NEMeli.ViewModel
{
    public class DashboardViewModel
    {
        public int UsuariosTotais { get; set; }
        public IEnumerable<ChaveValor> UsuariosCargo { get; internal set; }
        public IEnumerable<ChaveValor> UsuariosPais { get; internal set; }
        public IEnumerable<ChaveValor> UsuariosMes { get; internal set; }
    }
}
