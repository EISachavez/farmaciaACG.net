namespace FarmaciaACG {
    partial class FormFarmaciaACG {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFarmaciaACG));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.rbtnCofarma = new System.Windows.Forms.RadioButton();
            this.rbtnEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbtnCemefar = new System.Windows.Forms.RadioButton();
            this.cbxPrincipal = new System.Windows.Forms.CheckBox();
            this.cbxSecundaria = new System.Windows.Forms.CheckBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloLateral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panelIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblNombre.Location = new System.Drawing.Point(324, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(188, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre medicamento:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTipo.Location = new System.Drawing.Point(324, 149);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(160, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo medicamento:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCantidad.Location = new System.Drawing.Point(324, 198);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(227, 20);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad del medicamento:";
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistribuidor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDistribuidor.Location = new System.Drawing.Point(324, 249);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(106, 20);
            this.lblDistribuidor.TabIndex = 3;
            this.lblDistribuidor.Text = "Distribuidor:";
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSucursal.Location = new System.Drawing.Point(324, 307);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(84, 20);
            this.lblSucursal.TabIndex = 4;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.Silver;
            this.tbxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(582, 102);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(297, 26);
            this.tbxNombre.TabIndex = 5;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.BackColor = System.Drawing.Color.Silver;
            this.tbxCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCantidad.Location = new System.Drawing.Point(582, 197);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(297, 26);
            this.tbxCantidad.TabIndex = 6;
            this.tbxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidad_KeyPress);
            // 
            // cbxTipo
            // 
            this.cbxTipo.BackColor = System.Drawing.Color.Silver;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Analgésico",
            "Analéptico",
            "Anestésico",
            "Antiácido",
            "Antidepresivo ",
            "Antibióticos"});
            this.cbxTipo.Location = new System.Drawing.Point(582, 149);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(297, 26);
            this.cbxTipo.TabIndex = 7;
            // 
            // rbtnCofarma
            // 
            this.rbtnCofarma.AutoSize = true;
            this.rbtnCofarma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCofarma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnCofarma.Location = new System.Drawing.Point(582, 247);
            this.rbtnCofarma.Name = "rbtnCofarma";
            this.rbtnCofarma.Size = new System.Drawing.Size(87, 22);
            this.rbtnCofarma.TabIndex = 8;
            this.rbtnCofarma.TabStop = true;
            this.rbtnCofarma.Text = "Cofarma";
            this.rbtnCofarma.UseVisualStyleBackColor = true;
            // 
            // rbtnEmpsephar
            // 
            this.rbtnEmpsephar.AutoSize = true;
            this.rbtnEmpsephar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmpsephar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnEmpsephar.Location = new System.Drawing.Point(674, 247);
            this.rbtnEmpsephar.Name = "rbtnEmpsephar";
            this.rbtnEmpsephar.Size = new System.Drawing.Size(107, 22);
            this.rbtnEmpsephar.TabIndex = 9;
            this.rbtnEmpsephar.TabStop = true;
            this.rbtnEmpsephar.Text = "Empsephar";
            this.rbtnEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbtnCemefar
            // 
            this.rbtnCemefar.AutoSize = true;
            this.rbtnCemefar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCemefar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rbtnCemefar.Location = new System.Drawing.Point(791, 247);
            this.rbtnCemefar.Name = "rbtnCemefar";
            this.rbtnCemefar.Size = new System.Drawing.Size(87, 22);
            this.rbtnCemefar.TabIndex = 10;
            this.rbtnCemefar.TabStop = true;
            this.rbtnCemefar.Text = "Cemefar";
            this.rbtnCemefar.UseVisualStyleBackColor = true;
            // 
            // cbxPrincipal
            // 
            this.cbxPrincipal.AutoSize = true;
            this.cbxPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxPrincipal.Location = new System.Drawing.Point(582, 309);
            this.cbxPrincipal.Name = "cbxPrincipal";
            this.cbxPrincipal.Size = new System.Drawing.Size(88, 22);
            this.cbxPrincipal.TabIndex = 11;
            this.cbxPrincipal.Text = "Principal";
            this.cbxPrincipal.UseVisualStyleBackColor = true;
            // 
            // cbxSecundaria
            // 
            this.cbxSecundaria.AutoSize = true;
            this.cbxSecundaria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSecundaria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxSecundaria.Location = new System.Drawing.Point(722, 309);
            this.cbxSecundaria.Name = "cbxSecundaria";
            this.cbxSecundaria.Size = new System.Drawing.Size(107, 22);
            this.cbxSecundaria.TabIndex = 12;
            this.cbxSecundaria.Text = "Secundaria";
            this.cbxSecundaria.UseVisualStyleBackColor = true;
            this.cbxSecundaria.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnContinuar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinuar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(722, 354);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(156, 39);
            this.btnContinuar.TabIndex = 13;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.Gray;
            this.panelIzq.Controls.Add(this.pictureBox1);
            this.panelIzq.Controls.Add(this.lblTituloLateral);
            this.panelIzq.Location = new System.Drawing.Point(2, 0);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(275, 431);
            this.panelIzq.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 105);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloLateral
            // 
            this.lblTituloLateral.AutoSize = true;
            this.lblTituloLateral.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLateral.Location = new System.Drawing.Point(39, 102);
            this.lblTituloLateral.Name = "lblTituloLateral";
            this.lblTituloLateral.Size = new System.Drawing.Size(183, 90);
            this.lblTituloLateral.TabIndex = 0;
            this.lblTituloLateral.Text = "Farmacia\r\nACG";
            this.lblTituloLateral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(451, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestión de pedidos\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBorrar.BackgroundImage")));
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Location = new System.Drawing.Point(328, 345);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 48);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormFarmaciaACG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(921, 430);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIzq);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.cbxSecundaria);
            this.Controls.Add(this.cbxPrincipal);
            this.Controls.Add(this.rbtnCemefar);
            this.Controls.Add(this.rbtnEmpsephar);
            this.Controls.Add(this.rbtnCofarma);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.tbxCantidad);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.lblDistribuidor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFarmaciaACG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Farmacia ACG";
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.RadioButton rbtnCofarma;
        private System.Windows.Forms.RadioButton rbtnEmpsephar;
        private System.Windows.Forms.RadioButton rbtnCemefar;
        private System.Windows.Forms.CheckBox cbxPrincipal;
        private System.Windows.Forms.CheckBox cbxSecundaria;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Label lblTituloLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
    }
}

