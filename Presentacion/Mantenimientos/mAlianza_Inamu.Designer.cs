namespace Presentacion
{
    partial class mAlianza_Inamu
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
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Correo_Inamu = new System.Windows.Forms.TextBox();
            this.Cbo_Nombre_Organizacion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbo_Nombre_Cargo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Nombre_Cargo = new System.Windows.Forms.Label();
            this.Txt_Nombre_Contacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Id_Contacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Telefono = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Correo Contacto";
            // 
            // Txt_Correo_Inamu
            // 
            this.Txt_Correo_Inamu.Location = new System.Drawing.Point(124, 305);
            this.Txt_Correo_Inamu.MaxLength = 40;
            this.Txt_Correo_Inamu.Name = "Txt_Correo_Inamu";
            this.Txt_Correo_Inamu.Size = new System.Drawing.Size(252, 20);
            this.Txt_Correo_Inamu.TabIndex = 5;
            this.Txt_Correo_Inamu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Correo_Inamu_KeyPress);
            // 
            // Cbo_Nombre_Organizacion
            // 
            this.Cbo_Nombre_Organizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Nombre_Organizacion.FormattingEnabled = true;
            this.Cbo_Nombre_Organizacion.Location = new System.Drawing.Point(123, 267);
            this.Cbo_Nombre_Organizacion.Name = "Cbo_Nombre_Organizacion";
            this.Cbo_Nombre_Organizacion.Size = new System.Drawing.Size(253, 21);
            this.Cbo_Nombre_Organizacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Organización";
            // 
            // Cbo_Nombre_Cargo
            // 
            this.Cbo_Nombre_Cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Nombre_Cargo.FormattingEnabled = true;
            this.Cbo_Nombre_Cargo.Location = new System.Drawing.Point(124, 221);
            this.Cbo_Nombre_Cargo.Name = "Cbo_Nombre_Cargo";
            this.Cbo_Nombre_Cargo.Size = new System.Drawing.Size(253, 21);
            this.Cbo_Nombre_Cargo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cargo";
            // 
            // Lbl_Nombre_Cargo
            // 
            this.Lbl_Nombre_Cargo.AutoSize = true;
            this.Lbl_Nombre_Cargo.Location = new System.Drawing.Point(26, 180);
            this.Lbl_Nombre_Cargo.Name = "Lbl_Nombre_Cargo";
            this.Lbl_Nombre_Cargo.Size = new System.Drawing.Size(90, 13);
            this.Lbl_Nombre_Cargo.TabIndex = 14;
            this.Lbl_Nombre_Cargo.Text = "Nombre Contacto";
            // 
            // Txt_Nombre_Contacto
            // 
            this.Txt_Nombre_Contacto.Location = new System.Drawing.Point(124, 173);
            this.Txt_Nombre_Contacto.MaxLength = 80;
            this.Txt_Nombre_Contacto.Name = "Txt_Nombre_Contacto";
            this.Txt_Nombre_Contacto.Size = new System.Drawing.Size(253, 20);
            this.Txt_Nombre_Contacto.TabIndex = 2;
            this.Txt_Nombre_Contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Contacto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Id Contacto";
            // 
            // Txt_Id_Contacto
            // 
            this.Txt_Id_Contacto.Location = new System.Drawing.Point(123, 112);
            this.Txt_Id_Contacto.MaxLength = 3;
            this.Txt_Id_Contacto.Name = "Txt_Id_Contacto";
            this.Txt_Id_Contacto.Size = new System.Drawing.Size(70, 20);
            this.Txt_Id_Contacto.TabIndex = 1;
            this.Txt_Id_Contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Contacto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Teléfono";
            // 
            // Txt_Telefono
            // 
            this.Txt_Telefono.Location = new System.Drawing.Point(124, 350);
            this.Txt_Telefono.MaxLength = 8;
            this.Txt_Telefono.Name = "Txt_Telefono";
            this.Txt_Telefono.Size = new System.Drawing.Size(139, 20);
            this.Txt_Telefono.TabIndex = 6;
            this.Txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Teléfono_KeyPress);
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
            this.dgv.Location = new System.Drawing.Point(222, 91);
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
            this.dgv.TabIndex = 40;
            // 
            // mAlianza_Inamu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Id_Contacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Correo_Inamu);
            this.Controls.Add(this.Cbo_Nombre_Organizacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbo_Nombre_Cargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Nombre_Cargo);
            this.Controls.Add(this.Txt_Nombre_Contacto);
            this.Descripcion = "Mantenimiento de Alianza Inamu";
            this.MinimizeBox = true;
            this.Name = "mAlianza_Inamu";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Aceptar += new System.EventHandler(this.mAlianza_Inamu_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.mAlianza_Inamu_Evento_Salir);
            this.Load += new System.EventHandler(this.mAlianza_Inamu_Load);
            this.Controls.SetChildIndex(this.Txt_Nombre_Contacto, 0);
            this.Controls.SetChildIndex(this.Lbl_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Cbo_Nombre_Cargo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Cbo_Nombre_Organizacion, 0);
            this.Controls.SetChildIndex(this.Txt_Correo_Inamu, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txt_Id_Contacto, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Txt_Telefono, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Correo_Inamu;
        private System.Windows.Forms.ComboBox Cbo_Nombre_Organizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbo_Nombre_Cargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Nombre_Cargo;
        private System.Windows.Forms.TextBox Txt_Nombre_Contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Id_Contacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Telefono;
        private System.Windows.Forms.DataGridView dgv;
    }
}