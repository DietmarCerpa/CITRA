namespace Presentacion
{
    partial class mRblac
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cbo_Nombre_Cargo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Cargo = new System.Windows.Forms.Label();
            this.Txt_Nombre_Rblac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Extension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Id_Rblac = new System.Windows.Forms.TextBox();
            this.Cbo_Nombre_Departamento = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Departamento";
            // 
            // Cbo_Nombre_Cargo
            // 
            this.Cbo_Nombre_Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Nombre_Cargo.FormattingEnabled = true;
            this.Cbo_Nombre_Cargo.Location = new System.Drawing.Point(132, 273);
            this.Cbo_Nombre_Cargo.Name = "Cbo_Nombre_Cargo";
            this.Cbo_Nombre_Cargo.Size = new System.Drawing.Size(253, 21);
            this.Cbo_Nombre_Cargo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ubicación";
            // 
            // Txt_Ubicacion
            // 
            this.Txt_Ubicacion.Location = new System.Drawing.Point(133, 315);
            this.Txt_Ubicacion.MaxLength = 8;
            this.Txt_Ubicacion.Name = "Txt_Ubicacion";
            this.Txt_Ubicacion.Size = new System.Drawing.Size(252, 20);
            this.Txt_Ubicacion.TabIndex = 5;
            this.Txt_Ubicacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ubicacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Cargo";
            // 
            // Lbl_Nombre_Cargo
            // 
            this.Lbl_Nombre_Cargo.AutoSize = true;
            this.Lbl_Nombre_Cargo.Location = new System.Drawing.Point(35, 191);
            this.Lbl_Nombre_Cargo.Name = "Lbl_Nombre_Cargo";
            this.Lbl_Nombre_Cargo.Size = new System.Drawing.Size(90, 13);
            this.Lbl_Nombre_Cargo.TabIndex = 53;
            this.Lbl_Nombre_Cargo.Text = "Nombre Contacto";
            // 
            // Txt_Nombre_Rblac
            // 
            this.Txt_Nombre_Rblac.Location = new System.Drawing.Point(132, 188);
            this.Txt_Nombre_Rblac.MaxLength = 80;
            this.Txt_Nombre_Rblac.Name = "Txt_Nombre_Rblac";
            this.Txt_Nombre_Rblac.Size = new System.Drawing.Size(253, 20);
            this.Txt_Nombre_Rblac.TabIndex = 2;
            this.Txt_Nombre_Rblac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Rblac_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Extensión";
            // 
            // Txt_Extension
            // 
            this.Txt_Extension.Location = new System.Drawing.Point(133, 352);
            this.Txt_Extension.MaxLength = 5;
            this.Txt_Extension.Name = "Txt_Extension";
            this.Txt_Extension.Size = new System.Drawing.Size(126, 20);
            this.Txt_Extension.TabIndex = 5;
            this.Txt_Extension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Extension_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Id Contacto";
            // 
            // Txt_Id_Rblac
            // 
            this.Txt_Id_Rblac.AcceptsReturn = true;
            this.Txt_Id_Rblac.Location = new System.Drawing.Point(133, 121);
            this.Txt_Id_Rblac.MaxLength = 3;
            this.Txt_Id_Rblac.Name = "Txt_Id_Rblac";
            this.Txt_Id_Rblac.Size = new System.Drawing.Size(70, 20);
            this.Txt_Id_Rblac.TabIndex = 1;
            this.Txt_Id_Rblac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Rblac_KeyPress);
            // 
            // Cbo_Nombre_Departamento
            // 
            this.Cbo_Nombre_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Nombre_Departamento.FormattingEnabled = true;
            this.Cbo_Nombre_Departamento.Location = new System.Drawing.Point(132, 228);
            this.Cbo_Nombre_Departamento.Name = "Cbo_Nombre_Departamento";
            this.Cbo_Nombre_Departamento.Size = new System.Drawing.Size(253, 21);
            this.Cbo_Nombre_Departamento.TabIndex = 3;
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
            this.dgv.Location = new System.Drawing.Point(232, 103);
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
            this.dgv.TabIndex = 64;
            // 
            // mRblac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.Cbo_Nombre_Departamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Id_Rblac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Extension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbo_Nombre_Cargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Ubicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Nombre_Cargo);
            this.Controls.Add(this.Txt_Nombre_Rblac);
            this.Descripcion = "Mantenimiento de RBLAC";
            this.Name = "mRblac";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Aceptar += new System.EventHandler(this.mRblac_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.mRblac_Evento_Salir);
            this.Load += new System.EventHandler(this.mRblac_Load);
            this.Controls.SetChildIndex(this.Txt_Nombre_Rblac, 0);
            this.Controls.SetChildIndex(this.Lbl_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txt_Ubicacion, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Cbo_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_Extension, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Txt_Id_Rblac, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Cbo_Nombre_Departamento, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cbo_Nombre_Cargo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Ubicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Nombre_Cargo;
        private System.Windows.Forms.TextBox Txt_Nombre_Rblac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Extension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Id_Rblac;
        private System.Windows.Forms.ComboBox Cbo_Nombre_Departamento;
        private System.Windows.Forms.DataGridView dgv;
    }
}