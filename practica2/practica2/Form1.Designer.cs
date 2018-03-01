namespace practica2
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
            this.cmdAbrir = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.ofld = new System.Windows.Forms.OpenFileDialog();
            this.sfld = new System.Windows.Forms.SaveFileDialog();
            this.cmdXL3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.AutoSize = true;
            this.cmdAbrir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbrir.Location = new System.Drawing.Point(404, 99);
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.Size = new System.Drawing.Size(93, 26);
            this.cmdAbrir.TabIndex = 0;
            this.cmdAbrir.Text = "Abrir archivo";
            this.cmdAbrir.UseVisualStyleBackColor = true;
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(96, 24);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(260, 156);
            this.txtMostrar.TabIndex = 1;
            // 
            // ofld
            // 
            this.ofld.FileName = "openFileDialog1";
            // 
            // cmdXL3
            // 
            this.cmdXL3.AutoSize = true;
            this.cmdXL3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cmdXL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXL3.Location = new System.Drawing.Point(417, 154);
            this.cmdXL3.Name = "cmdXL3";
            this.cmdXL3.Size = new System.Drawing.Size(80, 26);
            this.cmdXL3.TabIndex = 2;
            this.cmdXL3.Text = "Crear XML";
            this.cmdXL3.UseVisualStyleBackColor = true;
            this.cmdXL3.Click += new System.EventHandler(this.cmdXL3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 410);
            this.Controls.Add(this.cmdXL3);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.cmdAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAbrir;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.OpenFileDialog ofld;
        private System.Windows.Forms.SaveFileDialog sfld;
        private System.Windows.Forms.Button cmdXL3;
    }
}

