namespace EspaiActiu
{
    partial class FormDetallsEspai
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
            this.bSortir = new System.Windows.Forms.Button();
            this.bIncidencies = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.dgvHoraris = new System.Windows.Forms.DataGridView();
            this.lRao = new System.Windows.Forms.Label();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lCorreu = new System.Windows.Forms.Label();
            this.lNIF = new System.Windows.Forms.Label();
            this.lAdreça = new System.Windows.Forms.Label();
            this.lTemporada = new System.Windows.Forms.Label();
            this.lNom = new System.Windows.Forms.Label();
            this.lNomEspai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraris)).BeginInit();
            this.SuspendLayout();
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(378, 400);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(92, 32);
            this.bSortir.TabIndex = 46;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // bIncidencies
            // 
            this.bIncidencies.Location = new System.Drawing.Point(51, 400);
            this.bIncidencies.Name = "bIncidencies";
            this.bIncidencies.Size = new System.Drawing.Size(178, 32);
            this.bIncidencies.TabIndex = 45;
            this.bIncidencies.Text = "Incidències";
            this.bIncidencies.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(279, 400);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(92, 32);
            this.bEditar.TabIndex = 44;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // dgvHoraris
            // 
            this.dgvHoraris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoraris.Location = new System.Drawing.Point(51, 203);
            this.dgvHoraris.Name = "dgvHoraris";
            this.dgvHoraris.Size = new System.Drawing.Size(418, 142);
            this.dgvHoraris.TabIndex = 43;
            // 
            // lRao
            // 
            this.lRao.AutoSize = true;
            this.lRao.Location = new System.Drawing.Point(169, 154);
            this.lRao.Name = "lRao";
            this.lRao.Size = new System.Drawing.Size(27, 13);
            this.lRao.TabIndex = 42;
            this.lRao.Text = "Raó";
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Location = new System.Drawing.Point(168, 137);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(43, 13);
            this.lTelefon.TabIndex = 41;
            this.lTelefon.Text = "Telèfon";
            // 
            // lCorreu
            // 
            this.lCorreu.AutoSize = true;
            this.lCorreu.Location = new System.Drawing.Point(169, 120);
            this.lCorreu.Name = "lCorreu";
            this.lCorreu.Size = new System.Drawing.Size(87, 13);
            this.lCorreu.TabIndex = 40;
            this.lCorreu.Text = "Correu electrònic";
            // 
            // lNIF
            // 
            this.lNIF.AutoSize = true;
            this.lNIF.Location = new System.Drawing.Point(168, 104);
            this.lNIF.Name = "lNIF";
            this.lNIF.Size = new System.Drawing.Size(24, 13);
            this.lNIF.TabIndex = 39;
            this.lNIF.Text = "NIF";
            // 
            // lAdreça
            // 
            this.lAdreça.AutoSize = true;
            this.lAdreça.Location = new System.Drawing.Point(169, 88);
            this.lAdreça.Name = "lAdreça";
            this.lAdreça.Size = new System.Drawing.Size(41, 13);
            this.lAdreça.TabIndex = 38;
            this.lAdreça.Text = "Adreça";
            // 
            // lTemporada
            // 
            this.lTemporada.AutoSize = true;
            this.lTemporada.Location = new System.Drawing.Point(168, 71);
            this.lTemporada.Name = "lTemporada";
            this.lTemporada.Size = new System.Drawing.Size(61, 13);
            this.lTemporada.TabIndex = 37;
            this.lTemporada.Text = "Temporada";
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(169, 52);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(29, 13);
            this.lNom.TabIndex = 36;
            this.lNom.Text = "Nom";
            // 
            // lNomEspai
            // 
            this.lNomEspai.AutoSize = true;
            this.lNomEspai.Location = new System.Drawing.Point(218, 8);
            this.lNomEspai.Name = "lNomEspai";
            this.lNomEspai.Size = new System.Drawing.Size(57, 13);
            this.lNomEspai.TabIndex = 35;
            this.lNomEspai.Text = "Nom espai";
            // 
            // FormDetallsEspai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 462);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.bIncidencies);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.dgvHoraris);
            this.Controls.Add(this.lRao);
            this.Controls.Add(this.lTelefon);
            this.Controls.Add(this.lCorreu);
            this.Controls.Add(this.lNIF);
            this.Controls.Add(this.lAdreça);
            this.Controls.Add(this.lTemporada);
            this.Controls.Add(this.lNom);
            this.Controls.Add(this.lNomEspai);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDetallsEspai";
            this.Text = "FormDetallsEspai";
            this.Load += new System.EventHandler(this.FormDetallsEspai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.Button bIncidencies;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.DataGridView dgvHoraris;
        private System.Windows.Forms.Label lRao;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.Label lCorreu;
        private System.Windows.Forms.Label lNIF;
        private System.Windows.Forms.Label lAdreça;
        private System.Windows.Forms.Label lTemporada;
        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lNomEspai;
    }
}