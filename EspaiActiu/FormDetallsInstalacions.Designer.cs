namespace EspaiActiu
{
    partial class FormDetallsInstalacions
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
            this.lNom = new System.Windows.Forms.Label();
            this.lAdreca = new System.Windows.Forms.Label();
            this.tbNomInstalacio = new System.Windows.Forms.TextBox();
            this.tbAdrecaInstalacio = new System.Windows.Forms.TextBox();
            this.dgvLlistaEspais = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEspais = new System.Windows.Forms.BindingSource(this.components);
            this.gbEspais = new System.Windows.Forms.GroupBox();
            this.gbHoraris = new System.Windows.Forms.GroupBox();
            this.dgvHoraris = new System.Windows.Forms.DataGridView();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horari_inici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horari_fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHoraris = new System.Windows.Forms.BindingSource(this.components);
            this.gbDetallsInstalacio = new System.Windows.Forms.GroupBox();
            this.bModificar = new System.Windows.Forms.Button();
            this.hORARISINSTALACIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lLOCDEPORTIVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDias = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlistaEspais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).BeginInit();
            this.gbEspais.SuspendLayout();
            this.gbHoraris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoraris)).BeginInit();
            this.gbDetallsInstalacio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hORARISINSTALACIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLOCDEPORTIVOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).BeginInit();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(34, 38);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(35, 16);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom";
            // 
            // lAdreca
            // 
            this.lAdreca.AutoSize = true;
            this.lAdreca.Location = new System.Drawing.Point(34, 76);
            this.lAdreca.Name = "lAdreca";
            this.lAdreca.Size = new System.Drawing.Size(49, 16);
            this.lAdreca.TabIndex = 1;
            this.lAdreca.Text = "Adreça";
            // 
            // tbNomInstalacio
            // 
            this.tbNomInstalacio.Location = new System.Drawing.Point(96, 31);
            this.tbNomInstalacio.Name = "tbNomInstalacio";
            this.tbNomInstalacio.Size = new System.Drawing.Size(286, 22);
            this.tbNomInstalacio.TabIndex = 2;
            // 
            // tbAdrecaInstalacio
            // 
            this.tbAdrecaInstalacio.Location = new System.Drawing.Point(96, 69);
            this.tbAdrecaInstalacio.Name = "tbAdrecaInstalacio";
            this.tbAdrecaInstalacio.Size = new System.Drawing.Size(286, 22);
            this.tbAdrecaInstalacio.TabIndex = 3;
            // 
            // dgvLlistaEspais
            // 
            this.dgvLlistaEspais.AllowUserToAddRows = false;
            this.dgvLlistaEspais.AllowUserToDeleteRows = false;
            this.dgvLlistaEspais.AutoGenerateColumns = false;
            this.dgvLlistaEspais.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLlistaEspais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLlistaEspais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn});
            this.dgvLlistaEspais.DataSource = this.bindingSourceEspais;
            this.dgvLlistaEspais.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvLlistaEspais.Location = new System.Drawing.Point(18, 21);
            this.dgvLlistaEspais.Name = "dgvLlistaEspais";
            this.dgvLlistaEspais.ReadOnly = true;
            this.dgvLlistaEspais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlistaEspais.Size = new System.Drawing.Size(345, 116);
            this.dgvLlistaEspais.TabIndex = 4;
            this.dgvLlistaEspais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLlistaEspais_CellContentClick);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceEspais
            // 
            this.bindingSourceEspais.DataSource = typeof(EspaiActiu.LLOC_DEPORTIVO);
            // 
            // gbEspais
            // 
            this.gbEspais.Controls.Add(this.dgvLlistaEspais);
            this.gbEspais.Location = new System.Drawing.Point(19, 275);
            this.gbEspais.Name = "gbEspais";
            this.gbEspais.Size = new System.Drawing.Size(384, 156);
            this.gbEspais.TabIndex = 5;
            this.gbEspais.TabStop = false;
            this.gbEspais.Text = "Espais";
            // 
            // gbHoraris
            // 
            this.gbHoraris.Controls.Add(this.dgvHoraris);
            this.gbHoraris.Location = new System.Drawing.Point(19, 122);
            this.gbHoraris.Name = "gbHoraris";
            this.gbHoraris.Size = new System.Drawing.Size(384, 147);
            this.gbHoraris.TabIndex = 6;
            this.gbHoraris.TabStop = false;
            this.gbHoraris.Text = "Horaris";
            // 
            // dgvHoraris
            // 
            this.dgvHoraris.AllowUserToAddRows = false;
            this.dgvHoraris.AllowUserToDeleteRows = false;
            this.dgvHoraris.AutoGenerateColumns = false;
            this.dgvHoraris.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHoraris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoraris.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaDataGridViewTextBoxColumn,
            this.horari_inici,
            this.horari_fi});
            this.dgvHoraris.DataSource = this.bindingSourceHoraris;
            this.dgvHoraris.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvHoraris.Location = new System.Drawing.Point(18, 21);
            this.dgvHoraris.Name = "dgvHoraris";
            this.dgvHoraris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHoraris.Size = new System.Drawing.Size(345, 109);
            this.dgvHoraris.TabIndex = 0;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horari_inici
            // 
            this.horari_inici.DataPropertyName = "horari_inici";
            this.horari_inici.HeaderText = "Obertura";
            this.horari_inici.Name = "horari_inici";
            // 
            // horari_fi
            // 
            this.horari_fi.DataPropertyName = "horari_fi";
            this.horari_fi.HeaderText = "Tancament";
            this.horari_fi.Name = "horari_fi";
            // 
            // bindingSourceHoraris
            // 
            this.bindingSourceHoraris.DataSource = typeof(EspaiActiu.HORARIS_INSTALACIO);
            // 
            // gbDetallsInstalacio
            // 
            this.gbDetallsInstalacio.Controls.Add(this.tbNomInstalacio);
            this.gbDetallsInstalacio.Controls.Add(this.gbHoraris);
            this.gbDetallsInstalacio.Controls.Add(this.lNom);
            this.gbDetallsInstalacio.Controls.Add(this.gbEspais);
            this.gbDetallsInstalacio.Controls.Add(this.lAdreca);
            this.gbDetallsInstalacio.Controls.Add(this.tbAdrecaInstalacio);
            this.gbDetallsInstalacio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetallsInstalacio.Location = new System.Drawing.Point(12, 13);
            this.gbDetallsInstalacio.Name = "gbDetallsInstalacio";
            this.gbDetallsInstalacio.Size = new System.Drawing.Size(432, 446);
            this.gbDetallsInstalacio.TabIndex = 7;
            this.gbDetallsInstalacio.TabStop = false;
            this.gbDetallsInstalacio.Text = "Dades instalació";
            // 
            // bModificar
            // 
            this.bModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(95)))));
            this.bModificar.Location = new System.Drawing.Point(292, 474);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(123, 23);
            this.bModificar.TabIndex = 8;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = false;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // hORARISINSTALACIOBindingSource
            // 
            this.hORARISINSTALACIOBindingSource.DataSource = typeof(EspaiActiu.HORARIS_INSTALACIO);
            // 
            // lLOCDEPORTIVOBindingSource
            // 
            this.lLOCDEPORTIVOBindingSource.DataSource = typeof(EspaiActiu.LLOC_DEPORTIVO);
            // 
            // FormDetallsInstalacions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 509);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.gbDetallsInstalacio);
            this.Name = "FormDetallsInstalacions";
            this.Text = "FormDetallsInstalacions";
            this.Load += new System.EventHandler(this.FormDetallsInstalacions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlistaEspais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).EndInit();
            this.gbEspais.ResumeLayout(false);
            this.gbHoraris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoraris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoraris)).EndInit();
            this.gbDetallsInstalacio.ResumeLayout(false);
            this.gbDetallsInstalacio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hORARISINSTALACIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLOCDEPORTIVOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lAdreca;
        private System.Windows.Forms.TextBox tbNomInstalacio;
        private System.Windows.Forms.TextBox tbAdrecaInstalacio;
        private System.Windows.Forms.DataGridView dgvLlistaEspais;
        private System.Windows.Forms.BindingSource bindingSourceEspais;
        private System.Windows.Forms.BindingSource lLOCDEPORTIVOBindingSource;
        private System.Windows.Forms.GroupBox gbEspais;
        private System.Windows.Forms.GroupBox gbHoraris;
        private System.Windows.Forms.DataGridView dgvHoraris;
        private System.Windows.Forms.BindingSource bindingSourceHoraris;
        private System.Windows.Forms.BindingSource hORARISINSTALACIOBindingSource;
        private System.Windows.Forms.GroupBox gbDetallsInstalacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horari_inici;
        private System.Windows.Forms.DataGridViewTextBoxColumn horari_fi;
        private System.Windows.Forms.BindingSource bindingSourceDias;
    }
}