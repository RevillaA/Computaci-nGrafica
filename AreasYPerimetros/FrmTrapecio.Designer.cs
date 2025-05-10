namespace AreasYPerimetros
{
    partial class FrmTrapecio
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
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtBaseMenor = new System.Windows.Forms.TextBox();
            this.txtBaseMayor = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblBaseMenor = new System.Windows.Forms.Label();
            this.lblBaseMayor = new System.Windows.Forms.Label();
            this.grbProcesos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.grbImagenes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEntradas.SuspendLayout();
            this.grbProcesos.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbImagenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.txtLado);
            this.grbEntradas.Controls.Add(this.txtAltura);
            this.grbEntradas.Controls.Add(this.txtBaseMenor);
            this.grbEntradas.Controls.Add(this.txtBaseMayor);
            this.grbEntradas.Controls.Add(this.lblLado);
            this.grbEntradas.Controls.Add(this.lblAltura);
            this.grbEntradas.Controls.Add(this.lblBaseMenor);
            this.grbEntradas.Controls.Add(this.lblBaseMayor);
            this.grbEntradas.Location = new System.Drawing.Point(8, 15);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(372, 179);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // txtLado
            // 
            this.txtLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLado.Location = new System.Drawing.Point(218, 142);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(73, 30);
            this.txtLado.TabIndex = 7;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(218, 100);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(73, 30);
            this.txtAltura.TabIndex = 6;
            // 
            // txtBaseMenor
            // 
            this.txtBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseMenor.Location = new System.Drawing.Point(218, 62);
            this.txtBaseMenor.Name = "txtBaseMenor";
            this.txtBaseMenor.Size = new System.Drawing.Size(73, 30);
            this.txtBaseMenor.TabIndex = 5;
            // 
            // txtBaseMayor
            // 
            this.txtBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseMayor.Location = new System.Drawing.Point(218, 21);
            this.txtBaseMayor.Name = "txtBaseMayor";
            this.txtBaseMayor.Size = new System.Drawing.Size(73, 30);
            this.txtBaseMayor.TabIndex = 4;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLado.Location = new System.Drawing.Point(126, 146);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(85, 25);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado (l):";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(116, 103);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(99, 25);
            this.lblAltura.TabIndex = 2;
            this.lblAltura.Text = "Altura (h):";
            // 
            // lblBaseMenor
            // 
            this.lblBaseMenor.AutoSize = true;
            this.lblBaseMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMenor.Location = new System.Drawing.Point(56, 64);
            this.lblBaseMenor.Name = "lblBaseMenor";
            this.lblBaseMenor.Size = new System.Drawing.Size(159, 25);
            this.lblBaseMenor.TabIndex = 1;
            this.lblBaseMenor.Text = "Base Menor (m):";
            // 
            // lblBaseMayor
            // 
            this.lblBaseMayor.AutoSize = true;
            this.lblBaseMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseMayor.Location = new System.Drawing.Point(56, 25);
            this.lblBaseMayor.Name = "lblBaseMayor";
            this.lblBaseMayor.Size = new System.Drawing.Size(155, 25);
            this.lblBaseMayor.TabIndex = 0;
            this.lblBaseMayor.Text = "Base Mayor (B):";
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnSalir);
            this.grbProcesos.Controls.Add(this.btnResetear);
            this.grbProcesos.Controls.Add(this.btnCalcular);
            this.grbProcesos.Location = new System.Drawing.Point(11, 200);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Size = new System.Drawing.Size(369, 97);
            this.grbProcesos.TabIndex = 1;
            this.grbProcesos.TabStop = false;
            this.grbProcesos.Text = "Procesos";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(266, 33);
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
            this.btnResetear.Location = new System.Drawing.Point(133, 33);
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
            this.btnCalcular.Location = new System.Drawing.Point(16, 34);
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
            this.grbSalidas.Location = new System.Drawing.Point(12, 310);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Size = new System.Drawing.Size(368, 123);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(211, 77);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(88, 34);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(211, 31);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(88, 34);
            this.txtPerimetro.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(99, 80);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(106, 29);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area (A):";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(42, 34);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(163, 29);
            this.lblPerimetro.TabIndex = 0;
            this.lblPerimetro.Text = "Perimetro (P):";
            // 
            // grbImagenes
            // 
            this.grbImagenes.Controls.Add(this.pictureBox1);
            this.grbImagenes.Location = new System.Drawing.Point(386, 8);
            this.grbImagenes.Name = "grbImagenes";
            this.grbImagenes.Size = new System.Drawing.Size(420, 429);
            this.grbImagenes.TabIndex = 3;
            this.grbImagenes.TabStop = false;
            this.grbImagenes.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AreasYPerimetros.Properties.Resources.Trapezoid_300x220;
            this.pictureBox1.Location = new System.Drawing.Point(11, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTrapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.grbImagenes);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.grbEntradas);
            this.Name = "FrmTrapecio";
            this.Text = "Trapecio";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProcesos.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbImagenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtBaseMenor;
        private System.Windows.Forms.TextBox txtBaseMayor;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblBaseMenor;
        private System.Windows.Forms.Label lblBaseMayor;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.GroupBox grbImagenes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}