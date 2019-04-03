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
            this.tbNIF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNIF.Location = new System.Drawing.Point(100, 143);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(260, 20);
            this.tbNIF.TabIndex = 59;
            // 
            // tbCorreu
            // 
            this.tbCorreu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreu.Location = new System.Drawing.Point(100, 115);
            this.tbCorreu.Name = "tbCorreu";
            this.tbCorreu.Size = new System.Drawing.Size(260, 20);
            this.tbCorreu.TabIndex = 58;
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(237, 236);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 34);
            this.bAceptar.TabIndex = 62;
            this.bAceptar.Text = "Acceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bSortir
            // 
            this.bSortir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSortir.Location = new System.Drawing.Point(318, 236);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(75, 34);
            this.bSortir.TabIndex = 63;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            this.bSortir.Click += new System.EventHandler(this.bSortir_Click);
            // 
            // tbContrasenya2
            // 
            this.tbContrasenya2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenya2.Location = new System.Drawing.Point(100, 87);
            this.tbContrasenya2.Name = "tbContrasenya2";
            this.tbContrasenya2.PasswordChar = '*';
            this.tbContrasenya2.Size = new System.Drawing.Size(260, 20);
            this.tbContrasenya2.TabIndex = 57;
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasenya.Location = new System.Drawing.Point(100, 59);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.PasswordChar = '*';
            this.tbContrasenya.Size = new System.Drawing.Size(260, 20);
            this.tbContrasenya.TabIndex = 56;
            // 
            // tbUsuari
            // 
            this.tbUsuari.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuari.Location = new System.Drawing.Point(100, 31);
            this.tbUsuari.Name = "tbUsuari";
            this.tbUsuari.Size = new System.Drawing.Size(260, 20);
            this.tbUsuari.TabIndex = 55;
            this.tbUsuari.TextChanged += new System.EventHandler(this.tbUsuari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 64;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 65;
            this.label2.Text = "Contrasenya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 14);
            this.label3.TabIndex = 66;
            this.label3.Text = "C. Contrasenya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 14);
            this.label5.TabIndex = 68;
            this.label5.Text = "Correu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 14);
            this.label6.TabIndex = 69;
            this.label6.Text = "NIF";
            // 
            // textBoxAdreça
            // 
            this.textBoxAdreça.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdreça.Location = new System.Drawing.Point(100, 172);
            this.textBoxAdreça.Name = "textBoxAdreça";
            this.textBoxAdreça.Size = new System.Drawing.Size(260, 20);
            this.textBoxAdreça.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 71;
            this.label4.Text = "Adreça";
            // 
            // textBoxTemporada
            // 
            this.textBoxTemporada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemporada.Location = new System.Drawing.Point(100, 201);
            this.textBoxTemporada.Name = "textBoxTemporada";
            this.textBoxTemporada.Size = new System.Drawing.Size(260, 20);
            this.textBoxTemporada.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 73;
            this.label7.Text = "Temporada";
            // 
            // pictureBoxOjoPassword
            // 
            this.pictureBoxOjoPassword.Image = global::EspaiActiu.Properties.Resources.ojocerrado;
            this.pictureBoxOjoPassword.Location = new System.Drawing.Point(366, 59);
            this.pictureBoxOjoPassword.Name = "pictureBoxOjoPassword";
            this.pictureBoxOjoPassword.Size = new System.Drawing.Size(23, 22);
            this.pictureBoxOjoPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOjoPassword.TabIndex = 74;
            this.pictureBoxOjoPassword.TabStop = false;
            this.pictureBoxOjoPassword.Click += new System.EventHandler(this.pictureBoxOjoPassword_Click);
            // 
            // FormAddEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 283);
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
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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