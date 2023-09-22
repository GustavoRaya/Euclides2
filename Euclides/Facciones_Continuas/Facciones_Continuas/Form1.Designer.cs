namespace Facciones_Continuas
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
            this.Txtm = new System.Windows.Forms.TextBox();
            this.Txtn = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TbDatos = new System.Windows.Forms.DataGridView();
            this.ColumnPaso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TbDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtm
            // 
            this.Txtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtm.Location = new System.Drawing.Point(152, 66);
            this.Txtm.Name = "Txtm";
            this.Txtm.Size = new System.Drawing.Size(100, 22);
            this.Txtm.TabIndex = 1;
            // 
            // Txtn
            // 
            this.Txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtn.Location = new System.Drawing.Point(152, 127);
            this.Txtn.Name = "Txtn";
            this.Txtn.Size = new System.Drawing.Size(100, 22);
            this.Txtn.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(297, 118);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(94, 30);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TbDatos
            // 
            this.TbDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TbDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPaso,
            this.ColumnOp,
            this.ColumnEc});
            this.TbDatos.Enabled = false;
            this.TbDatos.Location = new System.Drawing.Point(97, 220);
            this.TbDatos.Name = "TbDatos";
            this.TbDatos.Size = new System.Drawing.Size(628, 192);
            this.TbDatos.TabIndex = 4;
            // 
            // ColumnPaso
            // 
            this.ColumnPaso.FillWeight = 30.45685F;
            this.ColumnPaso.HeaderText = "Paso";
            this.ColumnPaso.Name = "ColumnPaso";
            // 
            // ColumnOp
            // 
            this.ColumnOp.FillWeight = 134.7716F;
            this.ColumnOp.HeaderText = "Operacion";
            this.ColumnOp.Name = "ColumnOp";
            // 
            // ColumnEc
            // 
            this.ColumnEc.FillWeight = 134.7716F;
            this.ColumnEc.HeaderText = "Ecuacion";
            this.ColumnEc.Name = "ColumnEc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "NUMERO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "NUMERO 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "ALGORITMO DE EUCLIDES";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(493, 118);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(89, 31);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 439);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbDatos);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.Txtn);
            this.Controls.Add(this.Txtm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TbDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txtm;
        private System.Windows.Forms.TextBox Txtn;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.DataGridView TbDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPaso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}

