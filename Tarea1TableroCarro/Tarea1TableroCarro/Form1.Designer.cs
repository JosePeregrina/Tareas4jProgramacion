namespace Tarea1TableroCarro
{
    partial class Form1
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
            this.cmdAccion = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.txtNuevaFecha = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pbSensor1 = new System.Windows.Forms.PictureBox();
            this.pbSensor2 = new System.Windows.Forms.PictureBox();
            this.pbTanque = new System.Windows.Forms.PictureBox();
            this.pbBrujula = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmdCambiarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTanque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrujula)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAccion
            // 
            this.cmdAccion.Location = new System.Drawing.Point(201, 33);
            this.cmdAccion.Name = "cmdAccion";
            this.cmdAccion.Size = new System.Drawing.Size(75, 23);
            this.cmdAccion.TabIndex = 1;
            this.cmdAccion.Text = "Acción";
            this.cmdAccion.UseVisualStyleBackColor = true;
            this.cmdAccion.Click += new System.EventHandler(this.cmdAccion_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(47, 36);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(115, 20);
            this.txtdato.TabIndex = 3;
            // 
            // txtNuevaFecha
            // 
            this.txtNuevaFecha.Location = new System.Drawing.Point(81, 439);
            this.txtNuevaFecha.Name = "txtNuevaFecha";
            this.txtNuevaFecha.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaFecha.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(47, 337);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // pbSensor1
            // 
            this.pbSensor1.Location = new System.Drawing.Point(12, 92);
            this.pbSensor1.Name = "pbSensor1";
            this.pbSensor1.Size = new System.Drawing.Size(131, 141);
            this.pbSensor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSensor1.TabIndex = 2;
            this.pbSensor1.TabStop = false;
            // 
            // pbSensor2
            // 
            this.pbSensor2.Location = new System.Drawing.Point(190, 92);
            this.pbSensor2.Name = "pbSensor2";
            this.pbSensor2.Size = new System.Drawing.Size(131, 141);
            this.pbSensor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSensor2.TabIndex = 2;
            this.pbSensor2.TabStop = false;
            // 
            // pbTanque
            // 
            this.pbTanque.Location = new System.Drawing.Point(368, 92);
            this.pbTanque.Name = "pbTanque";
            this.pbTanque.Size = new System.Drawing.Size(131, 141);
            this.pbTanque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTanque.TabIndex = 2;
            this.pbTanque.TabStop = false;
            // 
            // pbBrujula
            // 
            this.pbBrujula.Location = new System.Drawing.Point(543, 92);
            this.pbBrujula.Name = "pbBrujula";
            this.pbBrujula.Size = new System.Drawing.Size(168, 141);
            this.pbBrujula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBrujula.TabIndex = 0;
            this.pbBrujula.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(733, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "_________________________________________________________________________________" +
    "______________________-";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(285, 277);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 9;
            // 
            // cmdCambiarFecha
            // 
            this.cmdCambiarFecha.AutoSize = true;
            this.cmdCambiarFecha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdCambiarFecha.Location = new System.Drawing.Point(99, 390);
            this.cmdCambiarFecha.Name = "cmdCambiarFecha";
            this.cmdCambiarFecha.Size = new System.Drawing.Size(82, 23);
            this.cmdCambiarFecha.TabIndex = 10;
            this.cmdCambiarFecha.Text = "Ajustar Fecha";
            this.cmdCambiarFecha.UseVisualStyleBackColor = true;
            this.cmdCambiarFecha.Click += new System.EventHandler(this.cmdCambiarFecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 532);
            this.Controls.Add(this.cmdCambiarFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNuevaFecha);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.pbSensor1);
            this.Controls.Add(this.pbSensor2);
            this.Controls.Add(this.pbTanque);
            this.Controls.Add(this.cmdAccion);
            this.Controls.Add(this.pbBrujula);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTanque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBrujula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBrujula;
        private System.Windows.Forms.Button cmdAccion;
        private System.Windows.Forms.PictureBox pbTanque;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.PictureBox pbSensor2;
        private System.Windows.Forms.PictureBox pbSensor1;
        private System.Windows.Forms.TextBox txtNuevaFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button cmdCambiarFecha;
    }
}

