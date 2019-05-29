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
            this.lPreu = new System.Windows.Forms.Label();
            this.lNomEspai = new System.Windows.Forms.Label();
            this.tbPreu = new System.Windows.Forms.TextBox();
            this.gbDadesEspai = new System.Windows.Forms.GroupBox();
            this.cbExterior = new System.Windows.Forms.CheckBox();
            this.gbDadesEspai.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSortir
            // 
            this.bSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.bSortir.Location = new System.Drawing.Point(156, 274);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(123, 32);
            this.bSortir.TabIndex = 46;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = false;
            this.bSortir.Click += new System.EventHandler(this.bSortir_Click);
            // 
            // lPreu
            // 
            this.lPreu.AutoSize = true;
            this.lPreu.Location = new System.Drawing.Point(28, 64);
            this.lPreu.Name = "lPreu";
            this.lPreu.Size = new System.Drawing.Size(36, 16);
            this.lPreu.TabIndex = 37;
            this.lPreu.Text = "Preu";
            // 
            // lNomEspai
            // 
            this.lNomEspai.AutoSize = true;
            this.lNomEspai.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomEspai.Location = new System.Drawing.Point(55, 26);
            this.lNomEspai.Name = "lNomEspai";
            this.lNomEspai.Size = new System.Drawing.Size(109, 24);
            this.lNomEspai.TabIndex = 35;
            this.lNomEspai.Text = "Nom espai";
            // 
            // tbPreu
            // 
            this.tbPreu.Location = new System.Drawing.Point(128, 58);
            this.tbPreu.Name = "tbPreu";
            this.tbPreu.Size = new System.Drawing.Size(76, 22);
            this.tbPreu.TabIndex = 48;
            // 
            // gbDadesEspai
            // 
            this.gbDadesEspai.Controls.Add(this.cbExterior);
            this.gbDadesEspai.Controls.Add(this.lPreu);
            this.gbDadesEspai.Controls.Add(this.tbPreu);
            this.gbDadesEspai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadesEspai.Location = new System.Drawing.Point(28, 79);
            this.gbDadesEspai.Name = "gbDadesEspai";
            this.gbDadesEspai.Size = new System.Drawing.Size(251, 177);
            this.gbDadesEspai.TabIndex = 53;
            this.gbDadesEspai.TabStop = false;
            this.gbDadesEspai.Text = "Dades espai";
            // 
            // cbExterior
            // 
            this.cbExterior.AutoSize = true;
            this.cbExterior.Location = new System.Drawing.Point(140, 102);
            this.cbExterior.Name = "cbExterior";
            this.cbExterior.Size = new System.Drawing.Size(72, 20);
            this.cbExterior.TabIndex = 49;
            this.cbExterior.Text = "Exterior";
            this.cbExterior.UseVisualStyleBackColor = true;
            // 
            // FormDetallsEspai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 331);
            this.Controls.Add(this.gbDadesEspai);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.lNomEspai);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetallsEspai";
            this.Text = "FormDetallsEspai";
            this.Load += new System.EventHandler(this.FormDetallsEspai_Load);
            this.gbDadesEspai.ResumeLayout(false);
            this.gbDadesEspai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.Label lPreu;
        private System.Windows.Forms.Label lNomEspai;
        private System.Windows.Forms.TextBox tbPreu;
        private System.Windows.Forms.GroupBox gbDadesEspai;
        private System.Windows.Forms.CheckBox cbExterior;
    }
}