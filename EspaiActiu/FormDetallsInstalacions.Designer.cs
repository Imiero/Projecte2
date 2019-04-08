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
            this.exteriorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceEspais = new System.Windows.Forms.BindingSource(this.components);
            this.gbEspais = new System.Windows.Forms.GroupBox();
            this.gbHoraris = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSourceHoraris = new System.Windows.Forms.BindingSource(this.components);
            this.hORARISINSTALACIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lLOCDEPORTIVOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDetallsInstalacio = new System.Windows.Forms.GroupBox();
            this.diaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horari_inici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horari_fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIESSETMANADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlistaEspais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).BeginInit();
            this.gbEspais.SuspendLayout();
            this.gbHoraris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoraris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hORARISINSTALACIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLOCDEPORTIVOBindingSource)).BeginInit();
            this.gbDetallsInstalacio.SuspendLayout();
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
            this.tbNomInstalacio.ReadOnly = true;
            this.tbNomInstalacio.Size = new System.Drawing.Size(286, 22);
            this.tbNomInstalacio.TabIndex = 2;
            // 
            // tbAdrecaInstalacio
            // 
            this.tbAdrecaInstalacio.Location = new System.Drawing.Point(96, 69);
            this.tbAdrecaInstalacio.Name = "tbAdrecaInstalacio";
            this.tbAdrecaInstalacio.ReadOnly = true;
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
            this.nomDataGridViewTextBoxColumn,
            this.exteriorDataGridViewCheckBoxColumn});
            this.dgvLlistaEspais.DataSource = this.bindingSourceEspais;
            this.dgvLlistaEspais.Location = new System.Drawing.Point(18, 28);
            this.dgvLlistaEspais.Name = "dgvLlistaEspais";
            this.dgvLlistaEspais.ReadOnly = true;
            this.dgvLlistaEspais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLlistaEspais.Size = new System.Drawing.Size(247, 106);
            this.dgvLlistaEspais.TabIndex = 4;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exteriorDataGridViewCheckBoxColumn
            // 
            this.exteriorDataGridViewCheckBoxColumn.DataPropertyName = "exterior";
            this.exteriorDataGridViewCheckBoxColumn.HeaderText = "Exterior";
            this.exteriorDataGridViewCheckBoxColumn.Name = "exteriorDataGridViewCheckBoxColumn";
            this.exteriorDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSourceEspais
            // 
            this.bindingSourceEspais.DataSource = typeof(LLOC_DEPORTIVO);
            // 
            // gbEspais
            // 
            this.gbEspais.Controls.Add(this.dgvLlistaEspais);
            this.gbEspais.Location = new System.Drawing.Point(59, 428);
            this.gbEspais.Name = "gbEspais";
            this.gbEspais.Size = new System.Drawing.Size(304, 151);
            this.gbEspais.TabIndex = 5;
            this.gbEspais.TabStop = false;
            this.gbEspais.Text = "Espais";
            // 
            // gbHoraris
            // 
            this.gbHoraris.Controls.Add(this.dataGridView1);
            this.gbHoraris.Location = new System.Drawing.Point(59, 122);
            this.gbHoraris.Name = "gbHoraris";
            this.gbHoraris.Size = new System.Drawing.Size(304, 300);
            this.gbHoraris.TabIndex = 6;
            this.gbHoraris.TabStop = false;
            this.gbHoraris.Text = "Horaris";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaDataGridViewTextBoxColumn,
            this.horari_inici,
            this.horari_fi,
            this.dIESSETMANADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceHoraris;
            this.dataGridView1.Location = new System.Drawing.Point(18, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(276, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // bindingSourceHoraris
            // 
            this.bindingSourceHoraris.DataSource = typeof(HORARIS_INSTALACIO);
            // 
            // hORARISINSTALACIOBindingSource
            // 
            this.hORARISINSTALACIOBindingSource.DataSource = typeof(HORARIS_INSTALACIO);
            // 
            // lLOCDEPORTIVOBindingSource
            // 
            this.lLOCDEPORTIVOBindingSource.DataSource = typeof(LLOC_DEPORTIVO);
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
            this.gbDetallsInstalacio.Size = new System.Drawing.Size(432, 585);
            this.gbDetallsInstalacio.TabIndex = 7;
            this.gbDetallsInstalacio.TabStop = false;
            this.gbDetallsInstalacio.Text = "Dades instalació";
            // 
            // diaDataGridViewTextBoxColumn
            // 
            this.diaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diaDataGridViewTextBoxColumn.DataPropertyName = "dia";
            this.diaDataGridViewTextBoxColumn.HeaderText = "dia";
            this.diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            this.diaDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaDataGridViewTextBoxColumn.Width = 50;
            // 
            // horari_inici
            // 
            this.horari_inici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horari_inici.DataPropertyName = "horari_inici";
            this.horari_inici.HeaderText = "Obertura";
            this.horari_inici.Name = "horari_inici";
            this.horari_inici.ReadOnly = true;
            this.horari_inici.Width = 83;
            // 
            // horari_fi
            // 
            this.horari_fi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horari_fi.DataPropertyName = "horari_fi";
            this.horari_fi.HeaderText = "Tancament";
            this.horari_fi.Name = "horari_fi";
            this.horari_fi.ReadOnly = true;
            this.horari_fi.Width = 96;
            // 
            // dIESSETMANADataGridViewTextBoxColumn
            // 
            this.dIESSETMANADataGridViewTextBoxColumn.DataPropertyName = "DIES_SETMANA";
            this.dIESSETMANADataGridViewTextBoxColumn.HeaderText = "DIES_SETMANA";
            this.dIESSETMANADataGridViewTextBoxColumn.Name = "dIESSETMANADataGridViewTextBoxColumn";
            this.dIESSETMANADataGridViewTextBoxColumn.ReadOnly = true;
            this.dIESSETMANADataGridViewTextBoxColumn.Visible = false;
            // 
            // FormDetallsInstalacions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 612);
            this.Controls.Add(this.gbDetallsInstalacio);
            this.Name = "FormDetallsInstalacions";
            this.Text = "FormDetallsInstalacions";
            this.Load += new System.EventHandler(this.FormDetallsInstalacions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLlistaEspais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEspais)).EndInit();
            this.gbEspais.ResumeLayout(false);
            this.gbHoraris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoraris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hORARISINSTALACIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lLOCDEPORTIVOBindingSource)).EndInit();
            this.gbDetallsInstalacio.ResumeLayout(false);
            this.gbDetallsInstalacio.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceHoraris;
        private System.Windows.Forms.BindingSource hORARISINSTALACIOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exteriorDataGridViewCheckBoxColumn;
        private System.Windows.Forms.GroupBox gbDetallsInstalacio;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horari_inici;
        private System.Windows.Forms.DataGridViewTextBoxColumn horari_fi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIESSETMANADataGridViewTextBoxColumn;
    }
}