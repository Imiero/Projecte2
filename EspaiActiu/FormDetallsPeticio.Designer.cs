﻿namespace EspaiActiu
{
    partial class FormDetallsPeticio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallsPeticio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDurada = new System.Windows.Forms.TextBox();
            this.textBoxEspai = new System.Windows.Forms.TextBox();
            this.textBoxEquip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTipusActivitat = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAcceptar = new System.Windows.Forms.Button();
            this.groupBoxHorari = new System.Windows.Forms.GroupBox();
            this.dataGridViewHorariDemanat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingSourceDias = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHorariDemanat = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDetallsEquip = new System.Windows.Forms.Button();
            this.buttonSortir = new System.Windows.Forms.Button();
            this.groupBoxPeticio = new System.Windows.Forms.GroupBox();
            this.dataGridViewHorariInstalacio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHorariInstalacio = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxInstalacio = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHorarisActivitats = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxHorariIns = new System.Windows.Forms.GroupBox();
            this.groupBoxHorari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariDemanat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorariDemanat)).BeginInit();
            this.groupBoxPeticio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariInstalacio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorariInstalacio)).BeginInit();
            this.groupBoxInstalacio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarisActivitats)).BeginInit();
            this.groupBoxHorariIns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Durada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Equip";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(90, 16);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(138, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDurada
            // 
            this.textBoxDurada.Enabled = false;
            this.textBoxDurada.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurada.Location = new System.Drawing.Point(90, 44);
            this.textBoxDurada.Name = "textBoxDurada";
            this.textBoxDurada.Size = new System.Drawing.Size(138, 20);
            this.textBoxDurada.TabIndex = 5;
            // 
            // textBoxEspai
            // 
            this.textBoxEspai.Enabled = false;
            this.textBoxEspai.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEspai.Location = new System.Drawing.Point(90, 103);
            this.textBoxEspai.Name = "textBoxEspai";
            this.textBoxEspai.Size = new System.Drawing.Size(138, 20);
            this.textBoxEspai.TabIndex = 6;
            // 
            // textBoxEquip
            // 
            this.textBoxEquip.Enabled = false;
            this.textBoxEquip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEquip.Location = new System.Drawing.Point(90, 72);
            this.textBoxEquip.Name = "textBoxEquip";
            this.textBoxEquip.Size = new System.Drawing.Size(138, 20);
            this.textBoxEquip.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipus d\'activitat";
            // 
            // textBoxTipusActivitat
            // 
            this.textBoxTipusActivitat.Enabled = false;
            this.textBoxTipusActivitat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTipusActivitat.Location = new System.Drawing.Point(90, 131);
            this.textBoxTipusActivitat.Name = "textBoxTipusActivitat";
            this.textBoxTipusActivitat.Size = new System.Drawing.Size(138, 20);
            this.textBoxTipusActivitat.TabIndex = 10;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.buttonCancelar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(762, 410);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 25);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Rebutjar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAcceptar
            // 
            this.buttonAcceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(212)))), ((int)(((byte)(97)))));
            this.buttonAcceptar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptar.Location = new System.Drawing.Point(681, 410);
            this.buttonAcceptar.Name = "buttonAcceptar";
            this.buttonAcceptar.Size = new System.Drawing.Size(75, 25);
            this.buttonAcceptar.TabIndex = 12;
            this.buttonAcceptar.Text = "Acceptar";
            this.buttonAcceptar.UseVisualStyleBackColor = false;
            this.buttonAcceptar.Click += new System.EventHandler(this.buttonAcceptar_Click);
            // 
            // groupBoxHorari
            // 
            this.groupBoxHorari.Controls.Add(this.dataGridViewHorariDemanat);
            this.groupBoxHorari.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHorari.Location = new System.Drawing.Point(6, 160);
            this.groupBoxHorari.Name = "groupBoxHorari";
            this.groupBoxHorari.Size = new System.Drawing.Size(261, 216);
            this.groupBoxHorari.TabIndex = 18;
            this.groupBoxHorari.TabStop = false;
            this.groupBoxHorari.Text = "Horari";
            // 
            // dataGridViewHorariDemanat
            // 
            this.dataGridViewHorariDemanat.AllowUserToAddRows = false;
            this.dataGridViewHorariDemanat.AllowUserToDeleteRows = false;
            this.dataGridViewHorariDemanat.AutoGenerateColumns = false;
            this.dataGridViewHorariDemanat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewHorariDemanat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorariDemanat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewHorariDemanat.DataSource = this.bindingSourceHorariDemanat;
            this.dataGridViewHorariDemanat.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewHorariDemanat.Name = "dataGridViewHorariDemanat";
            this.dataGridViewHorariDemanat.ReadOnly = true;
            this.dataGridViewHorariDemanat.Size = new System.Drawing.Size(244, 191);
            this.dataGridViewHorariDemanat.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dia";
            this.dataGridViewTextBoxColumn4.DataSource = this.bindingSourceDias;
            this.dataGridViewTextBoxColumn4.DisplayMember = "dia";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn4.HeaderText = "Dia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "id";
            this.dataGridViewTextBoxColumn4.Width = 47;
            // 
            // bindingSourceDias
            // 
            this.bindingSourceDias.DataSource = typeof(EspaiActiu.DIES_SETMANA);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "horari_inici";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inici";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "horari_fi";
            this.dataGridViewTextBoxColumn3.HeaderText = "Final";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bindingSourceHorariDemanat
            // 
            this.bindingSourceHorariDemanat.DataSource = typeof(EspaiActiu.HORARIS_ACT_DEMANADA);
            // 
            // buttonDetallsEquip
            // 
            this.buttonDetallsEquip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDetallsEquip.Location = new System.Drawing.Point(234, 72);
            this.buttonDetallsEquip.Name = "buttonDetallsEquip";
            this.buttonDetallsEquip.Size = new System.Drawing.Size(86, 20);
            this.buttonDetallsEquip.TabIndex = 0;
            this.buttonDetallsEquip.Text = "Detalls Equip";
            this.buttonDetallsEquip.UseVisualStyleBackColor = true;
            this.buttonDetallsEquip.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSortir
            // 
            this.buttonSortir.BackColor = System.Drawing.Color.Transparent;
            this.buttonSortir.Location = new System.Drawing.Point(843, 412);
            this.buttonSortir.Name = "buttonSortir";
            this.buttonSortir.Size = new System.Drawing.Size(75, 23);
            this.buttonSortir.TabIndex = 20;
            this.buttonSortir.Text = "Sortir";
            this.buttonSortir.UseVisualStyleBackColor = false;
            this.buttonSortir.Click += new System.EventHandler(this.buttonSortir_Click);
            // 
            // groupBoxPeticio
            // 
            this.groupBoxPeticio.Controls.Add(this.groupBoxHorari);
            this.groupBoxPeticio.Controls.Add(this.label1);
            this.groupBoxPeticio.Controls.Add(this.label2);
            this.groupBoxPeticio.Controls.Add(this.buttonDetallsEquip);
            this.groupBoxPeticio.Controls.Add(this.label3);
            this.groupBoxPeticio.Controls.Add(this.label4);
            this.groupBoxPeticio.Controls.Add(this.textBoxNombre);
            this.groupBoxPeticio.Controls.Add(this.textBoxTipusActivitat);
            this.groupBoxPeticio.Controls.Add(this.textBoxDurada);
            this.groupBoxPeticio.Controls.Add(this.label5);
            this.groupBoxPeticio.Controls.Add(this.textBoxEspai);
            this.groupBoxPeticio.Controls.Add(this.textBoxEquip);
            this.groupBoxPeticio.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPeticio.Name = "groupBoxPeticio";
            this.groupBoxPeticio.Size = new System.Drawing.Size(340, 392);
            this.groupBoxPeticio.TabIndex = 21;
            this.groupBoxPeticio.TabStop = false;
            this.groupBoxPeticio.Text = "Dades peticio";
            // 
            // dataGridViewHorariInstalacio
            // 
            this.dataGridViewHorariInstalacio.AllowUserToAddRows = false;
            this.dataGridViewHorariInstalacio.AllowUserToDeleteRows = false;
            this.dataGridViewHorariInstalacio.AutoGenerateColumns = false;
            this.dataGridViewHorariInstalacio.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewHorariInstalacio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHorariInstalacio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dataGridViewHorariInstalacio.DataSource = this.bindingSourceHorariInstalacio;
            this.dataGridViewHorariInstalacio.Location = new System.Drawing.Point(0, 14);
            this.dataGridViewHorariInstalacio.Name = "dataGridViewHorariInstalacio";
            this.dataGridViewHorariInstalacio.ReadOnly = true;
            this.dataGridViewHorariInstalacio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHorariInstalacio.Size = new System.Drawing.Size(250, 346);
            this.dataGridViewHorariInstalacio.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dia";
            this.dataGridViewTextBoxColumn11.DataSource = this.bindingSourceDias;
            this.dataGridViewTextBoxColumn11.DisplayMember = "dia";
            this.dataGridViewTextBoxColumn11.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn11.HeaderText = "Dia";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn11.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "horari_inici";
            this.dataGridViewTextBoxColumn9.HeaderText = "Inici";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "horari_fi";
            this.dataGridViewTextBoxColumn10.HeaderText = "Final";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 54;
            // 
            // bindingSourceHorariInstalacio
            // 
            this.bindingSourceHorariInstalacio.DataSource = typeof(EspaiActiu.HORARIS_INSTALACIO);
            // 
            // groupBoxInstalacio
            // 
            this.groupBoxInstalacio.Controls.Add(this.groupBox1);
            this.groupBoxInstalacio.Controls.Add(this.groupBoxHorariIns);
            this.groupBoxInstalacio.Location = new System.Drawing.Point(384, 12);
            this.groupBoxInstalacio.Name = "groupBoxInstalacio";
            this.groupBoxInstalacio.Size = new System.Drawing.Size(541, 392);
            this.groupBoxInstalacio.TabIndex = 23;
            this.groupBoxInstalacio.TabStop = false;
            this.groupBoxInstalacio.Text = "Dades instalacio";
            this.groupBoxInstalacio.Enter += new System.EventHandler(this.groupBoxInstalacio_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(279, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 250);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horaris ocupats";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView2.DataSource = this.bindingSourceHorarisActivitats;
            this.dataGridView2.Location = new System.Drawing.Point(0, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(250, 226);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "dia";
            this.dataGridViewTextBoxColumn16.DataSource = this.bindingSourceDias;
            this.dataGridViewTextBoxColumn16.DisplayMember = "dia";
            this.dataGridViewTextBoxColumn16.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn16.HeaderText = "Dia";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn16.ValueMember = "id";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "horari_inici";
            this.dataGridViewTextBoxColumn14.HeaderText = "Inici";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "horari_fi";
            this.dataGridViewTextBoxColumn15.HeaderText = "Final";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 54;
            // 
            // bindingSourceHorarisActivitats
            // 
            this.bindingSourceHorarisActivitats.DataSource = typeof(EspaiActiu.HORARIS_ACTIVITAT);
            // 
            // groupBoxHorariIns
            // 
            this.groupBoxHorariIns.Controls.Add(this.dataGridViewHorariInstalacio);
            this.groupBoxHorariIns.Location = new System.Drawing.Point(6, 19);
            this.groupBoxHorariIns.Name = "groupBoxHorariIns";
            this.groupBoxHorariIns.Size = new System.Drawing.Size(255, 370);
            this.groupBoxHorariIns.TabIndex = 23;
            this.groupBoxHorariIns.TabStop = false;
            this.groupBoxHorariIns.Text = "Horari";
            // 
            // FormDetallsPeticio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 440);
            this.Controls.Add(this.groupBoxInstalacio);
            this.Controls.Add(this.groupBoxPeticio);
            this.Controls.Add(this.buttonSortir);
            this.Controls.Add(this.buttonAcceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDetallsPeticio";
            this.Text = "Detalls Peticio";
            this.Activated += new System.EventHandler(this.FormDetallsPeticio_Activated);
            this.Load += new System.EventHandler(this.FormDetallsPeticio_Load);
            this.groupBoxHorari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariDemanat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorariDemanat)).EndInit();
            this.groupBoxPeticio.ResumeLayout(false);
            this.groupBoxPeticio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHorariInstalacio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorariInstalacio)).EndInit();
            this.groupBoxInstalacio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHorarisActivitats)).EndInit();
            this.groupBoxHorariIns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDurada;
        private System.Windows.Forms.TextBox textBoxEspai;
        private System.Windows.Forms.TextBox textBoxEquip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTipusActivitat;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAcceptar;
        private System.Windows.Forms.GroupBox groupBoxHorari;
        private System.Windows.Forms.Button buttonDetallsEquip;
        private System.Windows.Forms.Button buttonSortir;
        private System.Windows.Forms.DataGridView dataGridViewHorariDemanat;
        private System.Windows.Forms.BindingSource bindingSourceHorariDemanat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariiniciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarifiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idactividaddemanadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIVIDADESDEMANADASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIESSETMANADataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxPeticio;
        private System.Windows.Forms.DataGridView dataGridViewHorariInstalacio;
        private System.Windows.Forms.BindingSource bindingSourceHorariInstalacio;
        private System.Windows.Forms.GroupBox groupBoxInstalacio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBoxHorariIns;
        private System.Windows.Forms.BindingSource bindingSourceHorarisActivitats;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariiniciDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarifiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horariiniciDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarifiDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bindingSourceDias;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}