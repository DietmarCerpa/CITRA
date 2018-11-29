namespace Presentacion
{
    partial class mUsuarios
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
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_Nombre_Persona = new System.Windows.Forms.TextBox();
            this.Txt_Cedula = new System.Windows.Forms.TextBox();
            this.Cbo_Rol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Id_Usuario = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Contraseña";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(129, 379);
            this.Txt_Contraseña.MaxLength = 20;
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Contraseña.Size = new System.Drawing.Size(158, 20);
            this.Txt_Contraseña.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Usuario";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(130, 338);
            this.Txt_Usuario.MaxLength = 20;
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(158, 20);
            this.Txt_Usuario.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Correo";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(129, 297);
            this.Txt_Email.MaxLength = 40;
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(252, 20);
            this.Txt_Email.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Rol";
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Location = new System.Drawing.Point(33, 183);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Nombre.TabIndex = 65;
            this.Lbl_Nombre.Text = "Nombre ";
            // 
            // Txt_Nombre_Persona
            // 
            this.Txt_Nombre_Persona.Location = new System.Drawing.Point(129, 176);
            this.Txt_Nombre_Persona.MaxLength = 80;
            this.Txt_Nombre_Persona.Name = "Txt_Nombre_Persona";
            this.Txt_Nombre_Persona.Size = new System.Drawing.Size(253, 20);
            this.Txt_Nombre_Persona.TabIndex = 2;
            this.Txt_Nombre_Persona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_Persona_KeyPress);
            // 
            // Txt_Cedula
            // 
            this.Txt_Cedula.Location = new System.Drawing.Point(128, 213);
            this.Txt_Cedula.MaxLength = 20;
            this.Txt_Cedula.Name = "Txt_Cedula";
            this.Txt_Cedula.Size = new System.Drawing.Size(160, 20);
            this.Txt_Cedula.TabIndex = 3;
            this.Txt_Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cedula_KeyPress);
            // 
            // Cbo_Rol
            // 
            this.Cbo_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Rol.FormattingEnabled = true;
            this.Cbo_Rol.Location = new System.Drawing.Point(130, 258);
            this.Cbo_Rol.Name = "Cbo_Rol";
            this.Cbo_Rol.Size = new System.Drawing.Size(121, 21);
            this.Cbo_Rol.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Id Usuario";
            // 
            // Txt_Id_Usuario
            // 
            this.Txt_Id_Usuario.AcceptsReturn = true;
            this.Txt_Id_Usuario.Location = new System.Drawing.Point(129, 113);
            this.Txt_Id_Usuario.MaxLength = 3;
            this.Txt_Id_Usuario.Name = "Txt_Id_Usuario";
            this.Txt_Id_Usuario.Size = new System.Drawing.Size(70, 20);
            this.Txt_Id_Usuario.TabIndex = 1;
            this.Txt_Id_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Id_Usuario_KeyPress);
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
            this.dgv.Location = new System.Drawing.Point(229, 91);
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
            this.dgv.TabIndex = 85;
            // 
            // mUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Id_Usuario);
            this.Controls.Add(this.Cbo_Rol);
            this.Controls.Add(this.Txt_Cedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_Contraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Nombre);
            this.Controls.Add(this.Txt_Nombre_Persona);
            this.Descripcion = "Mantenimiento de Usuarios";
            this.Name = "mUsuarios";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Aceptar += new System.EventHandler(this.mUsuarios_Evento_Aceptar);
            this.Evento_Salir += new System.EventHandler(this.mUsuarios_Evento_Salir);
            this.Load += new System.EventHandler(this.mUsuarios_Load);
            this.Controls.SetChildIndex(this.Txt_Nombre_Persona, 0);
            this.Controls.SetChildIndex(this.Lbl_Nombre, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.Txt_Email, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.Txt_Usuario, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Txt_Contraseña, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.Txt_Cedula, 0);
            this.Controls.SetChildIndex(this.Cbo_Rol, 0);
            this.Controls.SetChildIndex(this.Txt_Id_Usuario, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_Nombre_Persona;
        private System.Windows.Forms.TextBox Txt_Cedula;
        private System.Windows.Forms.ComboBox Cbo_Rol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Id_Usuario;
        private System.Windows.Forms.DataGridView dgv;
    }
}