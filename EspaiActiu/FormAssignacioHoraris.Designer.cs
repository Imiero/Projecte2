namespace EspaiActiu
{
    partial class AssignacioHoraris
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePickerInici = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dIESSETMANABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxFinal = new System.Windows.Forms.CheckBox();
            this.buttonSortir = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dIESSETMANABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerInici
            // 
            this.dateTimePickerInici.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerInici.Location = new System.Drawing.Point(73, 38);
            this.dateTimePickerInici.Name = "dateTimePickerInici";
            this.dateTimePickerInici.ShowUpDown = true;
            this.dateTimePickerInici.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerInici.TabIndex = 8;
            this.dateTimePickerInici.Value = new System.DateTime(2019, 4, 10, 10, 0, 0, 0);
            // 
            // dateTimePickerFinal
            // 
            this.dateTimePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFinal.Location = new System.Drawing.Point(73, 64);
            this.dateTimePickerFinal.Name = "dateTimePickerFinal";
            this.dateTimePickerFinal.ShowUpDown = true;
            this.dateTimePickerFinal.Size = new System.Drawing.Size(121, 20);
            this.dateTimePickerFinal.TabIndex = 9;
            this.dateTimePickerFinal.Value = new System.DateTime(2019, 4, 10, 10, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dia";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dIESSETMANABindingSource;
            this.comboBox1.DisplayMember = "dia";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "id";
            // 
            // dIESSETMANABindingSource
            // 
            this.dIESSETMANABindingSource.DataSource = typeof(EspaiActiu.DIES_SETMANA);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hora Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hora Inici";
            // 
            // checkBoxFinal
            // 
            this.checkBoxFinal.AutoSize = true;
            this.checkBoxFinal.Location = new System.Drawing.Point(12, 92);
            this.checkBoxFinal.Name = "checkBoxFinal";
            this.checkBoxFinal.Size = new System.Drawing.Size(136, 18);
            this.checkBoxFinal.TabIndex = 15;
            this.checkBoxFinal.Text = "Finalitzar assignacions";
            this.checkBoxFinal.UseVisualStyleBackColor = true;
            // 
            // buttonSortir
            // 
            this.buttonSortir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonSortir.Location = new System.Drawing.Point(116, 116);
            this.buttonSortir.Name = "buttonSortir";
            this.buttonSortir.Size = new System.Drawing.Size(75, 23);
            this.buttonSortir.TabIndex = 16;
            this.buttonSortir.Text = "Sortir";
            this.buttonSortir.UseVisualStyleBackColor = false;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(212)))), ((int)(((byte)(97)))));
            this.buttonAceptar.Location = new System.Drawing.Point(35, 116);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 17;
            this.buttonAceptar.Text = "Acceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // AssignacioHoraris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 158);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonSortir);
            this.Controls.Add(this.checkBoxFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFinal);
            this.Controls.Add(this.dateTimePickerInici);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AssignacioHoraris";
            this.Text = "FormAssignacioHoraris";
            this.Load += new System.EventHandler(this.AssignacioHoraris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dIESSETMANABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerInici;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dIESSETMANABindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxFinal;
        private System.Windows.Forms.Button buttonSortir;
        private System.Windows.Forms.Button buttonAceptar;
    }
}