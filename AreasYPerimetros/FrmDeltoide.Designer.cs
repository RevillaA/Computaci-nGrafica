namespace AreasYPerimetros
{
    partial class FrmDeltoide
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
            this.lblLadoGrande = new System.Windows.Forms.Label();
            this.lblLadoPequeño = new System.Windows.Forms.Label();
            this.lblDiagonalMenor = new System.Windows.Forms.Label();
            this.lblDiagonalMayor = new System.Windows.Forms.Label();
            this.txtLadoGrande = new System.Windows.Forms.TextBox();
            this.txtLadoPequeño = new System.Windows.Forms.TextBox();
            this.txtDiagonalMenor = new System.Windows.Forms.TextBox();
            this.txtDiagonalMayor = new System.Windows.Forms.TextBox();
            this.grbProcesos = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grbSalidas = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.grbImagen = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbEntradas.SuspendLayout();
            this.grbProcesos.SuspendLayout();
            this.grbSalidas.SuspendLayout();
            this.grbImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEntradas
            // 
            this.grbEntradas.Controls.Add(this.lblLadoGrande);
            this.grbEntradas.Controls.Add(this.lblLadoPequeño);
            this.grbEntradas.Controls.Add(this.lblDiagonalMenor);
            this.grbEntradas.Controls.Add(this.lblDiagonalMayor);
            this.grbEntradas.Controls.Add(this.txtLadoGrande);
            this.grbEntradas.Controls.Add(this.txtLadoPequeño);
            this.grbEntradas.Controls.Add(this.txtDiagonalMenor);
            this.grbEntradas.Controls.Add(this.txtDiagonalMayor);
            this.grbEntradas.Location = new System.Drawing.Point(12, 12);
            this.grbEntradas.Name = "grbEntradas";
            this.grbEntradas.Size = new System.Drawing.Size(371, 165);
            this.grbEntradas.TabIndex = 0;
            this.grbEntradas.TabStop = false;
            this.grbEntradas.Text = "Entradas";
            // 
            // lblLadoGrande
            // 
            this.lblLadoGrande.AutoSize = true;
            this.lblLadoGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoGrande.Location = new System.Drawing.Point(74, 129);
            this.lblLadoGrande.Name = "lblLadoGrande";
            this.lblLadoGrande.Size = new System.Drawing.Size(128, 25);
            this.lblLadoGrande.TabIndex = 7;
            this.lblLadoGrande.Text = "Lado grande:";
            // 
            // lblLadoPequeño
            // 
            this.lblLadoPequeño.AutoSize = true;
            this.lblLadoPequeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoPequeño.Location = new System.Drawing.Point(58, 95);
            this.lblLadoPequeño.Name = "lblLadoPequeño";
            this.lblLadoPequeño.Size = new System.Drawing.Size(144, 25);
            this.lblLadoPequeño.TabIndex = 6;
            this.lblLadoPequeño.Text = "Lado pequeño:";
            // 
            // lblDiagonalMenor
            // 
            this.lblDiagonalMenor.AutoSize = true;
            this.lblDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMenor.Location = new System.Drawing.Point(47, 60);
            this.lblDiagonalMenor.Name = "lblDiagonalMenor";
            this.lblDiagonalMenor.Size = new System.Drawing.Size(155, 25);
            this.lblDiagonalMenor.TabIndex = 5;
            this.lblDiagonalMenor.Text = "Diagonal menor:";
            // 
            // lblDiagonalMayor
            // 
            this.lblDiagonalMayor.AutoSize = true;
            this.lblDiagonalMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagonalMayor.Location = new System.Drawing.Point(47, 24);
            this.lblDiagonalMayor.Name = "lblDiagonalMayor";
            this.lblDiagonalMayor.Size = new System.Drawing.Size(154, 25);
            this.lblDiagonalMayor.TabIndex = 4;
            this.lblDiagonalMayor.Text = "Diagonal mayor:";
            // 
            // txtLadoGrande
            // 
            this.txtLadoGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoGrande.Location = new System.Drawing.Point(211, 127);
            this.txtLadoGrande.Name = "txtLadoGrande";
            this.txtLadoGrande.Size = new System.Drawing.Size(76, 30);
            this.txtLadoGrande.TabIndex = 3;
            // 
            // txtLadoPequeño
            // 
            this.txtLadoPequeño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLadoPequeño.Location = new System.Drawing.Point(212, 93);
            this.txtLadoPequeño.Name = "txtLadoPequeño";
            this.txtLadoPequeño.Size = new System.Drawing.Size(76, 30);
            this.txtLadoPequeño.TabIndex = 2;
            // 
            // txtDiagonalMenor
            // 
            this.txtDiagonalMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagonalMenor.Location = new System.Drawing.Point(211, 58);
            this.txtDiagonalMenor.Name = "txtDiagonalMenor";
            this.txtDiagonalMenor.Size = new System.Drawing.Size(76, 30);
            this.txtDiagonalMenor.TabIndex = 1;
            // 
            // txtDiagonalMayor
            // 
            this.txtDiagonalMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagonalMayor.Location = new System.Drawing.Point(212, 23);
            this.txtDiagonalMayor.Name = "txtDiagonalMayor";
            this.txtDiagonalMayor.Size = new System.Drawing.Size(76, 30);
            this.txtDiagonalMayor.TabIndex = 0;
            // 
            // grbProcesos
            // 
            this.grbProcesos.Controls.Add(this.btnSalir);
            this.grbProcesos.Controls.Add(this.btnResetear);
            this.grbProcesos.Controls.Add(this.btnCalcular);
            this.grbProcesos.Location = new System.Drawing.Point(12, 183);
            this.grbProcesos.Name = "grbProcesos";
            this.grbProcesos.Size = new System.Drawing.Size(371, 112);
            this.grbProcesos.TabIndex = 1;
            this.grbProcesos.TabStop = false;
            this.grbProcesos.Text = "Procesos";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(268, 41);
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
            this.btnResetear.Location = new System.Drawing.Point(136, 41);
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
            this.btnCalcular.Location = new System.Drawing.Point(15, 41);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // grbSalidas
            // 
            this.grbSalidas.Controls.Add(this.lblArea);
            this.grbSalidas.Controls.Add(this.lblPerimetro);
            this.grbSalidas.Controls.Add(this.txtArea);
            this.grbSalidas.Controls.Add(this.txtPerimetro);
            this.grbSalidas.Location = new System.Drawing.Point(12, 301);
            this.grbSalidas.Name = "grbSalidas";
            this.grbSalidas.Size = new System.Drawing.Size(371, 137);
            this.grbSalidas.TabIndex = 2;
            this.grbSalidas.TabStop = false;
            this.grbSalidas.Text = "Salidas";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(80, 84);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(106, 29);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "Area (A):";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetro.Location = new System.Drawing.Point(23, 36);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(163, 29);
            this.lblPerimetro.TabIndex = 2;
            this.lblPerimetro.Text = "Perimetro (P):";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(214, 84);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(78, 34);
            this.txtArea.TabIndex = 1;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerimetro.Location = new System.Drawing.Point(214, 33);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(78, 34);
            this.txtPerimetro.TabIndex = 0;
            // 
            // grbImagen
            // 
            this.grbImagen.Controls.Add(this.pictureBox1);
            this.grbImagen.Location = new System.Drawing.Point(389, 9);
            this.grbImagen.Name = "grbImagen";
            this.grbImagen.Size = new System.Drawing.Size(420, 429);
            this.grbImagen.TabIndex = 3;
            this.grbImagen.TabStop = false;
            this.grbImagen.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AreasYPerimetros.Properties.Resources.deltoide_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 453);
            this.Controls.Add(this.grbImagen);
            this.Controls.Add(this.grbSalidas);
            this.Controls.Add(this.grbProcesos);
            this.Controls.Add(this.grbEntradas);
            this.Name = "FrmDeltoide";
            this.Text = "Deltoide";
            this.grbEntradas.ResumeLayout(false);
            this.grbEntradas.PerformLayout();
            this.grbProcesos.ResumeLayout(false);
            this.grbSalidas.ResumeLayout(false);
            this.grbSalidas.PerformLayout();
            this.grbImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEntradas;
        private System.Windows.Forms.Label lblLadoGrande;
        private System.Windows.Forms.Label lblLadoPequeño;
        private System.Windows.Forms.Label lblDiagonalMenor;
        private System.Windows.Forms.Label lblDiagonalMayor;
        private System.Windows.Forms.TextBox txtLadoGrande;
        private System.Windows.Forms.TextBox txtLadoPequeño;
        private System.Windows.Forms.TextBox txtDiagonalMenor;
        private System.Windows.Forms.TextBox txtDiagonalMayor;
        private System.Windows.Forms.GroupBox grbProcesos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grbSalidas;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.GroupBox grbImagen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}