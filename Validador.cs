using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FarmaciaACG {
    class Validador {
        public String validaNombre(String valor) {
            String errMsg = "";
            String expresion = @"^[a-zA-Z0-9áéíóúÁÉÍÓÚñÑ\s]+$";

            if (valor == null || valor.Trim().Length == 0) {
                errMsg = "El nombre del medicamento es obligatorio.";
                return errMsg;
            }

            if(!Regex.IsMatch(valor, expresion)) {
                errMsg = "El nombre contiene caracteres invalidos o no permitidos.";
                return errMsg;
            }

            if(valor.Length < 5 || valor.Length > 100) {
                errMsg = "El nombre del medicamento debe tener entre 5 y 100 caracteres";
                return errMsg;
            }
            
            return errMsg;
        }

        public String validaTipo(String valor) {
            String errMsg = "";

            if (valor == null || valor.Trim().Length == 0) {
                errMsg = "Debe seleccionar el tipo de medicamento.";
                return errMsg;
            }

            return errMsg;
        }

        public String validaCantidad(int valor) {
            String errMsg = "";

            if (valor <= 0) {
                errMsg = "Debe introducir una cantidad mayor a 0.";
                return errMsg;
            }

            if (valor > 120) {
                errMsg = "La máxima cantidad a pedir son 120.";
                return errMsg;
            }

            return errMsg;
        }

        public String validaDistribuidor(String valor) {
            String errMsg = "";

            if (valor == null || valor.Trim().Length == 0) {
                errMsg = "Debe seleccionar el distribuidor del medicamento.";
                return errMsg;
            }

            return errMsg;
        }

        public String validaSucursal(String principal, String secundaria) {
            String errMsg = "";

            if ((principal == null || principal.Trim().Length == 0) && (secundaria == null || secundaria.Trim().Length == 0)) {
                errMsg = "Debe seleccionar al menos una sucursal.";
                return errMsg;
            }

            return errMsg;
        }
    }
}
