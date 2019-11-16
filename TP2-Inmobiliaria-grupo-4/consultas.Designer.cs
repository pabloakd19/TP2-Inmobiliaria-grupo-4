namespace TP2_Inmobiliaria_grupo_4
{
    partial class form_consultas
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
            this.btn_cons_viviendas = new System.Windows.Forms.Button();
            this.btn_consulta1 = new System.Windows.Forms.Button();
            this.btn_consulta2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cons_viviendas
            // 
            this.btn_cons_viviendas.Location = new System.Drawing.Point(227, 230);
            this.btn_cons_viviendas.Name = "btn_cons_viviendas";
            this.btn_cons_viviendas.Size = new System.Drawing.Size(118, 23);
            this.btn_cons_viviendas.TabIndex = 0;
            this.btn_cons_viviendas.Text = "Consultar Viviendas";
            this.btn_cons_viviendas.UseVisualStyleBackColor = true;
            this.btn_cons_viviendas.Click += new System.EventHandler(this.btn_cons_viviendas_Click);
            // 
            // btn_consulta1
            // 
            this.btn_consulta1.Location = new System.Drawing.Point(248, 74);
            this.btn_consulta1.Name = "btn_consulta1";
            this.btn_consulta1.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta1.TabIndex = 1;
            this.btn_consulta1.Text = "Consulta °1";
            this.btn_consulta1.UseVisualStyleBackColor = true;
            this.btn_consulta1.Click += new System.EventHandler(this.btn_consulta1_Click);
            // 
            // btn_consulta2
            // 
            this.btn_consulta2.Location = new System.Drawing.Point(248, 118);
            this.btn_consulta2.Name = "btn_consulta2";
            this.btn_consulta2.Size = new System.Drawing.Size(75, 23);
            this.btn_consulta2.TabIndex = 2;
            this.btn_consulta2.Text = "Consulta °2";
            this.btn_consulta2.UseVisualStyleBackColor = true;
            this.btn_consulta2.Click += new System.EventHandler(this.btn_consulta2_Click);
            // 
            // form_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_consulta2);
            this.Controls.Add(this.btn_consulta1);
            this.Controls.Add(this.btn_cons_viviendas);
            this.Name = "form_consultas";
            this.RightToLeftLayout = true;
            this.Text = "Consultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cons_viviendas;
        private System.Windows.Forms.Button btn_consulta1;
        private System.Windows.Forms.Button btn_consulta2;
    }
}