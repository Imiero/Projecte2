namespace EspaiActiu
{
    partial class FormDetallsEntitat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallsEntitat));
            this.lEquips = new System.Windows.Forms.Label();
            this.bSortir = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.lTelefon = new System.Windows.Forms.Label();
            this.lNIF = new System.Windows.Forms.Label();
            this.lAdreça = new System.Windows.Forms.Label();
            this.lNomEntitat = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCorreu = new System.Windows.Forms.TextBox();
            this.textBoxAdreça = new System.Windows.Forms.TextBox();
            this.textBoxNIF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.pictureBoxNuevoTelefono = new System.Windows.Forms.PictureBox();
            this.pictureBoxNouEquip = new System.Windows.Forms.PictureBox();
            this.bindingSourceTelefons = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxTelefons = new System.Windows.Forms.ListBox();
            this.bindingSourceEquips = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxEquips = new System.Windows.Forms.ListBox();
            this.pictureBoxBorrarTele = new System.Windows.Forms.PictureBox();
            this.pictureBoxBorrarEquipo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevoTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNouEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEquips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrarTele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrarEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lEquips
            // 
            this.lEquips.AutoSize = true;
            this.lEquips.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEquips.Location = new System.Drawing.Point(9, 282);
            this.lEquips.Name = "lEquips";
            this.lEquips.Size = new System.Drawing.Size(42, 14);
            this.lEquips.TabIndex = 58;
            this.lEquips.Text = "Equips:";
            // 
            // bSortir
            // 
            this.bSortir.Location = new System.Drawing.Point(359, 436);
            this.bSortir.Name = "bSortir";
            this.bSortir.Size = new System.Drawing.Size(92, 34);
            this.bSortir.TabIndex = 56;
            this.bSortir.Text = "Sortir";
            this.bSortir.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(260, 436);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(92, 34);
            this.bEditar.TabIndex = 55;
            this.bEditar.Text = "Editar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // lTelefon
            // 
            this.lTelefon.AutoSize = true;
            this.lTelefon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefon.Location = new System.Drawing.Point(9, 204);
            this.lTelefon.Name = "lTelefon";
            this.lTelefon.Size = new System.Drawing.Size(51, 14);
            this.lTelefon.TabIndex = 54;
            this.lTelefon.Text = "Telèfons:";
            this.lTelefon.Click += new System.EventHandler(this.lTelefon_Click);
            // 
            // lNIF
            // 
            this.lNIF.AutoSize = true;
            this.lNIF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNIF.Location = new System.Drawing.Point(9, 148);
            this.lNIF.Name = "lNIF";
            this.lNIF.Size = new System.Drawing.Size(22, 14);
            this.lNIF.TabIndex = 53;
            this.lNIF.Text = "NIF";
            this.lNIF.Click += new System.EventHandler(this.lNIF_Click);
            // 
            // lAdreça
            // 
            this.lAdreça.AutoSize = true;
            this.lAdreça.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAdreça.Location = new System.Drawing.Point(9, 120);
            this.lAdreça.Name = "lAdreça";
            this.lAdreça.Size = new System.Drawing.Size(43, 14);
            this.lAdreça.TabIndex = 52;
            this.lAdreça.Text = "Adreça";
            this.lAdreça.Click += new System.EventHandler(this.lAdreça_Click);
            // 
            // lNomEntitat
            // 
            this.lNomEntitat.AutoSize = true;
            this.lNomEntitat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNomEntitat.Location = new System.Drawing.Point(12, 19);
            this.lNomEntitat.Name = "lNomEntitat";
            this.lNomEntitat.Size = new System.Drawing.Size(116, 24);
            this.lNomEntitat.TabIndex = 49;
            this.lNomEntitat.Text = "Nom entitat";
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(95)))));
            this.buttonModificar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Location = new System.Drawing.Point(182, 373);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(75, 25);
            this.buttonModificar.TabIndex = 60;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(76, 64);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(181, 20);
            this.textBoxNom.TabIndex = 61;
            // 
            // textBoxCorreu
            // 
            this.textBoxCorreu.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreu.Location = new System.Drawing.Point(76, 92);
            this.textBoxCorreu.Name = "textBoxCorreu";
            this.textBoxCorreu.Size = new System.Drawing.Size(181, 20);
            this.textBoxCorreu.TabIndex = 62;
            // 
            // textBoxAdreça
            // 
            this.textBoxAdreça.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdreça.Location = new System.Drawing.Point(76, 116);
            this.textBoxAdreça.Name = "textBoxAdreça";
            this.textBoxAdreça.Size = new System.Drawing.Size(181, 20);
            this.textBoxAdreça.TabIndex = 63;
            // 
            // textBoxNIF
            // 
            this.textBoxNIF.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIF.Location = new System.Drawing.Point(76, 144);
            this.textBoxNIF.Name = "textBoxNIF";
            this.textBoxNIF.Size = new System.Drawing.Size(181, 20);
            this.textBoxNIF.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 14);
            this.label2.TabIndex = 66;
            this.label2.Text = "Correu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 67;
            this.label3.Text = "Temporada";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTemp.Location = new System.Drawing.Point(76, 173);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(181, 20);
            this.textBoxTemp.TabIndex = 68;
            // 
            // pictureBoxNuevoTelefono
            // 
            this.pictureBoxNuevoTelefono.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNuevoTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxNuevoTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNuevoTelefono.Image = global::EspaiActiu.Properties.Resources.plus1;
            this.pictureBoxNuevoTelefono.Location = new System.Drawing.Point(238, 261);
            this.pictureBoxNuevoTelefono.Name = "pictureBoxNuevoTelefono";
            this.pictureBoxNuevoTelefono.Size = new System.Drawing.Size(19, 20);
            this.pictureBoxNuevoTelefono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNuevoTelefono.TabIndex = 69;
            this.pictureBoxNuevoTelefono.TabStop = false;
            this.pictureBoxNuevoTelefono.Click += new System.EventHandler(this.pictureBoxNuevoTelefono_Click);
            // 
            // pictureBoxNouEquip
            // 
            this.pictureBoxNouEquip.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNouEquip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxNouEquip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxNouEquip.Image = global::EspaiActiu.Properties.Resources.plus1;
            this.pictureBoxNouEquip.Location = new System.Drawing.Point(238, 339);
            this.pictureBoxNouEquip.Name = "pictureBoxNouEquip";
            this.pictureBoxNouEquip.Size = new System.Drawing.Size(19, 20);
            this.pictureBoxNouEquip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNouEquip.TabIndex = 70;
            this.pictureBoxNouEquip.TabStop = false;
            this.pictureBoxNouEquip.Click += new System.EventHandler(this.pictureBoxNouEquip_Click);
            // 
            // bindingSourceTelefons
            // 
            this.bindingSourceTelefons.DataSource = typeof(EspaiActiu.TELEFONS);
            // 
            // listBoxTelefons
            // 
            this.listBoxTelefons.DataSource = this.bindingSourceTelefons;
            this.listBoxTelefons.DisplayMember = "telefono";
            this.listBoxTelefons.FormattingEnabled = true;
            this.listBoxTelefons.ItemHeight = 14;
            this.listBoxTelefons.Location = new System.Drawing.Point(12, 221);
            this.listBoxTelefons.Name = "listBoxTelefons";
            this.listBoxTelefons.Size = new System.Drawing.Size(245, 60);
            this.listBoxTelefons.TabIndex = 71;
            this.listBoxTelefons.ValueMember = "id";
            this.listBoxTelefons.SelectedIndexChanged += new System.EventHandler(this.listBoxTelefons_SelectedIndexChanged);
            this.listBoxTelefons.DoubleClick += new System.EventHandler(this.listBoxTelefons_DoubleClick);
            this.listBoxTelefons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTelefons_KeyDown);
            // 
            // bindingSourceEquips
            // 
            this.bindingSourceEquips.DataSource = typeof(EspaiActiu.EQUIPS);
            // 
            // listBoxEquips
            // 
            this.listBoxEquips.DataSource = this.bindingSourceEquips;
            this.listBoxEquips.DisplayMember = "nom";
            this.listBoxEquips.FormattingEnabled = true;
            this.listBoxEquips.ItemHeight = 14;
            this.listBoxEquips.Location = new System.Drawing.Point(12, 299);
            this.listBoxEquips.Name = "listBoxEquips";
            this.listBoxEquips.Size = new System.Drawing.Size(245, 60);
            this.listBoxEquips.TabIndex = 72;
            this.listBoxEquips.ValueMember = "id";
            this.listBoxEquips.SelectedIndexChanged += new System.EventHandler(this.listBoxEquips_SelectedIndexChanged);
            this.listBoxEquips.DoubleClick += new System.EventHandler(this.listBoxEquips_DoubleClick);
            this.listBoxEquips.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxEquips_KeyDown);
            // 
            // pictureBoxBorrarTele
            // 
            this.pictureBoxBorrarTele.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBorrarTele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBorrarTele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBorrarTele.Image = global::EspaiActiu.Properties.Resources.buttonminus;
            this.pictureBoxBorrarTele.Location = new System.Drawing.Point(213, 261);
            this.pictureBoxBorrarTele.Name = "pictureBoxBorrarTele";
            this.pictureBoxBorrarTele.Size = new System.Drawing.Size(19, 20);
            this.pictureBoxBorrarTele.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBorrarTele.TabIndex = 73;
            this.pictureBoxBorrarTele.TabStop = false;
            this.pictureBoxBorrarTele.Click += new System.EventHandler(this.pictureBoxBorrarTele_Click);
            // 
            // pictureBoxBorrarEquipo
            // 
            this.pictureBoxBorrarEquipo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBorrarEquipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxBorrarEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBorrarEquipo.Image = global::EspaiActiu.Properties.Resources.buttonminus;
            this.pictureBoxBorrarEquipo.Location = new System.Drawing.Point(213, 339);
            this.pictureBoxBorrarEquipo.Name = "pictureBoxBorrarEquipo";
            this.pictureBoxBorrarEquipo.Size = new System.Drawing.Size(19, 20);
            this.pictureBoxBorrarEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBorrarEquipo.TabIndex = 74;
            this.pictureBoxBorrarEquipo.TabStop = false;
            this.pictureBoxBorrarEquipo.Click += new System.EventHandler(this.pictureBoxBorrarEquipo_Click);
            // 
            // FormDetallsEntitat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 410);
            this.Controls.Add(this.pictureBoxBorrarEquipo);
            this.Controls.Add(this.pictureBoxBorrarTele);
            this.Controls.Add(this.pictureBoxNouEquip);
            this.Controls.Add(this.pictureBoxNuevoTelefono);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNIF);
            this.Controls.Add(this.textBoxAdreça);
            this.Controls.Add(this.textBoxCorreu);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.lEquips);
            this.Controls.Add(this.bSortir);
            this.Controls.Add(this.bEditar);
            this.Controls.Add(this.lTelefon);
            this.Controls.Add(this.lNIF);
            this.Controls.Add(this.lAdreça);
            this.Controls.Add(this.lNomEntitat);
            this.Controls.Add(this.listBoxTelefons);
            this.Controls.Add(this.listBoxEquips);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDetallsEntitat";
            this.Text = "FormDetallsEntitat";
            this.Activated += new System.EventHandler(this.FormDetallsEntitat_Activated);
            this.Load += new System.EventHandler(this.FormDetallsEntitat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNuevoTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNouEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTelefons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEquips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrarTele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrarEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEquips;
        private System.Windows.Forms.Button bSortir;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Label lTelefon;
        private System.Windows.Forms.Label lNIF;
        private System.Windows.Forms.Label lAdreça;
        private System.Windows.Forms.Label lNomEntitat;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCorreu;
        private System.Windows.Forms.TextBox textBoxAdreça;
        private System.Windows.Forms.TextBox textBoxNIF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.PictureBox pictureBoxNuevoTelefono;
        private System.Windows.Forms.PictureBox pictureBoxNouEquip;
        private System.Windows.Forms.BindingSource bindingSourceTelefons;
        private System.Windows.Forms.ListBox listBoxTelefons;
        private System.Windows.Forms.BindingSource bindingSourceEquips;
        private System.Windows.Forms.ListBox listBoxEquips;
        private System.Windows.Forms.PictureBox pictureBoxBorrarTele;
        private System.Windows.Forms.PictureBox pictureBoxBorrarEquipo;
    }
}