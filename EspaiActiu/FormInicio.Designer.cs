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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.SidePanel = new System.Windows.Forms.Panel();
            this.EntitatsPanel = new System.Windows.Forms.Panel();
            this.EntitatsImage = new System.Windows.Forms.PictureBox();
            this.Entitatslabel = new System.Windows.Forms.Label();
            this.EspaLabel = new System.Windows.Forms.Label();
            this.EspaisLabel = new System.Windows.Forms.Panel();
            this.EspaiImage = new System.Windows.Forms.PictureBox();
            this.Petilabel = new System.Windows.Forms.Label();
            this.PetiPanel = new System.Windows.Forms.Panel();
            this.PetiImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePeticions = new System.Windows.Forms.TabPage();
            this.GroupBoxPeticio = new System.Windows.Forms.GroupBox();
            this.dataGridViewPeticio = new System.Windows.Forms.DataGridView();
            this.buttonBuscarPeticion = new System.Windows.Forms.Button();
            this.textBoxBuscarPeticion = new System.Windows.Forms.TextBox();
            this.tabPageEspais = new System.Windows.Forms.TabPage();
            this.buttonAddEspai = new System.Windows.Forms.Button();
            this.groupBoxEspais = new System.Windows.Forms.GroupBox();
            this.dataGridViewEspais = new System.Windows.Forms.DataGridView();
            this.buttonCercarEspais = new System.Windows.Forms.Button();
            this.textBoxCercarEspais = new System.Windows.Forms.TextBox();
            this.tabPageEquips = new System.Windows.Forms.TabPage();
            this.buttonAddEntitat = new System.Windows.Forms.Button();
            this.groupBoxEntitats = new System.Windows.Forms.GroupBox();
            this.dataGridViewEntitats = new System.Windows.Forms.DataGridView();
            this.buttonCercarEntitat = new System.Windows.Forms.Button();
            this.textBoxCercarEntitats = new System.Windows.Forms.TextBox();
            this.tabPageModificacion = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.EntitatsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntitatsImage)).BeginInit();
            this.EspaisLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspaiImage)).BeginInit();
            this.PetiPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetiImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPagePeticions.SuspendLayout();
            this.GroupBoxPeticio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeticio)).BeginInit();
            this.tabPageEspais.SuspendLayout();
            this.groupBoxEspais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspais)).BeginInit();
            this.tabPageEquips.SuspendLayout();
            this.groupBoxEntitats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntitats)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(160)))), ((int)(((byte)(56)))));
            this.SidePanel.Controls.Add(this.EntitatsPanel);
            this.SidePanel.Controls.Add(this.EspaLabel);
            this.SidePanel.Controls.Add(this.EspaisLabel);
            this.SidePanel.Controls.Add(this.Petilabel);
            this.SidePanel.Controls.Add(this.PetiPanel);
            this.SidePanel.Controls.Add(this.panel1);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(358, 995);
            this.SidePanel.TabIndex = 1;
            // 
            // EntitatsPanel
            // 
            this.EntitatsPanel.Controls.Add(this.EntitatsImage);
            this.EntitatsPanel.Controls.Add(this.Entitatslabel);
            this.EntitatsPanel.Location = new System.Drawing.Point(2, 604);
            this.EntitatsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.EntitatsPanel.Name = "EntitatsPanel";
            this.EntitatsPanel.Size = new System.Drawing.Size(353, 117);
            this.EntitatsPanel.TabIndex = 9;
            this.EntitatsPanel.Click += new System.EventHandler(this.EquipsPanel_Click);
            // 
            // EntitatsImage
            // 
            this.EntitatsImage.ErrorImage = global::EspaiActiu.Properties.Resources.logo_principal_color;
            this.EntitatsImage.Image = global::EspaiActiu.Properties.Resources.entitats_tab;
            this.EntitatsImage.Location = new System.Drawing.Point(30, 32);
            this.EntitatsImage.Margin = new System.Windows.Forms.Padding(2);
            this.EntitatsImage.Name = "EntitatsImage";
            this.EntitatsImage.Size = new System.Drawing.Size(52, 52);
            this.EntitatsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EntitatsImage.TabIndex = 7;
            this.EntitatsImage.TabStop = false;
            this.EntitatsImage.Click += new System.EventHandler(this.EquipsImage_Click);
            // 
            // Entitatslabel
            // 
            this.Entitatslabel.AutoSize = true;
            this.Entitatslabel.Font = new System.Drawing.Font("Arial", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entitatslabel.Location = new System.Drawing.Point(130, 37);
            this.Entitatslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Entitatslabel.Name = "Entitatslabel";
            this.Entitatslabel.Size = new System.Drawing.Size(171, 47);
            this.Entitatslabel.TabIndex = 8;
            this.Entitatslabel.Text = "Entitats";
            this.Entitatslabel.Click += new System.EventHandler(this.Equipslabel_Click);
            // 
            // EspaLabel
            // 
            this.EspaLabel.AutoSize = true;
            this.EspaLabel.Font = new System.Drawing.Font("Arial", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspaLabel.Location = new System.Drawing.Point(133, 512);
            this.EspaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EspaLabel.Name = "EspaLabel";
            this.EspaLabel.Size = new System.Drawing.Size(152, 47);
            this.EspaLabel.TabIndex = 5;
            this.EspaLabel.Text = "Espais";
            this.EspaLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // EspaisLabel
            // 
            this.EspaisLabel.Controls.Add(this.EspaiImage);
            this.EspaisLabel.Location = new System.Drawing.Point(3, 481);
            this.EspaisLabel.Margin = new System.Windows.Forms.Padding(2);
            this.EspaisLabel.Name = "EspaisLabel";
            this.EspaisLabel.Size = new System.Drawing.Size(353, 117);
            this.EspaisLabel.TabIndex = 6;
            this.EspaisLabel.Click += new System.EventHandler(this.panel3_Click);
            // 
            // EspaiImage
            // 
            this.EspaiImage.ErrorImage = global::EspaiActiu.Properties.Resources.logo_principal_color;
            this.EspaiImage.Image = global::EspaiActiu.Properties.Resources.espais_tab;
            this.EspaiImage.Location = new System.Drawing.Point(29, 31);
            this.EspaiImage.Margin = new System.Windows.Forms.Padding(2);
            this.EspaiImage.Name = "EspaiImage";
            this.EspaiImage.Size = new System.Drawing.Size(52, 52);
            this.EspaiImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspaiImage.TabIndex = 4;
            this.EspaiImage.TabStop = false;
            this.EspaiImage.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Petilabel
            // 
            this.Petilabel.AutoSize = true;
            this.Petilabel.Font = new System.Drawing.Font("Arial", 20.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petilabel.Location = new System.Drawing.Point(132, 387);
            this.Petilabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Petilabel.Name = "Petilabel";
            this.Petilabel.Size = new System.Drawing.Size(202, 47);
            this.Petilabel.TabIndex = 3;
            this.Petilabel.Text = "Peticións";
            this.Petilabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PetiPanel
            // 
            this.PetiPanel.Controls.Add(this.PetiImage);
            this.PetiPanel.Location = new System.Drawing.Point(2, 356);
            this.PetiPanel.Margin = new System.Windows.Forms.Padding(2);
            this.PetiPanel.Name = "PetiPanel";
            this.PetiPanel.Size = new System.Drawing.Size(353, 117);
            this.PetiPanel.TabIndex = 3;
            this.PetiPanel.Click += new System.EventHandler(this.panel2_Click);
            // 
            // PetiImage
            // 
            this.PetiImage.ErrorImage = global::EspaiActiu.Properties.Resources.logo_principal_color;
            this.PetiImage.Image = global::EspaiActiu.Properties.Resources.new_tab;
            this.PetiImage.Location = new System.Drawing.Point(30, 31);
            this.PetiImage.Margin = new System.Windows.Forms.Padding(2);
            this.PetiImage.Name = "PetiImage";
            this.PetiImage.Size = new System.Drawing.Size(52, 52);
            this.PetiImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PetiImage.TabIndex = 0;
            this.PetiImage.TabStop = false;
            this.PetiImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 139);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EspaiActiu.Properties.Resources.logo_principal_color;
            this.pictureBoxLogo.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(421, 146);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPagePeticions);
            this.tabControl1.Controls.Add(this.tabPageEspais);
            this.tabControl1.Controls.Add(this.tabPageEquips);
            this.tabControl1.Controls.Add(this.tabPageModificacion);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 10);
            this.tabControl1.Location = new System.Drawing.Point(358, 142);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 851);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPagePeticions
            // 
            this.tabPagePeticions.BackColor = System.Drawing.SystemColors.Window;
            this.tabPagePeticions.Controls.Add(this.GroupBoxPeticio);
            this.tabPagePeticions.Controls.Add(this.buttonBuscarPeticion);
            this.tabPagePeticions.Controls.Add(this.textBoxBuscarPeticion);
            this.tabPagePeticions.Location = new System.Drawing.Point(4, 14);
            this.tabPagePeticions.Margin = new System.Windows.Forms.Padding(2);
            this.tabPagePeticions.Name = "tabPagePeticions";
            this.tabPagePeticions.Padding = new System.Windows.Forms.Padding(2);
            this.tabPagePeticions.Size = new System.Drawing.Size(1449, 833);
            this.tabPagePeticions.TabIndex = 0;
            this.tabPagePeticions.Text = "tabPage1";
            // 
            // GroupBoxPeticio
            // 
            this.GroupBoxPeticio.Controls.Add(this.dataGridViewPeticio);
            this.GroupBoxPeticio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxPeticio.Location = new System.Drawing.Point(33, 99);
            this.GroupBoxPeticio.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBoxPeticio.Name = "GroupBoxPeticio";
            this.GroupBoxPeticio.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBoxPeticio.Size = new System.Drawing.Size(804, 511);
            this.GroupBoxPeticio.TabIndex = 3;
            this.GroupBoxPeticio.TabStop = false;
            this.GroupBoxPeticio.Text = "Nou Peticións";
            // 
            // dataGridViewPeticio
            // 
            this.dataGridViewPeticio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeticio.Location = new System.Drawing.Point(23, 37);
            this.dataGridViewPeticio.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPeticio.Name = "dataGridViewPeticio";
            this.dataGridViewPeticio.RowTemplate.Height = 31;
            this.dataGridViewPeticio.Size = new System.Drawing.Size(761, 452);
            this.dataGridViewPeticio.TabIndex = 0;
            // 
            // buttonBuscarPeticion
            // 
            this.buttonBuscarPeticion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarPeticion.Location = new System.Drawing.Point(720, 33);
            this.buttonBuscarPeticion.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarPeticion.Name = "buttonBuscarPeticion";
            this.buttonBuscarPeticion.Size = new System.Drawing.Size(77, 41);
            this.buttonBuscarPeticion.TabIndex = 2;
            this.buttonBuscarPeticion.Text = "Cercar";
            this.buttonBuscarPeticion.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPeticion
            // 
            this.textBoxBuscarPeticion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscarPeticion.Location = new System.Drawing.Point(188, 44);
            this.textBoxBuscarPeticion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarPeticion.Name = "textBoxBuscarPeticion";
            this.textBoxBuscarPeticion.Size = new System.Drawing.Size(473, 26);
            this.textBoxBuscarPeticion.TabIndex = 1;
            // 
            // tabPageEspais
            // 
            this.tabPageEspais.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEspais.Controls.Add(this.buttonAddEspai);
            this.tabPageEspais.Controls.Add(this.groupBoxEspais);
            this.tabPageEspais.Controls.Add(this.buttonCercarEspais);
            this.tabPageEspais.Controls.Add(this.textBoxCercarEspais);
            this.tabPageEspais.Location = new System.Drawing.Point(4, 14);
            this.tabPageEspais.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEspais.Name = "tabPageEspais";
            this.tabPageEspais.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEspais.Size = new System.Drawing.Size(1449, 833);
            this.tabPageEspais.TabIndex = 1;
            this.tabPageEspais.Text = "tabPage2";
            // 
            // buttonAddEspai
            // 
            this.buttonAddEspai.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEspai.Location = new System.Drawing.Point(673, 652);
            this.buttonAddEspai.Name = "buttonAddEspai";
            this.buttonAddEspai.Size = new System.Drawing.Size(108, 49);
            this.buttonAddEspai.TabIndex = 7;
            this.buttonAddEspai.Text = "Afegir Espai";
            this.buttonAddEspai.UseVisualStyleBackColor = true;
            this.buttonAddEspai.Click += new System.EventHandler(this.buttonAddEspai_Click);
            // 
            // groupBoxEspais
            // 
            this.groupBoxEspais.Controls.Add(this.dataGridViewEspais);
            this.groupBoxEspais.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEspais.Location = new System.Drawing.Point(33, 99);
            this.groupBoxEspais.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEspais.Name = "groupBoxEspais";
            this.groupBoxEspais.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEspais.Size = new System.Drawing.Size(804, 511);
            this.groupBoxEspais.TabIndex = 6;
            this.groupBoxEspais.TabStop = false;
            this.groupBoxEspais.Text = "Espais";
            // 
            // dataGridViewEspais
            // 
            this.dataGridViewEspais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEspais.Location = new System.Drawing.Point(23, 37);
            this.dataGridViewEspais.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEspais.Name = "dataGridViewEspais";
            this.dataGridViewEspais.RowTemplate.Height = 31;
            this.dataGridViewEspais.Size = new System.Drawing.Size(761, 452);
            this.dataGridViewEspais.TabIndex = 0;
            // 
            // buttonCercarEspais
            // 
            this.buttonCercarEspais.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCercarEspais.Location = new System.Drawing.Point(720, 33);
            this.buttonCercarEspais.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCercarEspais.Name = "buttonCercarEspais";
            this.buttonCercarEspais.Size = new System.Drawing.Size(77, 41);
            this.buttonCercarEspais.TabIndex = 5;
            this.buttonCercarEspais.Text = "Cercar";
            this.buttonCercarEspais.UseVisualStyleBackColor = true;
            // 
            // textBoxCercarEspais
            // 
            this.textBoxCercarEspais.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCercarEspais.Location = new System.Drawing.Point(188, 44);
            this.textBoxCercarEspais.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCercarEspais.Name = "textBoxCercarEspais";
            this.textBoxCercarEspais.Size = new System.Drawing.Size(473, 26);
            this.textBoxCercarEspais.TabIndex = 4;
            // 
            // tabPageEquips
            // 
            this.tabPageEquips.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageEquips.Controls.Add(this.buttonAddEntitat);
            this.tabPageEquips.Controls.Add(this.groupBoxEntitats);
            this.tabPageEquips.Controls.Add(this.buttonCercarEntitat);
            this.tabPageEquips.Controls.Add(this.textBoxCercarEntitats);
            this.tabPageEquips.Location = new System.Drawing.Point(4, 14);
            this.tabPageEquips.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEquips.Name = "tabPageEquips";
            this.tabPageEquips.Size = new System.Drawing.Size(1449, 833);
            this.tabPageEquips.TabIndex = 2;
            this.tabPageEquips.Text = "tabPage1";
            // 
            // buttonAddEntitat
            // 
            this.buttonAddEntitat.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEntitat.Location = new System.Drawing.Point(673, 652);
            this.buttonAddEntitat.Name = "buttonAddEntitat";
            this.buttonAddEntitat.Size = new System.Drawing.Size(108, 49);
            this.buttonAddEntitat.TabIndex = 11;
            this.buttonAddEntitat.Text = "Afegir Entitat";
            this.buttonAddEntitat.UseVisualStyleBackColor = true;
            this.buttonAddEntitat.Click += new System.EventHandler(this.buttonAddEntitat_Click);
            // 
            // groupBoxEntitats
            // 
            this.groupBoxEntitats.Controls.Add(this.dataGridViewEntitats);
            this.groupBoxEntitats.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEntitats.Location = new System.Drawing.Point(33, 99);
            this.groupBoxEntitats.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEntitats.Name = "groupBoxEntitats";
            this.groupBoxEntitats.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEntitats.Size = new System.Drawing.Size(804, 511);
            this.groupBoxEntitats.TabIndex = 10;
            this.groupBoxEntitats.TabStop = false;
            this.groupBoxEntitats.Text = "Entitats";
            // 
            // dataGridViewEntitats
            // 
            this.dataGridViewEntitats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEntitats.Location = new System.Drawing.Point(23, 37);
            this.dataGridViewEntitats.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEntitats.Name = "dataGridViewEntitats";
            this.dataGridViewEntitats.RowTemplate.Height = 31;
            this.dataGridViewEntitats.Size = new System.Drawing.Size(761, 452);
            this.dataGridViewEntitats.TabIndex = 0;
            // 
            // buttonCercarEntitat
            // 
            this.buttonCercarEntitat.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCercarEntitat.Location = new System.Drawing.Point(720, 33);
            this.buttonCercarEntitat.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCercarEntitat.Name = "buttonCercarEntitat";
            this.buttonCercarEntitat.Size = new System.Drawing.Size(77, 41);
            this.buttonCercarEntitat.TabIndex = 9;
            this.buttonCercarEntitat.Text = "Cercar";
            this.buttonCercarEntitat.UseVisualStyleBackColor = true;
            // 
            // textBoxCercarEntitats
            // 
            this.textBoxCercarEntitats.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCercarEntitats.Location = new System.Drawing.Point(188, 44);
            this.textBoxCercarEntitats.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCercarEntitats.Name = "textBoxCercarEntitats";
            this.textBoxCercarEntitats.Size = new System.Drawing.Size(473, 26);
            this.textBoxCercarEntitats.TabIndex = 8;
            // 
            // tabPageModificacion
            // 
            this.tabPageModificacion.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageModificacion.Location = new System.Drawing.Point(4, 14);
            this.tabPageModificacion.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageModificacion.Name = "tabPageModificacion";
            this.tabPageModificacion.Size = new System.Drawing.Size(1449, 735);
            this.tabPageModificacion.TabIndex = 3;
            this.tabPageModificacion.Text = "tabPage1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.pictureBoxLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1589, 136);
            this.panel2.TabIndex = 4;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1589, 995);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.EntitatsPanel.ResumeLayout(false);
            this.EntitatsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntitatsImage)).EndInit();
            this.EspaisLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspaiImage)).EndInit();
            this.PetiPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PetiImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPagePeticions.ResumeLayout(false);
            this.tabPagePeticions.PerformLayout();
            this.GroupBoxPeticio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeticio)).EndInit();
            this.tabPageEspais.ResumeLayout(false);
            this.tabPageEspais.PerformLayout();
            this.groupBoxEspais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEspais)).EndInit();
            this.tabPageEquips.ResumeLayout(false);
            this.tabPageEquips.PerformLayout();
            this.groupBoxEntitats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEntitats)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PetiImage;
        private System.Windows.Forms.Label Petilabel;
        private System.Windows.Forms.PictureBox EntitatsImage;
        private System.Windows.Forms.Label Entitatslabel;
        private System.Windows.Forms.Panel EntitatsPanel;
        private System.Windows.Forms.PictureBox EspaiImage;
        private System.Windows.Forms.Label EspaLabel;
        private System.Windows.Forms.Panel EspaisLabel;
        private System.Windows.Forms.Panel PetiPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePeticions;
        private System.Windows.Forms.TabPage tabPageEspais;
        private System.Windows.Forms.TabPage tabPageEquips;
        private System.Windows.Forms.TabPage tabPageModificacion;
        private System.Windows.Forms.Button buttonBuscarPeticion;
        private System.Windows.Forms.TextBox textBoxBuscarPeticion;


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupBoxPeticio;
        private System.Windows.Forms.DataGridView dataGridViewPeticio;
        private System.Windows.Forms.Button buttonAddEspai;
        private System.Windows.Forms.GroupBox groupBoxEspais;
        private System.Windows.Forms.DataGridView dataGridViewEspais;
        private System.Windows.Forms.Button buttonCercarEspais;
        private System.Windows.Forms.TextBox textBoxCercarEspais;
        private System.Windows.Forms.Button buttonAddEntitat;
        private System.Windows.Forms.GroupBox groupBoxEntitats;
        private System.Windows.Forms.DataGridView dataGridViewEntitats;
        private System.Windows.Forms.Button buttonCercarEntitat;
        private System.Windows.Forms.TextBox textBoxCercarEntitats;
        private System.Windows.Forms.Panel panel2;
    }
}