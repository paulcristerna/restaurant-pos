namespace Sistema_Restaurant
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.pbComerciales = new System.Windows.Forms.PictureBox();
            this.cbMesa = new System.Windows.Forms.ComboBox();
            this.lblMesas = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvPlatillos = new System.Windows.Forms.DataGridView();
            this.cbMesero = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblPagoCon = new System.Windows.Forms.Label();
            this.txtPagoCon = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.panelCobro = new System.Windows.Forms.Panel();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComerciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillos)).BeginInit();
            this.panelCobro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.Transparent;
            this.panelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpciones.BackgroundImage")));
            this.panelOpciones.Controls.Add(this.btnAgregar);
            this.panelOpciones.Controls.Add(this.txtNombrePlatillo);
            this.panelOpciones.Controls.Add(this.pbPlatillo);
            this.panelOpciones.Controls.Add(this.lblNombrePlatillo);
            this.panelOpciones.Controls.Add(this.btnEliminar);
            this.panelOpciones.Location = new System.Drawing.Point(17, 17);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(461, 358);
            this.panelOpciones.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(275, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 78);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlatillo.Location = new System.Drawing.Point(133, 245);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(313, 29);
            this.txtNombrePlatillo.TabIndex = 3;
            // 
            // pbPlatillo
            // 
            this.pbPlatillo.BackColor = System.Drawing.Color.Transparent;
            this.pbPlatillo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlatillo.BackgroundImage")));
            this.pbPlatillo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlatillo.Location = new System.Drawing.Point(96, 16);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(282, 210);
            this.pbPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatillo.TabIndex = 10;
            this.pbPlatillo.TabStop = false;
            // 
            // lblNombrePlatillo
            // 
            this.lblNombrePlatillo.AutoSize = true;
            this.lblNombrePlatillo.BackColor = System.Drawing.Color.White;
            this.lblNombrePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlatillo.ForeColor = System.Drawing.Color.Black;
            this.lblNombrePlatillo.Location = new System.Drawing.Point(23, 245);
            this.lblNombrePlatillo.Name = "lblNombrePlatillo";
            this.lblNombrePlatillo.Size = new System.Drawing.Size(91, 24);
            this.lblNombrePlatillo.TabIndex = 2;
            this.lblNombrePlatillo.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(370, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 78);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(20, 205);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(83, 78);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            this.btnPagar.Location = new System.Drawing.Point(347, 205);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(99, 78);
            this.btnPagar.TabIndex = 16;
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // pbComerciales
            // 
            this.pbComerciales.BackColor = System.Drawing.Color.Transparent;
            this.pbComerciales.Image = ((System.Drawing.Image)(resources.GetObject("pbComerciales.Image")));
            this.pbComerciales.Location = new System.Drawing.Point(1142, 18);
            this.pbComerciales.Name = "pbComerciales";
            this.pbComerciales.Size = new System.Drawing.Size(199, 651);
            this.pbComerciales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComerciales.TabIndex = 28;
            this.pbComerciales.TabStop = false;
            // 
            // cbMesa
            // 
            this.cbMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesa.FormattingEnabled = true;
            this.cbMesa.Items.AddRange(new object[] {
            "MESA 1",
            "MESA 2",
            "MESA 3",
            "MESA 4",
            "MESA 5",
            "MESA 6"});
            this.cbMesa.Location = new System.Drawing.Point(156, 62);
            this.cbMesa.Name = "cbMesa";
            this.cbMesa.Size = new System.Drawing.Size(290, 32);
            this.cbMesa.TabIndex = 27;
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.BackColor = System.Drawing.Color.White;
            this.lblMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.ForeColor = System.Drawing.Color.Black;
            this.lblMesas.Location = new System.Drawing.Point(23, 64);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(66, 24);
            this.lblMesas.TabIndex = 26;
            this.lblMesas.Text = "Mesa:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(23, 27);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(86, 24);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Mesero:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(40, 300);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(98, 24);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(150, 299);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(57, 29);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.Text = "1";
            // 
            // dgvPlatillos
            // 
            this.dgvPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatillos.Location = new System.Drawing.Point(497, 18);
            this.dgvPlatillos.Name = "dgvPlatillos";
            this.dgvPlatillos.Size = new System.Drawing.Size(627, 663);
            this.dgvPlatillos.TabIndex = 21;
            // 
            // cbMesero
            // 
            this.cbMesero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMesero.FormattingEnabled = true;
            this.cbMesero.Location = new System.Drawing.Point(157, 22);
            this.cbMesero.Name = "cbMesero";
            this.cbMesero.Size = new System.Drawing.Size(289, 32);
            this.cbMesero.TabIndex = 28;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(24, 102);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 24);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total $:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(157, 100);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(80, 29);
            this.txtTotal.TabIndex = 32;
            this.txtTotal.Text = "0";
            // 
            // lblPagoCon
            // 
            this.lblPagoCon.AutoSize = true;
            this.lblPagoCon.BackColor = System.Drawing.Color.White;
            this.lblPagoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoCon.ForeColor = System.Drawing.Color.Black;
            this.lblPagoCon.Location = new System.Drawing.Point(23, 138);
            this.lblPagoCon.Name = "lblPagoCon";
            this.lblPagoCon.Size = new System.Drawing.Size(125, 24);
            this.lblPagoCon.TabIndex = 33;
            this.lblPagoCon.Text = "Pago Con $:";
            // 
            // txtPagoCon
            // 
            this.txtPagoCon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoCon.Location = new System.Drawing.Point(157, 135);
            this.txtPagoCon.Name = "txtPagoCon";
            this.txtPagoCon.Size = new System.Drawing.Size(80, 29);
            this.txtPagoCon.TabIndex = 34;
            this.txtPagoCon.Text = "0";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.White;
            this.lblCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.Color.Black;
            this.lblCambio.Location = new System.Drawing.Point(23, 172);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(104, 24);
            this.lblCambio.TabIndex = 35;
            this.lblCambio.Text = "Cambio $:";
            // 
            // txtCambio
            // 
            this.txtCambio.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(157, 171);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(80, 29);
            this.txtCambio.TabIndex = 36;
            this.txtCambio.Text = "0";
            // 
            // panelCobro
            // 
            this.panelCobro.BackColor = System.Drawing.Color.Transparent;
            this.panelCobro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCobro.BackgroundImage")));
            this.panelCobro.Controls.Add(this.btnVolver);
            this.panelCobro.Controls.Add(this.lblCambio);
            this.panelCobro.Controls.Add(this.btnPagar);
            this.panelCobro.Controls.Add(this.txtCambio);
            this.panelCobro.Controls.Add(this.cbMesa);
            this.panelCobro.Controls.Add(this.cbMesero);
            this.panelCobro.Controls.Add(this.lblPagoCon);
            this.panelCobro.Controls.Add(this.txtTotal);
            this.panelCobro.Controls.Add(this.lblMesas);
            this.panelCobro.Controls.Add(this.lblTotal);
            this.panelCobro.Controls.Add(this.txtPagoCon);
            this.panelCobro.Controls.Add(this.lblPrecio);
            this.panelCobro.Location = new System.Drawing.Point(17, 386);
            this.panelCobro.Name = "panelCobro";
            this.panelCobro.Size = new System.Drawing.Size(461, 295);
            this.panelCobro.TabIndex = 30;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1354, 718);
            this.Controls.Add(this.panelCobro);
            this.Controls.Add(this.pbComerciales);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.dgvPlatillos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComerciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillos)).EndInit();
            this.panelCobro.ResumeLayout(false);
            this.panelCobro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombrePlatillo;
        private System.Windows.Forms.PictureBox pbPlatillo;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblNombrePlatillo;
        private System.Windows.Forms.PictureBox pbComerciales;
        private System.Windows.Forms.ComboBox cbMesa;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvPlatillos;
        private System.Windows.Forms.ComboBox cbMesero;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblPagoCon;
        private System.Windows.Forms.TextBox txtPagoCon;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelCobro;

    }
}