namespace Presentacion
{
    partial class mPaises
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_Nombre_Cargo = new System.Windows.Forms.Label();
            this.Txt_Nombre_Pais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Id_Pais = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Nombre_Cargo
            // 
            this.Lbl_Nombre_Cargo.AutoSize = true;
            this.Lbl_Nombre_Cargo.Location = new System.Drawing.Point(38, 192);
            this.Lbl_Nombre_Cargo.Name = "Lbl_Nombre_Cargo";
            this.Lbl_Nombre_Cargo.Size = new System.Drawing.Size(69, 13);
            this.Lbl_Nombre_Cargo.TabIndex = 16;
            this.Lbl_Nombre_Cargo.Text = "Nombre País";
            // 
            // Txt_Nombre_Pais
            // 
            this.Txt_Nombre_Pais.Location = new System.Drawing.Point(123, 189);
            this.Txt_Nombre_Pais.MaxLength = 80;
            this.Txt_Nombre_Pais.Name = "Txt_Nombre_Pais";
            this.Txt_Nombre_Pais.Size = new System.Drawing.Size(237, 20);
            this.Txt_Nombre_Pais.TabIndex = 2;
            this.Txt_Nombre_Pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Pais_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id País";
            // 
            // Txt_Id_Pais
            // 
            this.Txt_Id_Pais.AcceptsReturn = true;
            this.Txt_Id_Pais.Location = new System.Drawing.Point(123, 111);
            this.Txt_Id_Pais.MaxLength = 3;
            this.Txt_Id_Pais.Name = "Txt_Id_Pais";
            this.Txt_Id_Pais.Size = new System.Drawing.Size(70, 20);
            this.Txt_Id_Pais.TabIndex = 1;
            this.Txt_Id_Pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Pais_KeyPress);
            // 
            // dgv
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 20;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv.Location = new System.Drawing.Point(207, 91);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 20;
            this.dgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(153, 65);
            this.dgv.TabIndex = 41;
            // 
            // mPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Id_Pais);
            this.Controls.Add(this.Txt_Nombre_Pais);
            this.Controls.Add(this.Lbl_Nombre_Cargo);
            this.Descripcion = "Mantenimiento de Países";
            this.Name = "mPaises";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Aceptar += new System.EventHandler(this.mPaises_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.mPaises_Evento_Salir);
            this.Load += new System.EventHandler(this.mPaises_Load);
            this.Controls.SetChildIndex(this.Lbl_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.Txt_Nombre_Pais, 0);
            this.Controls.SetChildIndex(this.Txt_Id_Pais, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nombre_Cargo;
        private System.Windows.Forms.TextBox Txt_Nombre_Pais;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Txt_Id_Pais;
        private System.Windows.Forms.DataGridView dgv;
    }
}