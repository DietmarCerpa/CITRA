namespace Presentacion
{
    partial class F_Organizaciones
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
            this.lstDatos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.LinkLabel();
            this.lbiduser = new System.Windows.Forms.LinkLabel();
            this.lbidrol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDatos.GridLines = true;
            this.lstDatos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDatos.Location = new System.Drawing.Point(0, 88);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(619, 661);
            this.lstDatos.TabIndex = 11;
            this.lstDatos.UseCompatibleStateImageBehavior = false;
            this.lstDatos.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario";
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(467, 66);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(57, 20);
            this.lb_usuario.TabIndex = 13;
            this.lb_usuario.TabStop = true;
            this.lb_usuario.Text = "--------";
            // 
            // lbiduser
            // 
            this.lbiduser.AutoSize = true;
            this.lbiduser.Location = new System.Drawing.Point(530, 66);
            this.lbiduser.Name = "lbiduser";
            this.lbiduser.Size = new System.Drawing.Size(35, 13);
            this.lbiduser.TabIndex = 14;
            this.lbiduser.TabStop = true;
            this.lbiduser.Text = "iduser";
            this.lbiduser.Visible = false;
            // 
            // lbidrol
            // 
            this.lbidrol.AutoSize = true;
            this.lbidrol.Location = new System.Drawing.Point(530, 79);
            this.lbidrol.Name = "lbidrol";
            this.lbidrol.Size = new System.Drawing.Size(26, 13);
            this.lbidrol.TabIndex = 15;
            this.lbidrol.TabStop = true;
            this.lbidrol.Text = "idrol";
            this.lbidrol.Visible = false;
            // 
            // F_Organizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(619, 749);
            this.Controls.Add(this.lbidrol);
            this.Controls.Add(this.lbiduser);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDatos);
            this.Descripcion = "Formulario de Organizaciones";
            this.Name = "F_Organizaciones";
            this.Text = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.titulo = "CITRA: PROGRAMA DE LAS NACIONES UNIDAS PARA EL DESARROLLO";
            this.Evento_Ingresar += new System.EventHandler(this.F_Organizaciones_Evento_Ingresar);
            this.Evento_Actualizar += new System.EventHandler(this.F_Organizaciones_Evento_Actualizar_1);
            this.Evento_Eliminar += new System.EventHandler(this.F_Organizaciones_Evento_Eliminar);
            this.Evento_Consultar += new System.EventHandler(this.F_Organizaciones_Evento_Consultar);
            this.Evento_Salir += new System.EventHandler(this.F_Organizaciones_Evento_Salir);
            this.Load += new System.EventHandler(this.F_Organizaciones_Load);
            this.Controls.SetChildIndex(this.lstDatos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lb_usuario, 0);
            this.Controls.SetChildIndex(this.lbiduser, 0);
            this.Controls.SetChildIndex(this.lbidrol, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lb_usuario;
        private System.Windows.Forms.LinkLabel lbiduser;
        private System.Windows.Forms.LinkLabel lbidrol;
    }
}