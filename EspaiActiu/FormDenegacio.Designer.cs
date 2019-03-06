namespace EspaiActiu
{
    partial class FormDenegacio
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.tbDescripcio = new System.Windows.Forms.TextBox();
            this.lDescripcio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lRao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(484, 515);
            this.bSortir.Margin = new System.Windows.Forms.Padding(6);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(138, 55);
            this.bSortir.TabIndex = 11;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(238, 515);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(6);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(138, 55);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tbDescripcio
            // 
            this.tbDescripcio.Location = new System.Drawing.Point(59, 177);
            this.tbDescripcio.Margin = new System.Windows.Forms.Padding(6);
            this.tbDescripcio.Multiline = true;
            this.tbDescripcio.Name = "tbDescripcio";
            this.tbDescripcio.Size = new System.Drawing.Size(560, 283);
            this.tbDescripcio.TabIndex = 9;
            // 
            // lDescripcio
            // 
            this.lDescripcio.AutoSize = true;
            this.lDescripcio.Location = new System.Drawing.Point(53, 120);
            this.lDescripcio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lDescripcio.Name = "lDescripcio";
            this.lDescripcio.Size = new System.Drawing.Size(109, 25);
            this.lDescripcio.TabIndex = 8;
            this.lDescripcio.Text = "Descripció:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(238, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(380, 32);
            this.comboBox1.TabIndex = 7;
            // 
            // lRao
            // 
            this.lRao.AutoSize = true;
            this.lRao.Location = new System.Drawing.Point(53, 42);
            this.lRao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lRao.Name = "lRao";
            this.lRao.Size = new System.Drawing.Size(170, 25);
            this.lRao.TabIndex = 6;
            this.lRao.Text = "Raó de denegació";
            // 
            // FormDenegacio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 638);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tbDescripcio);
            this.Controls.Add(this.lDescripcio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lRao);
            this.Name = "FormDenegacio";
            this.Text = "FormDenegacio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tbDescripcio;
        private System.Windows.Forms.Label lDescripcio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lRao;
    }
}