﻿namespace EspaiActiu
{
    partial class FormAddEspai
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
            this.dtvHoraris = new System.Windows.Forms.DataGridView();
            this.lNouEspai = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bSortir = new System.Windows.Forms.Button();
            this.tbTelefonEspai = new System.Windows.Forms.TextBox();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.tbDireccio = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtvHoraris)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvHoraris
            // 
            this.dtvHoraris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvHoraris.Location = new System.Drawing.Point(107, 455);
            this.dtvHoraris.Margin = new System.Windows.Forms.Padding(6);
            this.dtvHoraris.Name = "dtvHoraris";
            this.dtvHoraris.Size = new System.Drawing.Size(477, 257);
            this.dtvHoraris.TabIndex = 52;
            // 
            // lNouEspai
            // 
            this.lNouEspai.AutoSize = true;
            this.lNouEspai.Location = new System.Drawing.Point(278, 19);
            this.lNouEspai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lNouEspai.Name = "lNouEspai";
            this.lNouEspai.Size = new System.Drawing.Size(100, 25);
            this.lNouEspai.TabIndex = 51;
            this.lNouEspai.Text = "Nou espai";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(107, 767);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(6);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(138, 59);
            this.bAceptar.TabIndex = 50;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(446, 767);
            this.bSortir.Margin = new System.Windows.Forms.Padding(6);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(138, 59);
            this.bSortir.TabIndex = 49;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // tbTelefonEspai
            // 
            this.tbTelefonEspai.Location = new System.Drawing.Point(107, 377);
            this.tbTelefonEspai.Margin = new System.Windows.Forms.Padding(6);
            this.tbTelefonEspai.Name = "tbTelefonEspai";
            this.tbTelefonEspai.Size = new System.Drawing.Size(473, 29);
            this.tbTelefonEspai.TabIndex = 48;
            this.tbTelefonEspai.Text = "Telèfon de contacte";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(107, 285);
            this.tbInfo.Margin = new System.Windows.Forms.Padding(6);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(473, 29);
            this.tbInfo.TabIndex = 47;
            this.tbInfo.Text = "Mes info";
            // 
            // tbDireccio
            // 
            this.tbDireccio.Location = new System.Drawing.Point(107, 198);
            this.tbDireccio.Margin = new System.Windows.Forms.Padding(6);
            this.tbDireccio.Name = "tbDireccio";
            this.tbDireccio.Size = new System.Drawing.Size(473, 29);
            this.tbDireccio.TabIndex = 46;
            this.tbDireccio.Text = "Direcció";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(107, 110);
            this.tbNom.Margin = new System.Windows.Forms.Padding(6);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(473, 29);
            this.tbNom.TabIndex = 45;
            this.tbNom.Text = "Nom";
            // 
            // FormAddEspai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 857);
            this.Controls.Add(this.dtvHoraris);
            this.Controls.Add(this.lNouEspai);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.tbTelefonEspai);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.tbDireccio);
            this.Controls.Add(this.tbNom);
            this.Name = "FormAddEspai";
            this.Text = "FormAddEspai";
            ((System.ComponentModel.ISupportInitialize)(this.dtvHoraris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvHoraris;
        private System.Windows.Forms.Label lNouEspai;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.TextBox tbTelefonEspai;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.TextBox tbDireccio;
        private System.Windows.Forms.TextBox tbNom;
    }
}