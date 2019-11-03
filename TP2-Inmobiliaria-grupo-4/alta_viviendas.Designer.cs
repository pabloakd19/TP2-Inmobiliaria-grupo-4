namespace TP2_Inmobiliaria_grupo_4
{
    partial class form_alta_viviendas
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
            this.btn_agregar_viv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agregar_viv
            // 
            this.btn_agregar_viv.Location = new System.Drawing.Point(276, 70);
            this.btn_agregar_viv.Name = "btn_agregar_viv";
            this.btn_agregar_viv.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar_viv.TabIndex = 0;
            this.btn_agregar_viv.Text = "Agregar Vivienda";
            this.btn_agregar_viv.UseVisualStyleBackColor = true;
            // 
            // form_alta_viviendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 259);
            this.Controls.Add(this.btn_agregar_viv);
            this.Name = "form_alta_viviendas";
            this.Text = "Alta Viviendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agregar_viv;
    }
}

