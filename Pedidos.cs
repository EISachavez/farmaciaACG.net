using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaACG {
    public class Pedidos {
        public String nombreMedicamento { get; set; }
        public String tipoMedicamento { get; set; }
        public int cantidadMedicamento { get; set; }
        public String distribuidor { get; set; }
        public String sucursalPrincipal { get; set; }
        public String sucursalSecundaria { get; set; }

        public Pedidos(string nombreMedicamento, string tipoMedicamento, int cantidadMedicamento, string distribuidor, string sucursalPrincipal, string sucursalSecundaria) {
            this.nombreMedicamento = nombreMedicamento;
            this.tipoMedicamento = tipoMedicamento;
            this.cantidadMedicamento = cantidadMedicamento;
            this.distribuidor = distribuidor;
            this.sucursalPrincipal = sucursalPrincipal;
            this.sucursalSecundaria = sucursalSecundaria;
        }

        public Pedidos() {

        }
    }
}
