namespace EspaiActiu
{
    partial class FormAddEntitat
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
            this.tbNIF = new System.Windows.Forms.TextBox();
            this.tbCorreu = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bSortir = new System.Windows.Forms.Button();
            this.tbContrasenya2 = new System.Windows.Forms.TextBox();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.tbUsuari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdreça = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTemporada = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxOjoPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjoPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(100, 133);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(260, 20);
            this.tbNIF.TabIndex = 59;
            // 
            // tbCorreu
            // 
            this.tbCorreu.Location = new System.Drawing.Point(100, 107);
            this.tbCorreu.Name = "tbCorreu";
            this.tbCorreu.Size = new System.Drawing.Size(260, 20);
            this.tbCorreu.TabIndex = 58;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(237, 219);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 32);
            this.bAceptar.TabIndex = 62;
            this.bAceptar.Text = "Acceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(318, 219);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(75, 32);
            this.bSortir.TabIndex = 63;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            this.bSortir.Click += new System.EventHandler(this.bSortir_Click);
            // 
            // tbContrasenya2
            // 
            this.tbContrasenya2.Location = new System.Drawing.Point(100, 81);
            this.tbContrasenya2.Name = "tbContrasenya2";
            this.tbContrasenya2.PasswordChar = '*';
            this.tbContrasenya2.Size = new System.Drawing.Size(260, 20);
            this.tbContrasenya2.TabIndex = 57;
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(100, 55);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.PasswordChar = '*';
            this.tbContrasenya.Size = new System.Drawing.Size(260, 20);
            this.tbContrasenya.TabIndex = 56;
            // 
            // tbUsuari
            // 
            this.tbUsuari.Location = new System.Drawing.Point(100, 29);
            this.tbUsuari.Name = "tbUsuari";
            this.tbUsuari.Size = new System.Drawing.Size(260, 20);
            this.tbUsuari.TabIndex = 55;
            this.tbUsuari.TextChanged += new System.EventHandler(this.tbUsuari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Contrasenya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "C. Contrasenya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Correu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "NIF";
            // 
            // textBoxAdreça
            // 
            this.textBoxAdreça.Location = new System.Drawing.Point(100, 160);
            this.textBoxAdreça.Name = "textBoxAdreça";
            this.textBoxAdreça.Size = new System.Drawing.Size(260, 20);
            this.textBoxAdreça.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Adreça";
            // 
            // textBoxTemporada
            // 
            this.textBoxTemporada.Location = new System.Drawing.Point(100, 187);
            this.textBoxTemporada.Name = "textBoxTemporada";
            this.textBoxTemporada.Size = new System.Drawing.Size(260, 20);
            this.textBoxTemporada.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 73;
            this.label7.Text = "Temporada";
            // 
            // pictureBoxOjoPassword
            // 
            this.pictureBoxOjoPassword.Image = global::EspaiActiu.Properties.Resources.ojocerrado;
            this.pictureBoxOjoPassword.Location = new System.Drawing.Point(366, 55);
            this.pictureBoxOjoPassword.Name = "pictureBoxOjoPassword";
            this.pictureBoxOjoPassword.Size = new System.Drawing.Size(23, 20);
            this.pictureBoxOjoPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOjoPassword.TabIndex = 74;
            this.pictureBoxOjoPassword.TabStop = false;
            this.pictureBoxOjoPassword.Click += new System.EventHandler(this.pictureBoxOjoPassword_Click);
            // 
            // FormAddEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 263);
            this.Controls.Add(this.pictureBoxOjoPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTemporada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAdreça);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.tbCorreu);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.tbContrasenya2);
            this.Controls.Add(this.tbContrasenya);
            this.Controls.Add(this.tbUsuari);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FormAddEntitat";
            this.Text = "Agregar Entitat";
            this.Load += new System.EventHandler(this.FormAddEntitat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddEntitat_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjoPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbCorreu;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.TextBox tbContrasenya2;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.TextBox tbUsuari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAdreça;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTemporada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxOjoPassword;
    }
}