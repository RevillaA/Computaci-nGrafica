namespace AreasYPerimetros
{
    partial class FrmTriangulo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbEntradas = new System.Windows.Forms.GroupBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.grbProceso = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            this.grbEntradas.SuspendLayout();
            this.grbProceso.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.txtLado);
            this.grbEntradas.Controls.Add(this.lblLado);
            this.grbEntradas.Location = new System.Drawing.Point(17, 22);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(370, 116);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(221, 48);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(81, 34);
            this.txtLado.TabIndex = 1;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(27, 51);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(188, 29);
            this.lblLado.TabIndex = 0;
            this.lblLado.Text = "Medida lado (L):";
            // 
            // grbProceso
            // 
            this.grbProceso.Controls.Add(this.btnSalir);
            this.grbProceso.Controls.Add(this.btnResetear);
            this.grbProceso.Controls.Add(this.btnCalcular);
            this.grbProceso.Location = new System.Drawing.Point(17, 154);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Size = new System.Drawing.Size(370, 126);
            this.grbProceso.TabIndex = 1;
            this.grbProceso.TabStop = false;
            this.grbProceso.Text = "Proceso";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(254, 50);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(130, 50);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(113, 40);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 50);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimetro);
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimetro);
            this.grbSalidas.Location = new System.Drawing.Point(17, 296);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Size = new System.Drawing.Size(370, 145);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(189, 94);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(106, 34);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(189, 38);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(106, 34);
            this.txtPerimetro.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(113, 95);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(69, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(57, 41);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(125, 29);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro:";
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.pcbImagen);
            this.grbImagen.Location = new System.Drawing.Point(398, 13);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(427, 428);
            this.grbImagen.TabIndex = 3;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Imagen";
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = global::AreasYPerimetros.Properties.Resources.triangulo__1__300x300;
            this.pcbImagen.Location = new System.Drawing.Point(10, 28);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(400, 400);
            this.pcbImagen.TabIndex = 0;
            this.pcbImagen.TabStop = false;
            // 
            // FrmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntradas);
            this.Name = "FrmTriangulo";
            this.Text = "Triangulo";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProceso.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.GroupBox grbProceso;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.PictureBox pcbImagen;
    }
}

