namespace AlumnProfe
{
    partial class FormInicio
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
            this.BtnComenzar = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BtnComenzar.Location = new System.Drawing.Point(12, 12);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(143, 40);
            this.BtnComenzar.TabIndex = 0;
            this.BtnComenzar.Text = "Iniciar";
            this.BtnComenzar.UseVisualStyleBackColor = true;
            this.BtnComenzar.Click += new System.EventHandler(this.FrmAluProf_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 297);
            this.Controls.Add(this.BtnComenzar);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnComenzar;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

