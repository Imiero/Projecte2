namespace EspaiActiu
{
    partial class FormInicio
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bCercarEspai = new System.Windows.Forms.Button();
            this.bAfegirEspai = new System.Windows.Forms.Button();
            this.tbCercarEspai = new System.Windows.Forms.TextBox();
            this.bEliminarEspai = new System.Windows.Forms.Button();
            this.lvLlistaEspais = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bDenegarSollicitut = new System.Windows.Forms.Button();
            this.bAceptarSollicitut = new System.Windows.Forms.Button();
            this.dgSollicituts = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bAfegirEntitat = new System.Windows.Forms.Button();
            this.bEliminarEntitat = new System.Windows.Forms.Button();
            this.bCercarEntitat = new System.Windows.Forms.Button();
            this.tbCercarEntitat = new System.Windows.Forms.TextBox();
            this.lvLlistaEntitats = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSollicituts)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EspaiActiu.Properties.Resources.logo_principal_color;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1252, 6);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(388, 132);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tab
            // 
            this.tab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tab.ItemSize = new System.Drawing.Size(50, 150);
            this.tab.Location = new System.Drawing.Point(33, 146);
            this.tab.Margin = new System.Windows.Forms.Padding(6);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.Padding = new System.Drawing.Point(6, 30);
            this.tab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1553, 642);
            this.tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.bCercarEspai);
            this.tabPage1.Controls.Add(this.bAfegirEspai);
            this.tabPage1.Controls.Add(this.tbCercarEspai);
            this.tabPage1.Controls.Add(this.bEliminarEspai);
            this.tabPage1.Controls.Add(this.lvLlistaEspais);
            this.tabPage1.Location = new System.Drawing.Point(160, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1389, 634);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Espais";
            // 
            // bCercarEspai
            // 
            this.bCercarEspai.Location = new System.Drawing.Point(541, 57);
            this.bCercarEspai.Margin = new System.Windows.Forms.Padding(6);
            this.bCercarEspai.Name = "bCercarEspai";
            this.bCercarEspai.Size = new System.Drawing.Size(138, 42);
            this.bCercarEspai.TabIndex = 6;
            this.bCercarEspai.Text = "Cercar";
            this.bCercarEspai.UseVisualStyleBackColor = true;
            // 
            // bAfegirEspai
            // 
            this.bAfegirEspai.Location = new System.Drawing.Point(666, 548);
            this.bAfegirEspai.Margin = new System.Windows.Forms.Padding(6);
            this.bAfegirEspai.Name = "bAfegirEspai";
            this.bAfegirEspai.Size = new System.Drawing.Size(229, 61);
            this.bAfegirEspai.TabIndex = 3;
            this.bAfegirEspai.Text = "Afegir";
            this.bAfegirEspai.UseVisualStyleBackColor = true;
            // 
            // tbCercarEspai
            // 
            this.tbCercarEspai.Location = new System.Drawing.Point(59, 57);
            this.tbCercarEspai.Margin = new System.Windows.Forms.Padding(6);
            this.tbCercarEspai.Name = "tbCercarEspai";
            this.tbCercarEspai.Size = new System.Drawing.Size(404, 29);
            this.tbCercarEspai.TabIndex = 5;
            // 
            // bEliminarEspai
            // 
            this.bEliminarEspai.Location = new System.Drawing.Point(957, 548);
            this.bEliminarEspai.Margin = new System.Windows.Forms.Padding(6);
            this.bEliminarEspai.Name = "bEliminarEspai";
            this.bEliminarEspai.Size = new System.Drawing.Size(229, 61);
            this.bEliminarEspai.TabIndex = 4;
            this.bEliminarEspai.Text = "Eliminar";
            this.bEliminarEspai.UseVisualStyleBackColor = true;
            // 
            // lvLlistaEspais
            // 
            this.lvLlistaEspais.Location = new System.Drawing.Point(57, 135);
            this.lvLlistaEspais.Margin = new System.Windows.Forms.Padding(6);
            this.lvLlistaEspais.Name = "lvLlistaEspais";
            this.lvLlistaEspais.Size = new System.Drawing.Size(1126, 390);
            this.lvLlistaEspais.TabIndex = 2;
            this.lvLlistaEspais.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.bDenegarSollicitut);
            this.tabPage2.Controls.Add(this.bAceptarSollicitut);
            this.tabPage2.Controls.Add(this.dgSollicituts);
            this.tabPage2.Location = new System.Drawing.Point(160, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1389, 634);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sol·licituts";
            // 
            // bDenegarSollicitut
            // 
            this.bDenegarSollicitut.Location = new System.Drawing.Point(959, 548);
            this.bDenegarSollicitut.Margin = new System.Windows.Forms.Padding(6);
            this.bDenegarSollicitut.Name = "bDenegarSollicitut";
            this.bDenegarSollicitut.Size = new System.Drawing.Size(231, 61);
            this.bDenegarSollicitut.TabIndex = 2;
            this.bDenegarSollicitut.Text = "Denegar";
            this.bDenegarSollicitut.UseVisualStyleBackColor = true;
            // 
            // bAceptarSollicitut
            // 
            this.bAceptarSollicitut.Location = new System.Drawing.Point(667, 548);
            this.bAceptarSollicitut.Margin = new System.Windows.Forms.Padding(6);
            this.bAceptarSollicitut.Name = "bAceptarSollicitut";
            this.bAceptarSollicitut.Size = new System.Drawing.Size(229, 61);
            this.bAceptarSollicitut.TabIndex = 1;
            this.bAceptarSollicitut.Text = "Aceptar";
            this.bAceptarSollicitut.UseVisualStyleBackColor = true;
            // 
            // dgSollicituts
            // 
            this.dgSollicituts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSollicituts.Location = new System.Drawing.Point(61, 30);
            this.dgSollicituts.Margin = new System.Windows.Forms.Padding(6);
            this.dgSollicituts.Name = "dgSollicituts";
            this.dgSollicituts.Size = new System.Drawing.Size(1129, 484);
            this.dgSollicituts.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bAfegirEntitat);
            this.tabPage3.Controls.Add(this.bEliminarEntitat);
            this.tabPage3.Controls.Add(this.bCercarEntitat);
            this.tabPage3.Controls.Add(this.tbCercarEntitat);
            this.tabPage3.Controls.Add(this.lvLlistaEntitats);
            this.tabPage3.Location = new System.Drawing.Point(160, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(1389, 634);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Entitats";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bAfegirEntitat
            // 
            this.bAfegirEntitat.Location = new System.Drawing.Point(671, 546);
            this.bAfegirEntitat.Margin = new System.Windows.Forms.Padding(6);
            this.bAfegirEntitat.Name = "bAfegirEntitat";
            this.bAfegirEntitat.Size = new System.Drawing.Size(229, 61);
            this.bAfegirEntitat.TabIndex = 12;
            this.bAfegirEntitat.Text = "Afegir";
            this.bAfegirEntitat.UseVisualStyleBackColor = true;
            // 
            // bEliminarEntitat
            // 
            this.bEliminarEntitat.Location = new System.Drawing.Point(963, 546);
            this.bEliminarEntitat.Margin = new System.Windows.Forms.Padding(6);
            this.bEliminarEntitat.Name = "bEliminarEntitat";
            this.bEliminarEntitat.Size = new System.Drawing.Size(229, 61);
            this.bEliminarEntitat.TabIndex = 13;
            this.bEliminarEntitat.Text = "Eliminar";
            this.bEliminarEntitat.UseVisualStyleBackColor = true;
            // 
            // bCercarEntitat
            // 
            this.bCercarEntitat.Location = new System.Drawing.Point(535, 57);
            this.bCercarEntitat.Margin = new System.Windows.Forms.Padding(6);
            this.bCercarEntitat.Name = "bCercarEntitat";
            this.bCercarEntitat.Size = new System.Drawing.Size(138, 42);
            this.bCercarEntitat.TabIndex = 11;
            this.bCercarEntitat.Text = "Cercar";
            this.bCercarEntitat.UseVisualStyleBackColor = true;
            // 
            // tbCercarEntitat
            // 
            this.tbCercarEntitat.Location = new System.Drawing.Point(61, 57);
            this.tbCercarEntitat.Margin = new System.Windows.Forms.Padding(6);
            this.tbCercarEntitat.Name = "tbCercarEntitat";
            this.tbCercarEntitat.Size = new System.Drawing.Size(404, 29);
            this.tbCercarEntitat.TabIndex = 10;
            // 
            // lvLlistaEntitats
            // 
            this.lvLlistaEntitats.Location = new System.Drawing.Point(61, 135);
            this.lvLlistaEntitats.Margin = new System.Windows.Forms.Padding(6);
            this.lvLlistaEntitats.Name = "lvLlistaEntitats";
            this.lvLlistaEntitats.Size = new System.Drawing.Size(1126, 390);
            this.lvLlistaEntitats.TabIndex = 7;
            this.lvLlistaEntitats.UseCompatibleStateImageBehavior = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 1028);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.pictureBoxLogo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSollicituts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bCercarEspai;
        private System.Windows.Forms.Button bAfegirEspai;
        private System.Windows.Forms.TextBox tbCercarEspai;
        private System.Windows.Forms.Button bEliminarEspai;
        private System.Windows.Forms.ListView lvLlistaEspais;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bDenegarSollicitut;
        private System.Windows.Forms.Button bAceptarSollicitut;
        private System.Windows.Forms.DataGridView dgSollicituts;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bAfegirEntitat;
        private System.Windows.Forms.Button bEliminarEntitat;
        private System.Windows.Forms.Button bCercarEntitat;
        private System.Windows.Forms.TextBox tbCercarEntitat;
        private System.Windows.Forms.ListView lvLlistaEntitats;
    }
}