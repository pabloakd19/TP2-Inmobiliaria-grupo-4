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
            this.btn_cons_promos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cons_viviendas
            // 
            this.btn_cons_viviendas.Location = new System.Drawing.Point(30, 170);
            this.btn_cons_viviendas.Name = "btn_cons_viviendas";
            this.btn_cons_viviendas.Size = new System.Drawing.Size(193, 23);
            this.btn_cons_viviendas.TabIndex = 0;
            this.btn_cons_viviendas.Text = "4) Viviendas x características";
            this.btn_cons_viviendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cons_viviendas.UseVisualStyleBackColor = true;
            this.btn_cons_viviendas.Click += new System.EventHandler(this.btn_cons_viviendas_Click);
            // 
            // btn_consulta1
            // 
            this.btn_consulta1.Location = new System.Drawing.Point(30, 12);
            this.btn_consulta1.Name = "btn_consulta1";
            this.btn_consulta1.Size = new System.Drawing.Size(193, 23);
            this.btn_consulta1.TabIndex = 1;
            this.btn_consulta1.Text = "1) Viviendas x Empresas";
            this.btn_consulta1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta1.UseVisualStyleBackColor = true;
            this.btn_consulta1.Click += new System.EventHandler(this.btn_consulta1_Click);
            // 
            // btn_consulta2
            // 
            this.btn_consulta2.Location = new System.Drawing.Point(30, 65);
            this.btn_consulta2.Name = "btn_consulta2";
            this.btn_consulta2.Size = new System.Drawing.Size(193, 23);
            this.btn_consulta2.TabIndex = 2;
            this.btn_consulta2.Text = "2) Viviendas y Empresas x Promoción";
            this.btn_consulta2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consulta2.UseVisualStyleBackColor = true;
            this.btn_consulta2.Click += new System.EventHandler(this.btn_consulta2_Click);
            // 
            // btn_cons_promos
            // 
            this.btn_cons_promos.Location = new System.Drawing.Point(30, 115);
            this.btn_cons_promos.Name = "btn_cons_promos";
            this.btn_cons_promos.Size = new System.Drawing.Size(193, 23);
            this.btn_cons_promos.TabIndex = 3;
            this.btn_cons_promos.Text = "3) Viviendas x Promoción";
            this.btn_cons_promos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cons_promos.UseVisualStyleBackColor = true;
            this.btn_cons_promos.Click += new System.EventHandler(this.btn_cons_promos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::TP2_Inmobiliaria_grupo_4.Properties.Resources.consultainmobi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(596, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_cons_promos);
            this.Controls.Add(this.btn_consulta2);
            this.Controls.Add(this.btn_consulta1);
            this.Controls.Add(this.btn_cons_viviendas);
            this.DoubleBuffered = true;
            this.Name = "form_consultas";
            this.RightToLeftLayout = true;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.form_consultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cons_viviendas;
        private System.Windows.Forms.Button btn_consulta1;
        private System.Windows.Forms.Button btn_consulta2;
        private System.Windows.Forms.Button btn_cons_promos;
        private System.Windows.Forms.Button button1;
    }
}