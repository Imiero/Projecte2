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
            this.listViewTelefons = new System.Windows.Forms.ListView();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lEquips
            // 
            this.lEquips.AutoSize = true;
            this.lEquips.Location = new System.Drawing.Point(9, 214);
            this.lEquips.Name = "lEquips";
            this.lEquips.Size = new System.Drawing.Size(42, 13);
            this.lEquips.TabIndex = 58;
            this.lEquips.Text = "Equips:";
            // 
            // lvEquips
            // 
            this.lvEquips.Location = new System.Drawing.Point(12, 230);
            this.lvEquips.Name = "lvEquips";
            this.lvEquips.Size = new System.Drawing.Size(179, 62);
            this.lvEquips.TabIndex = 57;
            this.lvEquips.UseCompatibleStateImageBehavior = false;
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(359, 405);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(92, 32);
            this.bSortir.TabIndex = 56;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(260, 405);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(92, 32);
            this.bEditar.TabIndex = 55;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Location = new System.Drawing.Point(9, 131);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(51, 13);
            this.lTelefon.TabIndex = 54;
            this.lTelefon.Text = "Telèfons:";
            this.lTelefon.Click += new System.EventHandler(this.lTelefon_Click);
            // 
            // lNIF
            // 
            this.lNIF.AutoSize = true;
            this.lNIF.Location = new System.Drawing.Point(9, 115);
            this.lNIF.Name = "lNIF";
            this.lNIF.Size = new System.Drawing.Size(24, 13);
            this.lNIF.TabIndex = 53;
            this.lNIF.Text = "NIF";
            this.lNIF.Click += new System.EventHandler(this.lNIF_Click);
            // 
            // lAdreça
            // 
            this.lAdreça.AutoSize = true;
            this.lAdreça.Location = new System.Drawing.Point(9, 99);
            this.lAdreça.Name = "lAdreça";
            this.lAdreça.Size = new System.Drawing.Size(41, 13);
            this.lAdreça.TabIndex = 52;
            this.lAdreça.Text = "Adreça";
            this.lAdreça.Click += new System.EventHandler(this.lAdreça_Click);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(9, 82);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(87, 13);
            this.lEmail.TabIndex = 51;
            this.lEmail.Text = "Correu electrònic";
            this.lEmail.Click += new System.EventHandler(this.lEmail_Click);
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(9, 63);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 50;
            this.lNom.Text = "Nom";
            this.lNom.Click += new System.EventHandler(this.lNom_Click);
            // 
            // lNomEntitat
            // 
            this.lNomEntitat.AutoSize = true;
            this.lNomEntitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomEntitat.Location = new System.Drawing.Point(12, 9);
            this.lNomEntitat.Name = "lNomEntitat";
            this.lNomEntitat.Size = new System.Drawing.Size(153, 31);
            this.lNomEntitat.TabIndex = 49;
            this.lNomEntitat.Text = "Nom entitat";
            // 
            // listViewTelefons
            // 
            this.listViewTelefons.Location = new System.Drawing.Point(12, 147);
            this.listViewTelefons.Name = "listViewTelefons";
            this.listViewTelefons.Size = new System.Drawing.Size(179, 54);
            this.listViewTelefons.TabIndex = 59;
            this.listViewTelefons.UseCompatibleStateImageBehavior = false;
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(116, 302);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 60;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // FormDetallsEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 337);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.listViewTelefons);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetallsEntitat";
            this.Text = "FormDetallsEntitat";
            this.Load += new System.EventHandler(this.FormDetallsEntitat_Load);
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
        private System.Windows.Forms.ListView listViewTelefons;
        private System.Windows.Forms.Button buttonModificar;
    }
}