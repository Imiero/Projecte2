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
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lNovaEntitat = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bSortir = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbContrasenya2 = new System.Windows.Forms.TextBox();
            this.tbContrasenya = new System.Windows.Forms.TextBox();
            this.tbUsuari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNIF
            // 
            this.tbNIF.Location = new System.Drawing.Point(87, 387);
            this.tbNIF.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.Size = new System.Drawing.Size(388, 26);
            this.tbNIF.TabIndex = 63;
            this.tbNIF.Text = "NIF";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(87, 332);
            this.tbTelefon.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(388, 26);
            this.tbTelefon.TabIndex = 62;
            this.tbTelefon.Text = "Telèfon";
            // 
            // lNovaEntitat
            // 
            this.lNovaEntitat.AutoSize = true;
            this.lNovaEntitat.Location = new System.Drawing.Point(226, 29);
            this.lNovaEntitat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lNovaEntitat.Name = "lNovaEntitat";
            this.lNovaEntitat.Size = new System.Drawing.Size(94, 20);
            this.lNovaEntitat.TabIndex = 61;
            this.lNovaEntitat.Text = "Nova entitat";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(87, 525);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(113, 49);
            this.bAceptar.TabIndex = 60;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(364, 525);
            this.bSortir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(113, 49);
            this.bSortir.TabIndex = 59;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            this.bSortir.Click += new System.EventHandler(this.bSortir_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(87, 277);
            this.tbNom.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(388, 26);
            this.tbNom.TabIndex = 58;
            this.tbNom.Text = "Nom";
            // 
            // tbContrasenya2
            // 
            this.tbContrasenya2.Location = new System.Drawing.Point(87, 222);
            this.tbContrasenya2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbContrasenya2.Name = "tbContrasenya2";
            this.tbContrasenya2.Size = new System.Drawing.Size(388, 26);
            this.tbContrasenya2.TabIndex = 57;
            this.tbContrasenya2.Text = "Confirmar la contrasenya";
            // 
            // tbContrasenya
            // 
            this.tbContrasenya.Location = new System.Drawing.Point(87, 165);
            this.tbContrasenya.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbContrasenya.Name = "tbContrasenya";
            this.tbContrasenya.Size = new System.Drawing.Size(388, 26);
            this.tbContrasenya.TabIndex = 56;
            this.tbContrasenya.Text = "Contrasenya";
            // 
            // tbUsuari
            // 
            this.tbUsuari.Location = new System.Drawing.Point(87, 109);
            this.tbUsuari.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbUsuari.Name = "tbUsuari";
            this.tbUsuari.Size = new System.Drawing.Size(388, 26);
            this.tbUsuari.TabIndex = 55;
            this.tbUsuari.Text = "Usuari";
            // 
            // FormAddEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 623);
            this.Controls.Add(this.tbNIF);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lNovaEntitat);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbContrasenya2);
            this.Controls.Add(this.tbContrasenya);
            this.Controls.Add(this.tbUsuari);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAddEntitat";
            this.Text = "FormAddEntitat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNIF;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lNovaEntitat;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbContrasenya2;
        private System.Windows.Forms.TextBox tbContrasenya;
        private System.Windows.Forms.TextBox tbUsuari;
    }
}