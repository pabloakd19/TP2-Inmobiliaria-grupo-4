namespace TP2_Inmobiliaria_grupo_4
{
    partial class form_alta_empresas
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
            this.dgv_empresas = new System.Windows.Forms.DataGridView();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tipo = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_fax = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_empresas
            // 
            this.dgv_empresas.AllowUserToAddRows = false;
            this.dgv_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresas.Location = new System.Drawing.Point(131, 267);
            this.dgv_empresas.Name = "dgv_empresas";
            this.dgv_empresas.Size = new System.Drawing.Size(770, 314);
            this.dgv_empresas.TabIndex = 5;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(421, 600);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 50);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar Ventana";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_tipo);
            this.groupBox1.Controls.Add(this.lbl_tipo);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.tb_fax);
            this.groupBox1.Controls.Add(this.tb_tel);
            this.groupBox1.Controls.Add(this.lbl_fax);
            this.groupBox1.Controls.Add(this.lbl_telefono);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.tb_direccion);
            this.groupBox1.Controls.Add(this.tb_Nombre);
            this.groupBox1.Controls.Add(this.lbl_direccion);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 182);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargar Nueva Empresa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_tipo
            // 
            this.tb_tipo.Location = new System.Drawing.Point(747, 84);
            this.tb_tipo.Name = "tb_tipo";
            this.tb_tipo.Size = new System.Drawing.Size(60, 22);
            this.tb_tipo.TabIndex = 12;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(693, 87);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(48, 16);
            this.lbl_tipo.TabIndex = 11;
            this.lbl_tipo.Text = "Tipo :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(391, 84);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(296, 22);
            this.tb_email.TabIndex = 10;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(240, 87);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(145, 16);
            this.lbl_email.TabIndex = 9;
            this.lbl_email.Text = "Correo Electrónico ;";
            // 
            // tb_fax
            // 
            this.tb_fax.Location = new System.Drawing.Point(99, 84);
            this.tb_fax.Name = "tb_fax";
            this.tb_fax.Size = new System.Drawing.Size(135, 22);
            this.tb_fax.TabIndex = 8;

            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(829, 34);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(135, 22);
            this.tb_tel.TabIndex = 7;

            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(52, 87);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(41, 16);
            this.lbl_fax.TabIndex = 6;
            this.lbl_fax.Text = "Fax :";

            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(753, 40);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(78, 16);
            this.lbl_telefono.TabIndex = 5;
            this.lbl_telefono.Text = "Teléfono :";

            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(863, 87);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 29);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(409, 37);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(324, 22);
            this.tb_direccion.TabIndex = 3;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(99, 37);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(201, 22);
            this.tb_Nombre.TabIndex = 2;
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(325, 40);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(82, 16);
            this.lbl_direccion.TabIndex = 1;
            this.lbl_direccion.Text = "Dirección :";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 40);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(71, 16);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Empresas";
            // 
            // form_alta_empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_empresas);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_alta_empresas";
            this.Text = "Alta Empresas";
            this.Load += new System.EventHandler(this.form_alta_empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_empresas;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox tb_fax;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}