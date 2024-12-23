using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaACG {
    public partial class DetallePedido : Form {
        Pedidos pedido;
        public DetallePedido() {
            InitializeComponent();
        }
        public DetallePedido(Pedidos pedido) {
            this.pedido = pedido;
            InitializeComponent();
        }

        private void DetallePedido_Load(object sender, EventArgs e) {
            lblPedido.Text = "Pedido al distribuirdo " + pedido.distribuidor;
            lblDatos.Text = pedido.cantidadMedicamento.ToString() + " unidades de " + pedido.tipoMedicamento + " " + pedido.nombreMedicamento;
            if (pedido.sucursalPrincipal != null && pedido.sucursalPrincipal.Length > 0 && pedido.sucursalSecundaria != null && pedido.sucursalSecundaria.Length > 0) {
                lblSucursalPrincipal.Text = "Para la farmacia situada en " + pedido.sucursalPrincipal;
                lblSucursalSecundaria.Text = "y para la situada en " + pedido.sucursalSecundaria;
            }

            if (pedido.sucursalPrincipal != null && pedido.sucursalPrincipal.Length > 0 && (pedido.sucursalSecundaria == null || pedido.sucursalSecundaria.Length == 0)) {
                lblSucursalPrincipal.Text = "Para la farmacia situada en " + pedido.sucursalPrincipal;
                lblSucursalSecundaria.Text = "";
            }

            if (pedido.sucursalSecundaria != null && pedido.sucursalSecundaria.Length > 0 && (pedido.sucursalPrincipal == null || pedido.sucursalPrincipal.Length == 0)) {
                lblSucursalPrincipal.Text = "Para la farmacia situada en " + pedido.sucursalSecundaria;
                lblSucursalSecundaria.Text = "";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            MessageBox.Show("Pedido enviado correctamente...");
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
