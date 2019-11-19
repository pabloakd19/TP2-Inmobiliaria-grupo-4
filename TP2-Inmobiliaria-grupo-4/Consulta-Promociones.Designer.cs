namespace TP2_Inmobiliaria_grupo_4
{
    partial class Consulta_Promociones
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_promoid = new System.Windows.Forms.TextBox();
            this.btn_consulta3 = new System.Windows.Forms.Button();
            this.dataGrid_cons_prom = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cons_prom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese el código de la Promoción: ";
            // 
            // txt_promoid
            // 
            this.txt_promoid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txt_promoid.Location = new System.Drawing.Point(440, 21);
            this.txt_promoid.Name = "txt_promoid";
            this.txt_promoid.Size = new System.Drawing.Size(135, 31);
            this.txt_promoid.TabIndex = 11;
            // 
            // btn_consulta3
            // 
            this.btn_consulta3.Location = new System.Drawing.Point(221, 74);
            this.btn_consulta3.Name = "btn_consulta3";
            this.btn_consulta3.Size = new System.Drawing.Size(262, 34);
            this.btn_consulta3.TabIndex = 12;
            this.btn_consulta3.Text = "Consultar Promoción";
            this.btn_consulta3.UseVisualStyleBackColor = true;
            this.btn_consulta3.Click += new System.EventHandler(this.btn_consulta3_Click);
            // 
            // dataGrid_cons_prom
            // 
            this.dataGrid_cons_prom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_cons_prom.Location = new System.Drawing.Point(12, 114);
            this.dataGrid_cons_prom.Name = "dataGrid_cons_prom";
            this.dataGrid_cons_prom.Size = new System.Drawing.Size(816, 286);
            this.dataGrid_cons_prom.TabIndex = 13;
            // 
            // Consulta_Promociones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 412);
            this.Controls.Add(this.dataGrid_cons_prom);
            this.Controls.Add(this.btn_consulta3);
            this.Controls.Add(this.txt_promoid);
            this.Controls.Add(this.label1);
            this.Name = "Consulta_Promociones";
            this.Text = "Consulta Promociones";
            this.Load += new System.EventHandler(this.Consulta_Promociones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_cons_prom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_promoid;
        private System.Windows.Forms.Button btn_consulta3;
        private System.Windows.Forms.DataGridView dataGrid_cons_prom;
    }
}