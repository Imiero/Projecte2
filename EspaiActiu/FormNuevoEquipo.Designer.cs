namespace EspaiActiu
{
    partial class FormNuevoEquipo
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
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBoxEsport = new System.Windows.Forms.ComboBox();
            this.bindingSourceEsport = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCompeticio = new System.Windows.Forms.ComboBox();
            this.bindingSourceCompeticio = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.bindingSourceCategoria = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxCategoriaEdat = new System.Windows.Forms.ComboBox();
            this.bindingSourceEdat = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.bindingSourceSexe = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEsport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompeticio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEdat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSexe)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(80, 12);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(180, 20);
            this.textBoxNom.TabIndex = 0;
            // 
            // comboBoxEsport
            // 
            this.comboBoxEsport.DataSource = this.bindingSourceEsport;
            this.comboBoxEsport.DisplayMember = "nom";
            this.comboBoxEsport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEsport.FormattingEnabled = true;
            this.comboBoxEsport.Location = new System.Drawing.Point(80, 39);
            this.comboBoxEsport.Name = "comboBoxEsport";
            this.comboBoxEsport.Size = new System.Drawing.Size(180, 21);
            this.comboBoxEsport.TabIndex = 1;
            this.comboBoxEsport.ValueMember = "id";
            // 
            // bindingSourceEsport
            // 
            this.bindingSourceEsport.DataSource = typeof(SPORTS);
            // 
            // comboBoxCompeticio
            // 
            this.comboBoxCompeticio.DataSource = this.bindingSourceCompeticio;
            this.comboBoxCompeticio.DisplayMember = "nom";
            this.comboBoxCompeticio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompeticio.FormattingEnabled = true;
            this.comboBoxCompeticio.Location = new System.Drawing.Point(80, 67);
            this.comboBoxCompeticio.Name = "comboBoxCompeticio";
            this.comboBoxCompeticio.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCompeticio.TabIndex = 2;
            this.comboBoxCompeticio.ValueMember = "id";
            // 
            // bindingSourceCompeticio
            // 
            this.bindingSourceCompeticio.DataSource = typeof(COMPETICIO);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DataSource = this.bindingSourceCategoria;
            this.comboBoxCategoria.DisplayMember = "nom";
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(80, 95);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCategoria.TabIndex = 3;
            this.comboBoxCategoria.ValueMember = "id";
            // 
            // bindingSourceCategoria
            // 
            this.bindingSourceCategoria.DataSource = typeof(CATEGORIA_NIVELL);
            // 
            // comboBoxCategoriaEdat
            // 
            this.comboBoxCategoriaEdat.DataSource = this.bindingSourceEdat;
            this.comboBoxCategoriaEdat.DisplayMember = "nom";
            this.comboBoxCategoriaEdat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoriaEdat.FormattingEnabled = true;
            this.comboBoxCategoriaEdat.Location = new System.Drawing.Point(80, 123);
            this.comboBoxCategoriaEdat.Name = "comboBoxCategoriaEdat";
            this.comboBoxCategoriaEdat.Size = new System.Drawing.Size(180, 21);
            this.comboBoxCategoriaEdat.TabIndex = 4;
            this.comboBoxCategoriaEdat.ValueMember = "id";
            // 
            // bindingSourceEdat
            // 
            this.bindingSourceEdat.DataSource = typeof(CATEGORIA_EDAT);
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.DataSource = this.bindingSourceSexe;
            this.comboBoxSexe.DisplayMember = "nom";
            this.comboBoxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(80, 151);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSexe.TabIndex = 5;
            this.comboBoxSexe.ValueMember = "id";
            // 
            // bindingSourceSexe
            // 
            this.bindingSourceSexe.DataSource = typeof(SEXE);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Esport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Competició";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Edat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Sexe";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(185, 193);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(104, 193);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 13;
            this.buttonAceptar.Text = "Acceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(104, 193);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonModificar.TabIndex = 14;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Visible = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // FormNuevoEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 228);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.comboBoxCategoriaEdat);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxCompeticio);
            this.Controls.Add(this.comboBoxEsport);
            this.Controls.Add(this.textBoxNom);
            this.Name = "FormNuevoEquipo";
            this.Text = "NuevoEquipo";
            this.Load += new System.EventHandler(this.FormNuevoEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEsport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCompeticio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEdat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSexe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBoxEsport;
        private System.Windows.Forms.ComboBox comboBoxCompeticio;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoriaEdat;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.BindingSource bindingSourceEsport;
        private System.Windows.Forms.BindingSource bindingSourceCompeticio;
        private System.Windows.Forms.BindingSource bindingSourceCategoria;
        private System.Windows.Forms.BindingSource bindingSourceEdat;
        private System.Windows.Forms.BindingSource bindingSourceSexe;
        private System.Windows.Forms.Button buttonModificar;
    }
}