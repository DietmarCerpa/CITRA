namespace Principal.Formularios
{
    partial class ConexionServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConexionServidor));
            this.grpServidorRemoto = new System.Windows.Forms.GroupBox();
            this.txtPassRemoto = new System.Windows.Forms.TextBox();
            this.txtUsuarioRemoto = new System.Windows.Forms.TextBox();
            this.txtServidorRemoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServidorRemoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnRemoto = new System.Windows.Forms.RadioButton();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.grpServidorLocal = new System.Windows.Forms.GroupBox();
            this.txtServidorLocal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnServidorLocal = new System.Windows.Forms.Button();
            this.grpServidorRemoto.SuspendLayout();
            this.grpServidorLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpServidorRemoto
            // 
            this.grpServidorRemoto.BackColor = System.Drawing.Color.Transparent;
            this.grpServidorRemoto.Controls.Add(this.txtPassRemoto);
            this.grpServidorRemoto.Controls.Add(this.txtUsuarioRemoto);
            this.grpServidorRemoto.Controls.Add(this.txtServidorRemoto);
            this.grpServidorRemoto.Controls.Add(this.label3);
            this.grpServidorRemoto.Controls.Add(this.btnServidorRemoto);
            this.grpServidorRemoto.Controls.Add(this.label2);
            this.grpServidorRemoto.Controls.Add(this.label1);
            this.grpServidorRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServidorRemoto.Location = new System.Drawing.Point(77, 35);
            this.grpServidorRemoto.Name = "grpServidorRemoto";
            this.grpServidorRemoto.Size = new System.Drawing.Size(206, 158);
            this.grpServidorRemoto.TabIndex = 0;
            this.grpServidorRemoto.TabStop = false;
            this.grpServidorRemoto.Text = "Remoto";
            // 
            // txtPassRemoto
            // 
            this.txtPassRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassRemoto.Location = new System.Drawing.Point(100, 88);
            this.txtPassRemoto.Name = "txtPassRemoto";
            this.txtPassRemoto.PasswordChar = '*';
            this.txtPassRemoto.Size = new System.Drawing.Size(100, 24);
            this.txtPassRemoto.TabIndex = 6;
            // 
            // txtUsuarioRemoto
            // 
            this.txtUsuarioRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioRemoto.Location = new System.Drawing.Point(100, 60);
            this.txtUsuarioRemoto.Name = "txtUsuarioRemoto";
            this.txtUsuarioRemoto.Size = new System.Drawing.Size(100, 24);
            this.txtUsuarioRemoto.TabIndex = 5;
            // 
            // txtServidorRemoto
            // 
            this.txtServidorRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidorRemoto.Location = new System.Drawing.Point(100, 33);
            this.txtServidorRemoto.Name = "txtServidorRemoto";
            this.txtServidorRemoto.Size = new System.Drawing.Size(100, 24);
            this.txtServidorRemoto.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // btnServidorRemoto
            // 
            this.btnServidorRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServidorRemoto.Location = new System.Drawing.Point(6, 120);
            this.btnServidorRemoto.Name = "btnServidorRemoto";
            this.btnServidorRemoto.Size = new System.Drawing.Size(194, 32);
            this.btnServidorRemoto.TabIndex = 0;
            this.btnServidorRemoto.Text = "Guardar";
            this.btnServidorRemoto.UseVisualStyleBackColor = true;
            this.btnServidorRemoto.Click += new System.EventHandler(this.btnServidorRemoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor:";
            // 
            // rbtnRemoto
            // 
            this.rbtnRemoto.AutoSize = true;
            this.rbtnRemoto.BackColor = System.Drawing.Color.Transparent;
            this.rbtnRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRemoto.Location = new System.Drawing.Point(77, 1);
            this.rbtnRemoto.Name = "rbtnRemoto";
            this.rbtnRemoto.Size = new System.Drawing.Size(184, 28);
            this.rbtnRemoto.TabIndex = 0;
            this.rbtnRemoto.TabStop = true;
            this.rbtnRemoto.Text = "Servidor Remoto";
            this.rbtnRemoto.UseVisualStyleBackColor = false;
            this.rbtnRemoto.CheckedChanged += new System.EventHandler(this.rbtnRemoto_CheckedChanged);
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.BackColor = System.Drawing.Color.Transparent;
            this.rbtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLocal.Location = new System.Drawing.Point(289, 1);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(162, 28);
            this.rbtnLocal.TabIndex = 1;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "Servidor Local";
            this.rbtnLocal.UseVisualStyleBackColor = false;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // grpServidorLocal
            // 
            this.grpServidorLocal.BackColor = System.Drawing.Color.Transparent;
            this.grpServidorLocal.Controls.Add(this.txtServidorLocal);
            this.grpServidorLocal.Controls.Add(this.label4);
            this.grpServidorLocal.Controls.Add(this.btnServidorLocal);
            this.grpServidorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpServidorLocal.Location = new System.Drawing.Point(289, 35);
            this.grpServidorLocal.Name = "grpServidorLocal";
            this.grpServidorLocal.Size = new System.Drawing.Size(200, 158);
            this.grpServidorLocal.TabIndex = 0;
            this.grpServidorLocal.TabStop = false;
            this.grpServidorLocal.Text = "Local";
            // 
            // txtServidorLocal
            // 
            this.txtServidorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServidorLocal.Location = new System.Drawing.Point(85, 43);
            this.txtServidorLocal.Name = "txtServidorLocal";
            this.txtServidorLocal.Size = new System.Drawing.Size(100, 24);
            this.txtServidorLocal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Servidor:";
            // 
            // btnServidorLocal
            // 
            this.btnServidorLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServidorLocal.Location = new System.Drawing.Point(6, 114);
            this.btnServidorLocal.Name = "btnServidorLocal";
            this.btnServidorLocal.Size = new System.Drawing.Size(188, 29);
            this.btnServidorLocal.TabIndex = 0;
            this.btnServidorLocal.Text = "Guardar";
            this.btnServidorLocal.UseVisualStyleBackColor = true;
            this.btnServidorLocal.Click += new System.EventHandler(this.btnServidorLocal_Click);
            // 
            // ConexionServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CITRA.Properties.Resources.pnud_0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 247);
            this.Controls.Add(this.grpServidorLocal);
            this.Controls.Add(this.rbtnRemoto);
            this.Controls.Add(this.rbtnLocal);
            this.Controls.Add(this.grpServidorRemoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConexionServidor";
            this.Text = "Conexion al Servidor CITRA";
            this.Load += new System.EventHandler(this.ConexionServidor_Load);
            this.grpServidorRemoto.ResumeLayout(false);
            this.grpServidorRemoto.PerformLayout();
            this.grpServidorLocal.ResumeLayout(false);
            this.grpServidorLocal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpServidorRemoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnServidorRemoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnRemoto;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.GroupBox grpServidorLocal;
        private System.Windows.Forms.Button btnServidorLocal;
        private System.Windows.Forms.TextBox txtPassRemoto;
        private System.Windows.Forms.TextBox txtUsuarioRemoto;
        private System.Windows.Forms.TextBox txtServidorRemoto;
        private System.Windows.Forms.TextBox txtServidorLocal;
        private System.Windows.Forms.Label label4;
    }
}