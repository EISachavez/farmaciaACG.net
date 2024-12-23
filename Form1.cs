using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaACG {
    public partial class FormFarmaciaACG : Form {        

        public FormFarmaciaACG() {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

        }        

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e) {
            
        }

        private void btnContinuar_Click(object sender, EventArgs e) {
            String nombre = tbxNombre.Text;
            String tipo = cbxTipo.Text;
            int cantidad = 0;
            int.TryParse(tbxCantidad.Text, out cantidad);
            String distribuidor = "";
            distribuidor = rbtnCemefar.Checked ? "Cemefar" : rbtnCofarma.Checked ? "Cofarma" : rbtnEmpsephar.Checked ? "Empsephar" : "";

            String principal = cbxPrincipal.Checked ? "Calle de la Rosa n. 28" : null;
            String secundaria = cbxSecundaria.Checked ? "Calle Alcazabilla n. 3" : null;

            Pedidos pedido = new Pedidos(nombre, tipo, cantidad, distribuidor, principal, secundaria);

            if (validaCampos(pedido)) {
                DetallePedido detalle = new DetallePedido(pedido);
                AddOwnedForm(detalle);
                limpiarFormulario();
                detalle.Show();
            }


        }

        private Boolean validaCampos(Pedidos pedido) {
            Boolean resultado = true;
            Validador validador = new Validador();

            String msgError = validador.validaNombre(pedido.nombreMedicamento);

            if (msgError.Length > 0) {
                resultado = false;
                MessageBox.Show(msgError);                
            }

            msgError = validador.validaTipo(pedido.tipoMedicamento);
            if (msgError.Length > 0) {
                resultado = false;
                MessageBox.Show(msgError);
            }

            msgError = validador.validaCantidad(pedido.cantidadMedicamento);
            if (msgError.Length > 0) {
                resultado = false;
                MessageBox.Show(msgError);
            }

            msgError = validador.validaDistribuidor(pedido.distribuidor);
            if (msgError.Length > 0) {
                resultado = false;
                MessageBox.Show(msgError);
            }

            msgError = validador.validaSucursal(pedido.sucursalPrincipal, pedido.sucursalSecundaria);
            if (msgError.Length > 0) {
                resultado = false;
                MessageBox.Show(msgError);
            }

            return resultado;
        }

        private void tbxCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            char tecla = e.KeyChar;
            string patron = @"^[0-9]$";
            
            if (tecla == (char)8) {
                return; 
            }

            if (!Regex.IsMatch(tecla.ToString(), patron)) {
                MessageBox.Show("Solo se permiten caracteres númericos.");
                e.Handled = true;
            }
        }

        private void limpiarFormulario() {
            tbxNombre.Text = "";
            cbxTipo.SelectedIndex = -1;
            tbxCantidad.Text = "";
            rbtnCemefar.Checked = false; 
            rbtnCofarma.Checked = false;
            rbtnEmpsephar.Checked = false;
            cbxPrincipal.Checked = false;
            cbxSecundaria.Checked = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            DialogResult eleccion = MessageBox.Show("¿Confirma que desea reinicar el formulario?", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (eleccion == DialogResult.OK) {
                limpiarFormulario();
            }
        }
    }
}
