namespace TP2_Inmobiliaria_grupo_4
{
    partial class form_menu
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
            this.btn_alta_viviendas = new System.Windows.Forms.Button();
            this.btn_alta_empresas = new System.Windows.Forms.Button();
            this.btn_alta_promociones = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_aboutus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_alta_viviendas
            // 
            this.btn_alta_viviendas.Location = new System.Drawing.Point(213, 36);
            this.btn_alta_viviendas.Name = "btn_alta_viviendas";
            this.btn_alta_viviendas.Size = new System.Drawing.Size(121, 38);
            this.btn_alta_viviendas.TabIndex = 0;
            this.btn_alta_viviendas.Text = "Alta Viviendas";
            this.btn_alta_viviendas.UseVisualStyleBackColor = true;
            this.btn_alta_viviendas.Click += new System.EventHandler(this.btn_alta_viviendas_Click);
            // 
            // btn_alta_empresas
            // 
            this.btn_alta_empresas.Location = new System.Drawing.Point(213, 80);
            this.btn_alta_empresas.Name = "btn_alta_empresas";
            this.btn_alta_empresas.Size = new System.Drawing.Size(121, 38);
            this.btn_alta_empresas.TabIndex = 1;
            this.btn_alta_empresas.Text = "Alta Empresas";
            this.btn_alta_empresas.UseVisualStyleBackColor = true;
            // 
            // btn_alta_promociones
            // 
            this.btn_alta_promociones.Location = new System.Drawing.Point(213, 124);
            this.btn_alta_promociones.Name = "btn_alta_promociones";
            this.btn_alta_promociones.Size = new System.Drawing.Size(121, 38);
            this.btn_alta_promociones.TabIndex = 2;
            this.btn_alta_promociones.Text = "Alta Promociones";
            this.btn_alta_promociones.UseVisualStyleBackColor = true;
            // 
            // btn_consultas
            // 
            this.btn_consultas.Location = new System.Drawing.Point(213, 168);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(121, 38);
            this.btn_consultas.TabIndex = 3;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(213, 263);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 38);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir del Sistema";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_aboutus
            // 
            this.btn_aboutus.Location = new System.Drawing.Point(1036, 328);
            this.btn_aboutus.Name = "btn_aboutus";
            this.btn_aboutus.Size = new System.Drawing.Size(112, 41);
            this.btn_aboutus.TabIndex = 6;
            this.btn_aboutus.Text = "Desarrollado por ...";
            this.btn_aboutus.UseVisualStyleBackColor = true;
            this.btn_aboutus.Click += new System.EventHandler(this.btn_aboutus_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP2_Inmobiliaria_grupo_4.Properties.Resources._2019_11_14_1821;
            this.ClientSize = new System.Drawing.Size(1179, 392);
            this.Controls.Add(this.btn_aboutus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_alta_promociones);
            this.Controls.Add(this.btn_alta_empresas);
            this.Controls.Add(this.btn_alta_viviendas);
            this.Name = "form_menu";
            this.Text = "Inmobiliaria GITHUB";
            this.Load += new System.EventHandler(this.form_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_alta_viviendas;
        private System.Windows.Forms.Button btn_alta_empresas;
        private System.Windows.Forms.Button btn_alta_promociones;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_aboutus;
    }
}