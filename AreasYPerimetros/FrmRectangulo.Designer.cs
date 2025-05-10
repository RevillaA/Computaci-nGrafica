namespace AreasYPerimetros
{
    partial class FrmRectangulo
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
            this.grbEntradas = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.grbProcesos = new System.Windows.Forms.GroupBox();
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
            this.grbProcesos.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.txtAltura);
            this.grbEntradas.Controls.Add(this.txtBase);
            this.grbEntradas.Controls.Add(this.lblAltura);
            this.grbEntradas.Controls.Add(this.lblBase);
            this.grbEntradas.Location = new System.Drawing.Point(12, 7);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(370, 129);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(189, 72);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(75, 34);
            this.txtAltura.TabIndex = 3;
            // 
            // txtBase
            // 
            this.txtBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.Location = new System.Drawing.Point(189, 27);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(72, 34);
            this.txtBase.TabIndex = 2;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(68, 75);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(115, 29);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura (a):";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBase.Location = new System.Drawing.Point(72, 28);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(110, 29);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base (b):";
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnSalir);
            this.grbProcesos.Controls.Add(this.btnResetear);
            this.grbProcesos.Controls.Add(this.btnCalcular);
            this.grbProcesos.Location = new System.Drawing.Point(12, 147);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Size = new System.Drawing.Size(370, 118);
            this.grbProcesos.TabIndex = 1;
            this.grbProcesos.TabStop = false;
            this.grbProcesos.Text = "Procesos";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(272, 44);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 40);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.Location = new System.Drawing.Point(136, 44);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(123, 40);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(16, 44);
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
            this.grbSalidas.Location = new System.Drawing.Point(12, 276);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Size = new System.Drawing.Size(370, 160);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(194, 103);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(79, 34);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(193, 52);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(80, 34);
            this.txtPerimetro.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(82, 104);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(106, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area (A):";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(27, 54);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(163, 29);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro (P):";
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.pcbImagen);
            this.grbImagen.Location = new System.Drawing.Point(388, 7);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(420, 429);
            this.grbImagen.TabIndex = 3;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Imagen";
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = global::AreasYPerimetros.Properties.Resources.rectangulo_300x300;
            this.pcbImagen.Location = new System.Drawing.Point(10, 19);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(400, 400);
            this.pcbImagen.TabIndex = 0;
            this.pcbImagen.TabStop = false;
            // 
            // FrmRectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.grbEntradas);
            this.Name = "FrmRectangulo";
            this.Text = "Rectangulo";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProcesos.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
    }
}