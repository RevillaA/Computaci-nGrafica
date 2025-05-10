namespace AreasYPerimetros
{
    partial class FrmCírculo
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEntradas.SuspendLayout();
            this.grbProceso.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.lblRadio);
            this.grbEntradas.Controls.Add(this.txtRadio);
            this.grbEntradas.Location = new System.Drawing.Point(12, 12);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(377, 121);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(83, 48);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(122, 29);
            this.lblRadio.TabIndex = 1;
            this.lblRadio.Text = "Radio (R):";
            // 
            // txtRadio
            // 
            this.txtRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadio.Location = new System.Drawing.Point(210, 45);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(108, 34);
            this.txtRadio.TabIndex = 0;
            // 
            // grbProceso
            // 
            this.grbProceso.Controls.Add(this.btnSalir);
            this.grbProceso.Controls.Add(this.btnResetear);
            this.grbProceso.Controls.Add(this.btnCalcular);
            this.grbProceso.Location = new System.Drawing.Point(12, 139);
            this.grbProceso.Name = "grbProceso";
            this.grbProceso.Size = new System.Drawing.Size(377, 125);
            this.grbProceso.TabIndex = 1;
            this.grbProceso.TabStop = false;
            this.grbProceso.Text = "Proceso";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(272, 49);
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
            this.btnResetear.Location = new System.Drawing.Point(135, 49);
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
            this.btnCalcular.Location = new System.Drawing.Point(13, 49);
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
            this.grbSalidas.Location = new System.Drawing.Point(12, 273);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Size = new System.Drawing.Size(377, 168);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(210, 110);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(108, 34);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(210, 50);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(108, 34);
            this.txtPerimetro.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(92, 113);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = " Área (A):";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(40, 53);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(163, 29);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perímetro (P):";
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.pictureBox1);
            this.grbImagen.Location = new System.Drawing.Point(404, 12);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(421, 425);
            this.grbImagen.TabIndex = 3;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AreasYPerimetros.Properties.Resources.circulo_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(9, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCírculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProceso);
            this.Controls.Add(this.grbEntradas);
            this.Name = "FrmCírculo";
            this.Text = "Círculo";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProceso.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.GroupBox grbProceso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
    }
}