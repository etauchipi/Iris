namespace Iris
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblActivodesde = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEnviados = new System.Windows.Forms.Label();
            this.lblProcesados = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRechazados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEncuesta1 = new System.Windows.Forms.Label();
            this.lblEncuesta2 = new System.Windows.Forms.Label();
            this.lblEncuesta3 = new System.Windows.Forms.Label();
            this.lblEncuesta4 = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monitoreo integración";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblActivodesde
            // 
            this.lblActivodesde.AutoSize = true;
            this.lblActivodesde.Location = new System.Drawing.Point(26, 342);
            this.lblActivodesde.Name = "lblActivodesde";
            this.lblActivodesde.Size = new System.Drawing.Size(75, 13);
            this.lblActivodesde.TabIndex = 2;
            this.lblActivodesde.Text = "Activo desde: ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Iris.Properties.Resources.double_arrow;
            this.pictureBox3.Location = new System.Drawing.Point(212, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(330, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Iris.Properties.Resources.opitat_logo1;
            this.pictureBox2.Location = new System.Drawing.Point(555, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Iris.Properties.Resources.CDLM_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(28, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enviados:";
            // 
            // lblEnviados
            // 
            this.lblEnviados.AutoSize = true;
            this.lblEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnviados.ForeColor = System.Drawing.Color.Navy;
            this.lblEnviados.Location = new System.Drawing.Point(118, 151);
            this.lblEnviados.Name = "lblEnviados";
            this.lblEnviados.Size = new System.Drawing.Size(21, 24);
            this.lblEnviados.TabIndex = 6;
            this.lblEnviados.Text = "0";
            // 
            // lblProcesados
            // 
            this.lblProcesados.AutoSize = true;
            this.lblProcesados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesados.ForeColor = System.Drawing.Color.Navy;
            this.lblProcesados.Location = new System.Drawing.Point(297, 151);
            this.lblProcesados.Name = "lblProcesados";
            this.lblProcesados.Size = new System.Drawing.Size(21, 24);
            this.lblProcesados.TabIndex = 8;
            this.lblProcesados.Text = "0";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label4.Location = new System.Drawing.Point(183, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(108, 20);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Procesados:";
            // 
            // lblOk
            // 
            this.lblOk.AutoSize = true;
            this.lblOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOk.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOk.Location = new System.Drawing.Point(430, 151);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(21, 24);
            this.lblOk.TabIndex = 10;
            this.lblOk.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(382, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ok:";
            // 
            // lblRechazados
            // 
            this.lblRechazados.AutoSize = true;
            this.lblRechazados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechazados.ForeColor = System.Drawing.Color.Crimson;
            this.lblRechazados.Location = new System.Drawing.Point(653, 151);
            this.lblRechazados.Name = "lblRechazados";
            this.lblRechazados.Size = new System.Drawing.Size(21, 24);
            this.lblRechazados.TabIndex = 12;
            this.lblRechazados.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(527, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rechazados:";
            // 
            // lblEncuesta1
            // 
            this.lblEncuesta1.AutoSize = true;
            this.lblEncuesta1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncuesta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuesta1.Location = new System.Drawing.Point(82, 188);
            this.lblEncuesta1.Name = "lblEncuesta1";
            this.lblEncuesta1.Size = new System.Drawing.Size(21, 22);
            this.lblEncuesta1.TabIndex = 13;
            this.lblEncuesta1.Text = "--";
            // 
            // lblEncuesta2
            // 
            this.lblEncuesta2.AutoSize = true;
            this.lblEncuesta2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncuesta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuesta2.Location = new System.Drawing.Point(82, 224);
            this.lblEncuesta2.Name = "lblEncuesta2";
            this.lblEncuesta2.Size = new System.Drawing.Size(21, 22);
            this.lblEncuesta2.TabIndex = 14;
            this.lblEncuesta2.Text = "--";
            // 
            // lblEncuesta3
            // 
            this.lblEncuesta3.AutoSize = true;
            this.lblEncuesta3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncuesta3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuesta3.Location = new System.Drawing.Point(82, 264);
            this.lblEncuesta3.Name = "lblEncuesta3";
            this.lblEncuesta3.Size = new System.Drawing.Size(21, 22);
            this.lblEncuesta3.TabIndex = 15;
            this.lblEncuesta3.Text = "--";
            // 
            // lblEncuesta4
            // 
            this.lblEncuesta4.AutoSize = true;
            this.lblEncuesta4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEncuesta4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncuesta4.Location = new System.Drawing.Point(82, 306);
            this.lblEncuesta4.Name = "lblEncuesta4";
            this.lblEncuesta4.Size = new System.Drawing.Size(21, 22);
            this.lblEncuesta4.TabIndex = 16;
            this.lblEncuesta4.Text = "--";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Prueba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEncuesta4);
            this.Controls.Add(this.lblEncuesta3);
            this.Controls.Add(this.lblEncuesta2);
            this.Controls.Add(this.lblEncuesta1);
            this.Controls.Add(this.lblRechazados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProcesados);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblEnviados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblActivodesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblActivodesde;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEnviados;
        private System.Windows.Forms.Label lblProcesados;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRechazados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEncuesta1;
        private System.Windows.Forms.Label lblEncuesta2;
        private System.Windows.Forms.Label lblEncuesta3;
        private System.Windows.Forms.Label lblEncuesta4;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button button1;
    }
}

