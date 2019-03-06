namespace EspaiActiu
{
    partial class FormDetallsEntitat
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
            this.lEquips = new System.Windows.Forms.Label();
            this.lvEquips = new System.Windows.Forms.ListView();
            this.bSortir = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lNIF = new System.Windows.Forms.Label();
            this.lAdreça = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.lNomEntitat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lEquips
            // 
            this.lEquips.AutoSize = true;
            this.lEquips.Location = new System.Drawing.Point(58, 302);
            this.lEquips.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lEquips.Name = "lEquips";
            this.lEquips.Size = new System.Drawing.Size(78, 25);
            this.lEquips.TabIndex = 58;
            this.lEquips.Text = "Equips:";
            // 
            // lvEquips
            // 
            this.lvEquips.Location = new System.Drawing.Point(58, 337);
            this.lvEquips.Margin = new System.Windows.Forms.Padding(6);
            this.lvEquips.Name = "lvEquips";
            this.lvEquips.Size = new System.Drawing.Size(765, 342);
            this.lvEquips.TabIndex = 57;
            this.lvEquips.UseCompatibleStateImageBehavior = false;
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(658, 747);
            this.bSortir.Margin = new System.Windows.Forms.Padding(6);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(169, 59);
            this.bSortir.TabIndex = 56;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(476, 747);
            this.bEditar.Margin = new System.Windows.Forms.Padding(6);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(169, 59);
            this.bEditar.TabIndex = 55;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Location = new System.Drawing.Point(275, 230);
            this.lTelefon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(78, 25);
            this.lTelefon.TabIndex = 54;
            this.lTelefon.Text = "Telèfon";
            // 
            // lNIF
            // 
            this.lNIF.AutoSize = true;
            this.lNIF.Location = new System.Drawing.Point(275, 201);
            this.lNIF.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNIF.Name = "lNIF";
            this.lNIF.Size = new System.Drawing.Size(43, 25);
            this.lNIF.TabIndex = 53;
            this.lNIF.Text = "NIF";
            // 
            // lAdreça
            // 
            this.lAdreça.AutoSize = true;
            this.lAdreça.Location = new System.Drawing.Point(275, 171);
            this.lAdreça.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lAdreça.Name = "lAdreça";
            this.lAdreça.Size = new System.Drawing.Size(75, 25);
            this.lAdreça.TabIndex = 52;
            this.lAdreça.Text = "Adreça";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(275, 140);
            this.lEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(160, 25);
            this.lEmail.TabIndex = 51;
            this.lEmail.Text = "Correu electrònic";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(275, 105);
            this.lNom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(53, 25);
            this.lNom.TabIndex = 50;
            this.lNom.Text = "Nom";
            // 
            // lNomEntitat
            // 
            this.lNomEntitat.AutoSize = true;
            this.lNomEntitat.Location = new System.Drawing.Point(364, 23);
            this.lNomEntitat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNomEntitat.Name = "lNomEntitat";
            this.lNomEntitat.Size = new System.Drawing.Size(110, 25);
            this.lNomEntitat.TabIndex = 49;
            this.lNomEntitat.Text = "Nom entitat";
            // 
            // FormDetallsEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 837);
            this.Controls.Add(this.lEquips);
            this.Controls.Add(this.lvEquips);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.lTelefon);
            this.Controls.Add(this.lNIF);
            this.Controls.Add(this.lAdreça);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.lNomEntitat);
            this.Name = "FormDetallsEntitat";
            this.Text = "FormDetallsEntitat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEquips;
        private System.Windows.Forms.ListView lvEquips;
        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.Label lNIF;
        private System.Windows.Forms.Label lAdreça;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lNomEntitat;
    }
}