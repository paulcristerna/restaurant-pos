namespace Sistema_Restaurant
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.dgvPlatillos = new System.Windows.Forms.DataGridView();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pbComerciales = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblNombrePlatillo = new System.Windows.Forms.Label();
            this.pbPlatillo = new System.Windows.Forms.PictureBox();
            this.txtNombrePlatillo = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bntActualizar = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComerciales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).BeginInit();
            this.panelOpciones.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlatillos
            // 
            this.dgvPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatillos.Location = new System.Drawing.Point(496, 85);
            this.dgvPlatillos.Name = "dgvPlatillos";
            this.dgvPlatillos.Size = new System.Drawing.Size(619, 584);
            this.dgvPlatillos.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 310);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(127, 24);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(187, 363);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(277, 29);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(42, 366);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(76, 24);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.BackColor = System.Drawing.Color.White;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.ForeColor = System.Drawing.Color.Black;
            this.lblClasificacion.Location = new System.Drawing.Point(41, 418);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(133, 24);
            this.lblClasificacion.TabIndex = 8;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Items.AddRange(new object[] {
            "DESAYUNO",
            "COMIDA",
            "CENA",
            "POSTRE"});
            this.cbClasificacion.Location = new System.Drawing.Point(187, 415);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(277, 32);
            this.cbClasificacion.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(187, 310);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(277, 29);
            this.txtDescripcion.TabIndex = 5;
            // 
            // pbComerciales
            // 
            this.pbComerciales.BackColor = System.Drawing.Color.Transparent;
            this.pbComerciales.Image = ((System.Drawing.Image)(resources.GetObject("pbComerciales.Image")));
            this.pbComerciales.Location = new System.Drawing.Point(1131, 18);
            this.pbComerciales.Name = "pbComerciales";
            this.pbComerciales.Size = new System.Drawing.Size(199, 651);
            this.pbComerciales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComerciales.TabIndex = 15;
            this.pbComerciales.TabStop = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(373, 452);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 78);
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
            this.btnVolver.Location = new System.Drawing.Point(27, 452);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 78);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            // pbPlatillo
            // 
            this.pbPlatillo.Image = ((System.Drawing.Image)(resources.GetObject("pbPlatillo.Image")));
            this.pbPlatillo.Location = new System.Drawing.Point(96, 16);
            this.pbPlatillo.Name = "pbPlatillo";
            this.pbPlatillo.Size = new System.Drawing.Size(282, 210);
            this.pbPlatillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlatillo.TabIndex = 10;
            this.pbPlatillo.TabStop = false;
            // 
            // txtNombrePlatillo
            // 
            this.txtNombrePlatillo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePlatillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePlatillo.Location = new System.Drawing.Point(169, 245);
            this.txtNombrePlatillo.Name = "txtNombrePlatillo";
            this.txtNombrePlatillo.Size = new System.Drawing.Size(277, 29);
            this.txtNombrePlatillo.TabIndex = 3;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(98, 16);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(508, 29);
            this.txtBuscar.TabIndex = 12;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.White;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(12, 19);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(80, 24);
            this.lblBuscar.TabIndex = 13;
            this.lblBuscar.Text = "Buscar:";
            // 
            // panelOpciones
            // 
            this.panelOpciones.BackColor = System.Drawing.Color.Transparent;
            this.panelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelOpciones.BackgroundImage")));
            this.panelOpciones.Controls.Add(this.btnEliminar);
            this.panelOpciones.Controls.Add(this.btnVolver);
            this.panelOpciones.Controls.Add(this.txtNombrePlatillo);
            this.panelOpciones.Controls.Add(this.pbPlatillo);
            this.panelOpciones.Controls.Add(this.btnGuardar);
            this.panelOpciones.Controls.Add(this.bntActualizar);
            this.panelOpciones.Controls.Add(this.lblNombrePlatillo);
            this.panelOpciones.Location = new System.Drawing.Point(18, 17);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(461, 547);
            this.panelOpciones.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(133, 452);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 78);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // bntActualizar
            // 
            this.bntActualizar.BackColor = System.Drawing.Color.Transparent;
            this.bntActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntActualizar.FlatAppearance.BorderSize = 0;
            this.bntActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntActualizar.Image = ((System.Drawing.Image)(resources.GetObject("bntActualizar.Image")));
            this.bntActualizar.Location = new System.Drawing.Point(250, 452);
            this.bntActualizar.Name = "bntActualizar";
            this.bntActualizar.Size = new System.Drawing.Size(73, 78);
            this.bntActualizar.TabIndex = 17;
            this.bntActualizar.UseVisualStyleBackColor = false;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.Color.Transparent;
            this.panelBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscar.BackgroundImage")));
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.lblBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(496, 17);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(619, 57);
            this.panelBuscar.TabIndex = 20;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1354, 718);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.pbComerciales);
            this.Controls.Add(this.cbClasificacion);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dgvPlatillos);
            this.Controls.Add(this.panelOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatillos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComerciales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlatillo)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlatillos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pbComerciales;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblNombrePlatillo;
        private System.Windows.Forms.PictureBox pbPlatillo;
        private System.Windows.Forms.TextBox txtNombrePlatillo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button bntActualizar;
    }
}