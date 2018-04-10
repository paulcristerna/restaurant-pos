namespace Sistema_Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblMesas = new System.Windows.Forms.Label();
            this.lblReportes = new System.Windows.Forms.Label();
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblReservaciones = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnMesas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(389, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 89);
            this.label1.TabIndex = 4;
            this.label1.Text = "Restaurant \"Cayenna\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lblAyuda);
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Controls.Add(this.lblMesas);
            this.panel1.Controls.Add(this.lblReportes);
            this.panel1.Controls.Add(this.lblEmpleados);
            this.panel1.Controls.Add(this.lblReservaciones);
            this.panel1.Controls.Add(this.lblPedidos);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.btnMesas);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnPedidos);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.btnReservaciones);
            this.panel1.Location = new System.Drawing.Point(2, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 243);
            this.panel1.TabIndex = 5;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.lblAyuda.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAyuda.Location = new System.Drawing.Point(1233, 180);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(56, 19);
            this.lblAyuda.TabIndex = 15;
            this.lblAyuda.Text = "Ayuda";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.SystemColors.Control;
            this.lblSalir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSalir.Location = new System.Drawing.Point(1085, 180);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(43, 19);
            this.lblSalir.TabIndex = 14;
            this.lblSalir.Text = "Salir";
            // 
            // lblMesas
            // 
            this.lblMesas.AutoSize = true;
            this.lblMesas.BackColor = System.Drawing.SystemColors.Control;
            this.lblMesas.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMesas.Location = new System.Drawing.Point(734, 180);
            this.lblMesas.Name = "lblMesas";
            this.lblMesas.Size = new System.Drawing.Size(56, 19);
            this.lblMesas.TabIndex = 13;
            this.lblMesas.Text = "Mesas";
            // 
            // lblReportes
            // 
            this.lblReportes.AutoSize = true;
            this.lblReportes.BackColor = System.Drawing.SystemColors.Control;
            this.lblReportes.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReportes.Location = new System.Drawing.Point(887, 180);
            this.lblReportes.Name = "lblReportes";
            this.lblReportes.Size = new System.Drawing.Size(78, 19);
            this.lblReportes.TabIndex = 12;
            this.lblReportes.Text = "Reportes";
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.BackColor = System.Drawing.SystemColors.Control;
            this.lblEmpleados.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEmpleados.Location = new System.Drawing.Point(554, 180);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(94, 19);
            this.lblEmpleados.TabIndex = 11;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblReservaciones
            // 
            this.lblReservaciones.AutoSize = true;
            this.lblReservaciones.BackColor = System.Drawing.SystemColors.Control;
            this.lblReservaciones.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblReservaciones.Location = new System.Drawing.Point(364, 180);
            this.lblReservaciones.Name = "lblReservaciones";
            this.lblReservaciones.Size = new System.Drawing.Size(118, 19);
            this.lblReservaciones.TabIndex = 10;
            this.lblReservaciones.Text = "Reservaciones";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.BackColor = System.Drawing.SystemColors.Control;
            this.lblPedidos.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPedidos.Location = new System.Drawing.Point(214, 180);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(70, 19);
            this.lblPedidos.TabIndex = 9;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lblMenu.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMenu.Location = new System.Drawing.Point(57, 180);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(53, 19);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Menu";
            // 
            // btnAyuda
            // 
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.Location = new System.Drawing.Point(1200, 49);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(128, 128);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnMesas
            // 
            this.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesas.FlatAppearance.BorderSize = 0;
            this.btnMesas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesas.Image = ((System.Drawing.Image)(resources.GetObject("btnMesas.Image")));
            this.btnMesas.Location = new System.Drawing.Point(696, 49);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Size = new System.Drawing.Size(128, 128);
            this.btnMesas.TabIndex = 5;
            this.btnMesas.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1041, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(128, 128);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.Location = new System.Drawing.Point(863, 49);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(128, 128);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.Location = new System.Drawing.Point(536, 49);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(128, 128);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.Location = new System.Drawing.Point(187, 49);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(128, 128);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(19, 49);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(128, 128);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservaciones.FlatAppearance.BorderSize = 0;
            this.btnReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnReservaciones.Image")));
            this.btnReservaciones.Location = new System.Drawing.Point(359, 49);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(128, 128);
            this.btnReservaciones.TabIndex = 2;
            this.btnReservaciones.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(475, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blvd. José Diego Valadéz Ríos 89-A Poniente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(400, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desarrollo Urbano 3 Ríos, 80027 Culiacán Rosales, Sin., México";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(1252, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Version 1.0";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHora.Location = new System.Drawing.Point(799, 514);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 39);
            this.labelHora.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 178);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 134);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1354, 704);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Restaurant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnReservaciones;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblMesas;
        private System.Windows.Forms.Label lblReportes;
        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblReservaciones;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMesas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

