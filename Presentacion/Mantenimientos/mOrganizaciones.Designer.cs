namespace Presentacion

{
    partial class mOrganizaciones
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
            this.Txt_Nombre_Organizacion = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_Cargo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Id_Organizacion = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_Nombre_Organizacion
            // 
            this.Txt_Nombre_Organizacion.Location = new System.Drawing.Point(131, 188);
            this.Txt_Nombre_Organizacion.Name = "Txt_Nombre_Organizacion";
            this.Txt_Nombre_Organizacion.Size = new System.Drawing.Size(237, 20);
            this.Txt_Nombre_Organizacion.TabIndex = 19;
            this.Txt_Nombre_Organizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Organizacion_KeyPress);
            // 
            // Lbl_Nombre_Cargo
            // 
            this.Lbl_Nombre_Cargo.AutoSize = true;
            this.Lbl_Nombre_Cargo.Location = new System.Drawing.Point(12, 191);
            this.Lbl_Nombre_Cargo.Name = "Lbl_Nombre_Cargo";
            this.Lbl_Nombre_Cargo.Size = new System.Drawing.Size(109, 13);
            this.Lbl_Nombre_Cargo.TabIndex = 18;
            this.Lbl_Nombre_Cargo.Text = "Nombre Organización";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Id Organización";
            // 
            // Txt_Id_Organizacion
            // 
            this.Txt_Id_Organizacion.Location = new System.Drawing.Point(131, 123);
            this.Txt_Id_Organizacion.Name = "Txt_Id_Organizacion";
            this.Txt_Id_Organizacion.Size = new System.Drawing.Size(70, 20);
            this.Txt_Id_Organizacion.TabIndex = 56;
            this.Txt_Id_Organizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Organizacion_KeyPress);
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
            this.dgv.Location = new System.Drawing.Point(215, 102);
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
            this.dgv.TabIndex = 58;
            // 
            // mOrganizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Id_Organizacion);
            this.Controls.Add(this.Txt_Nombre_Organizacion);
            this.Controls.Add(this.Lbl_Nombre_Cargo);
            this.Descripcion = "Mantenimiento de Organizaciones";
            this.Name = "mOrganizaciones";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Aceptar += new System.EventHandler(this.mOrganizaciones_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.mOrganizaciones_Evento_Salir);
            this.Load += new System.EventHandler(this.mOrganizaciones_Load);
            this.Controls.SetChildIndex(this.Lbl_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.Txt_Nombre_Organizacion, 0);
            this.Controls.SetChildIndex(this.Txt_Id_Organizacion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nombre_Organizacion;
        private System.Windows.Forms.Label Lbl_Nombre_Cargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Id_Organizacion;
        private System.Windows.Forms.DataGridView dgv;
    }
}