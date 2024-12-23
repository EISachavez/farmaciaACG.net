namespace FarmaciaACG {
    partial class DetallePedido {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetallePedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPedido = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblSucursalPrincipal = new System.Windows.Forms.Label();
            this.lblSucursalSecundaria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 84);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(739, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Detalle del pedido";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnEnviar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Location = new System.Drawing.Point(-2, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 95);
            this.panel2.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEnviar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(506, 20);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(190, 49);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar pedido";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(43, 20);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 49);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar pedido";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPedido
            // 
            this.lblPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblPedido.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblPedido.Location = new System.Drawing.Point(-2, 110);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(739, 29);
            this.lblPedido.TabIndex = 2;
            this.lblPedido.Text = "Pedido al distribuidor";
            this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.Color.White;
            this.lblDatos.Location = new System.Drawing.Point(3, 172);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(734, 22);
            this.lblDatos.TabIndex = 3;
            this.lblDatos.Text = "X unidades de T M";
            this.lblDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSucursalPrincipal
            // 
            this.lblSucursalPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursalPrincipal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalPrincipal.ForeColor = System.Drawing.Color.White;
            this.lblSucursalPrincipal.Location = new System.Drawing.Point(-2, 233);
            this.lblSucursalPrincipal.Name = "lblSucursalPrincipal";
            this.lblSucursalPrincipal.Size = new System.Drawing.Size(739, 22);
            this.lblSucursalPrincipal.TabIndex = 4;
            this.lblSucursalPrincipal.Text = "principal";
            this.lblSucursalPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSucursalSecundaria
            // 
            this.lblSucursalSecundaria.BackColor = System.Drawing.Color.Transparent;
            this.lblSucursalSecundaria.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursalSecundaria.ForeColor = System.Drawing.Color.White;
            this.lblSucursalSecundaria.Location = new System.Drawing.Point(-6, 279);
            this.lblSucursalSecundaria.Name = "lblSucursalSecundaria";
            this.lblSucursalSecundaria.Size = new System.Drawing.Size(743, 22);
            this.lblSucursalSecundaria.TabIndex = 5;
            this.lblSucursalSecundaria.Text = "secundaria";
            this.lblSucursalSecundaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(736, 479);
            this.Controls.Add(this.lblSucursalSecundaria);
            this.Controls.Add(this.lblSucursalPrincipal);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblPedido);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetallePedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle del pedido";
            this.Load += new System.EventHandler(this.DetallePedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblSucursalPrincipal;
        private System.Windows.Forms.Label lblSucursalSecundaria;
        private System.Windows.Forms.Button btnEnviar;
    }
}