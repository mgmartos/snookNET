namespace snookNET.Forms
{
    partial class fPartida
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbPlayer1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbSupernumerario = new System.Windows.Forms.PictureBox();
            this.pbFalta7 = new System.Windows.Forms.PictureBox();
            this.pbFalta6 = new System.Windows.Forms.PictureBox();
            this.pbFalta5 = new System.Windows.Forms.PictureBox();
            this.pbFalta4 = new System.Windows.Forms.PictureBox();
            this.btFinFrame = new System.Windows.Forms.Button();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btRoja1 = new System.Windows.Forms.Button();
            this.btNegra1 = new System.Windows.Forms.Button();
            this.btAmarilla1 = new System.Windows.Forms.Button();
            this.btRosa1 = new System.Windows.Forms.Button();
            this.btVerde1 = new System.Windows.Forms.Button();
            this.btAzul1 = new System.Windows.Forms.Button();
            this.btMarron1 = new System.Windows.Forms.Button();
            this.NamePlayer2 = new System.Windows.Forms.ComboBox();
            this.NamePlayer1 = new System.Windows.Forms.ComboBox();
            this.PuntosPlayer1 = new System.Windows.Forms.Label();
            this.PuntosPlayer2 = new System.Windows.Forms.Label();
            this.JuegaPlayer1 = new System.Windows.Forms.PictureBox();
            this.JuegaPlayer2 = new System.Windows.Forms.PictureBox();
            this.lbFramesPlayer1 = new System.Windows.Forms.Label();
            this.lbFramesPlayer2 = new System.Windows.Forms.Label();
            this.lbSeparador = new System.Windows.Forms.Label();
            this.lbRecordatorio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAtras = new System.Windows.Forms.Button();
            this.btJson = new System.Windows.Forms.Button();
            this.txListaEmboques = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSupernumerario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuegaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuegaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Roonie O´Sullivan",
            "Williams",
            "Robertson"});
            this.comboBox1.Location = new System.Drawing.Point(590, -111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 33);
            this.comboBox1.TabIndex = 16;
            // 
            // cbPlayer1
            // 
            this.cbPlayer1.FormattingEnabled = true;
            this.cbPlayer1.Items.AddRange(new object[] {
            "Roonie O´Sullivan",
            "Williams",
            "Robertson"});
            this.cbPlayer1.Location = new System.Drawing.Point(-196, -111);
            this.cbPlayer1.Name = "cbPlayer1";
            this.cbPlayer1.Size = new System.Drawing.Size(406, 33);
            this.cbPlayer1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btFinFrame);
            this.groupBox1.Controls.Add(this.lblDiferencia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblPendientes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btRoja1);
            this.groupBox1.Controls.Add(this.btNegra1);
            this.groupBox1.Controls.Add(this.btAmarilla1);
            this.groupBox1.Controls.Add(this.btRosa1);
            this.groupBox1.Controls.Add(this.btVerde1);
            this.groupBox1.Controls.Add(this.btAzul1);
            this.groupBox1.Controls.Add(this.btMarron1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(81, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 383);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tantos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbSupernumerario);
            this.groupBox2.Controls.Add(this.pbFalta7);
            this.groupBox2.Controls.Add(this.pbFalta6);
            this.groupBox2.Controls.Add(this.pbFalta5);
            this.groupBox2.Controls.Add(this.pbFalta4);
            this.groupBox2.Location = new System.Drawing.Point(26, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 85);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Falta";
            // 
            // pbSupernumerario
            // 
            this.pbSupernumerario.Image = global::snookNET.Properties.Resources.BolaRoja;
            this.pbSupernumerario.Location = new System.Drawing.Point(291, 41);
            this.pbSupernumerario.Name = "pbSupernumerario";
            this.pbSupernumerario.Size = new System.Drawing.Size(25, 25);
            this.pbSupernumerario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSupernumerario.TabIndex = 4;
            this.pbSupernumerario.TabStop = false;
            this.pbSupernumerario.Click += new System.EventHandler(this.pbSupernumerario_Click);
            this.pbSupernumerario.DoubleClick += new System.EventHandler(this.pbSupernumerario_DoubleClick);
            // 
            // pbFalta7
            // 
            this.pbFalta7.Image = global::snookNET.Properties.Resources._7;
            this.pbFalta7.Location = new System.Drawing.Point(163, 41);
            this.pbFalta7.Name = "pbFalta7";
            this.pbFalta7.Size = new System.Drawing.Size(25, 25);
            this.pbFalta7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFalta7.TabIndex = 3;
            this.pbFalta7.TabStop = false;
            this.pbFalta7.Click += new System.EventHandler(this.pbFalta_Click);
            // 
            // pbFalta6
            // 
            this.pbFalta6.Image = global::snookNET.Properties.Resources._6;
            this.pbFalta6.Location = new System.Drawing.Point(119, 41);
            this.pbFalta6.Name = "pbFalta6";
            this.pbFalta6.Size = new System.Drawing.Size(25, 25);
            this.pbFalta6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFalta6.TabIndex = 2;
            this.pbFalta6.TabStop = false;
            this.pbFalta6.Click += new System.EventHandler(this.pbFalta_Click);
            // 
            // pbFalta5
            // 
            this.pbFalta5.Image = global::snookNET.Properties.Resources._5;
            this.pbFalta5.Location = new System.Drawing.Point(75, 41);
            this.pbFalta5.Name = "pbFalta5";
            this.pbFalta5.Size = new System.Drawing.Size(25, 25);
            this.pbFalta5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFalta5.TabIndex = 1;
            this.pbFalta5.TabStop = false;
            this.pbFalta5.Click += new System.EventHandler(this.pbFalta_Click);
            // 
            // pbFalta4
            // 
            this.pbFalta4.Image = global::snookNET.Properties.Resources._4;
            this.pbFalta4.Location = new System.Drawing.Point(31, 41);
            this.pbFalta4.Name = "pbFalta4";
            this.pbFalta4.Size = new System.Drawing.Size(25, 25);
            this.pbFalta4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFalta4.TabIndex = 0;
            this.pbFalta4.TabStop = false;
            this.pbFalta4.Click += new System.EventHandler(this.pbFalta_Click);
            // 
            // btFinFrame
            // 
            this.btFinFrame.BackColor = System.Drawing.SystemColors.Control;
            this.btFinFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFinFrame.FlatAppearance.BorderSize = 0;
            this.btFinFrame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btFinFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFinFrame.ForeColor = System.Drawing.Color.Black;
            this.btFinFrame.Location = new System.Drawing.Point(465, 290);
            this.btFinFrame.Name = "btFinFrame";
            this.btFinFrame.Size = new System.Drawing.Size(146, 89);
            this.btFinFrame.TabIndex = 18;
            this.btFinFrame.Text = "Finalizar Frame";
            this.btFinFrame.UseVisualStyleBackColor = false;
            this.btFinFrame.Click += new System.EventHandler(this.btFinFrame_Click);
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiferencia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiferencia.ForeColor = System.Drawing.Color.Black;
            this.lblDiferencia.Location = new System.Drawing.Point(234, 336);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(39, 43);
            this.lblDiferencia.TabIndex = 17;
            this.lblDiferencia.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(61, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 34);
            this.label4.TabIndex = 16;
            this.label4.Text = "Diferencia";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.BackColor = System.Drawing.SystemColors.Control;
            this.lblPendientes.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendientes.ForeColor = System.Drawing.Color.Black;
            this.lblPendientes.Location = new System.Drawing.Point(234, 258);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(39, 43);
            this.lblPendientes.TabIndex = 15;
            this.lblPendientes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(61, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 34);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pendientes";
            // 
            // btRoja1
            // 
            this.btRoja1.BackColor = System.Drawing.Color.Transparent;
            this.btRoja1.BackgroundImage = global::snookNET.Properties.Resources.BolaRoja;
            this.btRoja1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRoja1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btRoja1.FlatAppearance.BorderSize = 0;
            this.btRoja1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRoja1.ForeColor = System.Drawing.SystemColors.Control;
            this.btRoja1.Location = new System.Drawing.Point(26, 79);
            this.btRoja1.Name = "btRoja1";
            this.btRoja1.Size = new System.Drawing.Size(79, 72);
            this.btRoja1.TabIndex = 7;
            this.btRoja1.UseVisualStyleBackColor = false;
            this.btRoja1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btNegra1
            // 
            this.btNegra1.BackColor = System.Drawing.Color.Transparent;
            this.btNegra1.BackgroundImage = global::snookNET.Properties.Resources.BolaNegra;
            this.btNegra1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNegra1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btNegra1.FlatAppearance.BorderSize = 0;
            this.btNegra1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNegra1.ForeColor = System.Drawing.SystemColors.Control;
            this.btNegra1.Location = new System.Drawing.Point(608, 79);
            this.btNegra1.Name = "btNegra1";
            this.btNegra1.Size = new System.Drawing.Size(79, 72);
            this.btNegra1.TabIndex = 13;
            this.btNegra1.UseVisualStyleBackColor = false;
            this.btNegra1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btAmarilla1
            // 
            this.btAmarilla1.BackColor = System.Drawing.Color.Transparent;
            this.btAmarilla1.BackgroundImage = global::snookNET.Properties.Resources.BolaAmarilla;
            this.btAmarilla1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAmarilla1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btAmarilla1.FlatAppearance.BorderSize = 0;
            this.btAmarilla1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAmarilla1.ForeColor = System.Drawing.SystemColors.Control;
            this.btAmarilla1.Location = new System.Drawing.Point(123, 79);
            this.btAmarilla1.Name = "btAmarilla1";
            this.btAmarilla1.Size = new System.Drawing.Size(79, 72);
            this.btAmarilla1.TabIndex = 8;
            this.btAmarilla1.UseVisualStyleBackColor = false;
            this.btAmarilla1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btRosa1
            // 
            this.btRosa1.BackColor = System.Drawing.Color.Transparent;
            this.btRosa1.BackgroundImage = global::snookNET.Properties.Resources.BolaRosa;
            this.btRosa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRosa1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btRosa1.FlatAppearance.BorderSize = 0;
            this.btRosa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRosa1.ForeColor = System.Drawing.SystemColors.Control;
            this.btRosa1.Location = new System.Drawing.Point(511, 79);
            this.btRosa1.Name = "btRosa1";
            this.btRosa1.Size = new System.Drawing.Size(79, 72);
            this.btRosa1.TabIndex = 12;
            this.btRosa1.UseVisualStyleBackColor = false;
            this.btRosa1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btVerde1
            // 
            this.btVerde1.BackColor = System.Drawing.Color.Transparent;
            this.btVerde1.BackgroundImage = global::snookNET.Properties.Resources.BolaVerde;
            this.btVerde1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btVerde1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btVerde1.FlatAppearance.BorderSize = 0;
            this.btVerde1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVerde1.ForeColor = System.Drawing.SystemColors.Control;
            this.btVerde1.Location = new System.Drawing.Point(220, 79);
            this.btVerde1.Name = "btVerde1";
            this.btVerde1.Size = new System.Drawing.Size(79, 72);
            this.btVerde1.TabIndex = 9;
            this.btVerde1.UseVisualStyleBackColor = false;
            this.btVerde1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btAzul1
            // 
            this.btAzul1.BackColor = System.Drawing.Color.Transparent;
            this.btAzul1.BackgroundImage = global::snookNET.Properties.Resources.BolaAzul;
            this.btAzul1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAzul1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btAzul1.FlatAppearance.BorderSize = 0;
            this.btAzul1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAzul1.ForeColor = System.Drawing.SystemColors.Control;
            this.btAzul1.Location = new System.Drawing.Point(414, 79);
            this.btAzul1.Name = "btAzul1";
            this.btAzul1.Size = new System.Drawing.Size(79, 72);
            this.btAzul1.TabIndex = 11;
            this.btAzul1.UseVisualStyleBackColor = false;
            this.btAzul1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // btMarron1
            // 
            this.btMarron1.BackColor = System.Drawing.Color.Transparent;
            this.btMarron1.BackgroundImage = global::snookNET.Properties.Resources.BolaMarron;
            this.btMarron1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMarron1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btMarron1.FlatAppearance.BorderSize = 0;
            this.btMarron1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMarron1.ForeColor = System.Drawing.SystemColors.Control;
            this.btMarron1.Location = new System.Drawing.Point(317, 79);
            this.btMarron1.Name = "btMarron1";
            this.btMarron1.Size = new System.Drawing.Size(79, 72);
            this.btMarron1.TabIndex = 10;
            this.btMarron1.UseVisualStyleBackColor = false;
            this.btMarron1.Click += new System.EventHandler(this.btBola_Click);
            // 
            // NamePlayer2
            // 
            this.NamePlayer2.FormattingEnabled = true;
            this.NamePlayer2.Items.AddRange(new object[] {
            "Roonie O´Sullivan",
            "Mark Williams",
            "Neil Robertson",
            "Mark Selby",
            "Judd Trump",
            "John Higgins",
            "Mark Allen",
            "Kyren Wilson"});
            this.NamePlayer2.Location = new System.Drawing.Point(441, 57);
            this.NamePlayer2.Name = "NamePlayer2";
            this.NamePlayer2.Size = new System.Drawing.Size(406, 33);
            this.NamePlayer2.TabIndex = 18;
            // 
            // NamePlayer1
            // 
            this.NamePlayer1.FormattingEnabled = true;
            this.NamePlayer1.Items.AddRange(new object[] {
            "Roonie O´Sullivan",
            "Mark Williams",
            "Neil Robertson",
            "Mark Selby",
            "Judd Trump",
            "John Higgins",
            "Mark Allen",
            "Kyren Wilson"});
            this.NamePlayer1.Location = new System.Drawing.Point(29, 57);
            this.NamePlayer1.Name = "NamePlayer1";
            this.NamePlayer1.Size = new System.Drawing.Size(406, 33);
            this.NamePlayer1.TabIndex = 17;
            // 
            // PuntosPlayer1
            // 
            this.PuntosPlayer1.AutoSize = true;
            this.PuntosPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.PuntosPlayer1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PuntosPlayer1.ForeColor = System.Drawing.Color.Black;
            this.PuntosPlayer1.Location = new System.Drawing.Point(121, 178);
            this.PuntosPlayer1.Name = "PuntosPlayer1";
            this.PuntosPlayer1.Size = new System.Drawing.Size(51, 56);
            this.PuntosPlayer1.TabIndex = 20;
            this.PuntosPlayer1.Text = "0";
            this.PuntosPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PuntosPlayer2
            // 
            this.PuntosPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PuntosPlayer2.AutoSize = true;
            this.PuntosPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.PuntosPlayer2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PuntosPlayer2.ForeColor = System.Drawing.Color.Black;
            this.PuntosPlayer2.Location = new System.Drawing.Point(696, 178);
            this.PuntosPlayer2.Name = "PuntosPlayer2";
            this.PuntosPlayer2.Size = new System.Drawing.Size(51, 56);
            this.PuntosPlayer2.TabIndex = 21;
            this.PuntosPlayer2.Text = "0";
            this.PuntosPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // JuegaPlayer1
            // 
            this.JuegaPlayer1.Image = global::snookNET.Properties.Resources.FlechaIzquierda;
            this.JuegaPlayer1.Location = new System.Drawing.Point(357, 96);
            this.JuegaPlayer1.Name = "JuegaPlayer1";
            this.JuegaPlayer1.Size = new System.Drawing.Size(78, 46);
            this.JuegaPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.JuegaPlayer1.TabIndex = 22;
            this.JuegaPlayer1.TabStop = false;
            this.JuegaPlayer1.Click += new System.EventHandler(this.JuegaPlayer1_Click);
            // 
            // JuegaPlayer2
            // 
            this.JuegaPlayer2.Image = global::snookNET.Properties.Resources.FlechaDerecha;
            this.JuegaPlayer2.Location = new System.Drawing.Point(441, 96);
            this.JuegaPlayer2.Name = "JuegaPlayer2";
            this.JuegaPlayer2.Size = new System.Drawing.Size(78, 46);
            this.JuegaPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.JuegaPlayer2.TabIndex = 23;
            this.JuegaPlayer2.TabStop = false;
            this.JuegaPlayer2.Visible = false;
            this.JuegaPlayer2.Click += new System.EventHandler(this.JuegaPlayer2_Click);
            // 
            // lbFramesPlayer1
            // 
            this.lbFramesPlayer1.AutoSize = true;
            this.lbFramesPlayer1.BackColor = System.Drawing.SystemColors.Control;
            this.lbFramesPlayer1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFramesPlayer1.ForeColor = System.Drawing.Color.Black;
            this.lbFramesPlayer1.Location = new System.Drawing.Point(386, 189);
            this.lbFramesPlayer1.Name = "lbFramesPlayer1";
            this.lbFramesPlayer1.Size = new System.Drawing.Size(31, 34);
            this.lbFramesPlayer1.TabIndex = 24;
            this.lbFramesPlayer1.Text = "0";
            this.lbFramesPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFramesPlayer2
            // 
            this.lbFramesPlayer2.AutoSize = true;
            this.lbFramesPlayer2.BackColor = System.Drawing.SystemColors.Control;
            this.lbFramesPlayer2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFramesPlayer2.ForeColor = System.Drawing.Color.Black;
            this.lbFramesPlayer2.Location = new System.Drawing.Point(453, 189);
            this.lbFramesPlayer2.Name = "lbFramesPlayer2";
            this.lbFramesPlayer2.Size = new System.Drawing.Size(31, 34);
            this.lbFramesPlayer2.TabIndex = 26;
            this.lbFramesPlayer2.Text = "0";
            this.lbFramesPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSeparador
            // 
            this.lbSeparador.AutoSize = true;
            this.lbSeparador.BackColor = System.Drawing.SystemColors.Control;
            this.lbSeparador.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSeparador.ForeColor = System.Drawing.Color.Black;
            this.lbSeparador.Location = new System.Drawing.Point(423, 189);
            this.lbSeparador.Name = "lbSeparador";
            this.lbSeparador.Size = new System.Drawing.Size(24, 34);
            this.lbSeparador.TabIndex = 27;
            this.lbSeparador.Text = "-";
            this.lbSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRecordatorio
            // 
            this.lbRecordatorio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbRecordatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecordatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRecordatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRecordatorio.ForeColor = System.Drawing.Color.Black;
            this.lbRecordatorio.Location = new System.Drawing.Point(182, 673);
            this.lbRecordatorio.Margin = new System.Windows.Forms.Padding(3);
            this.lbRecordatorio.Name = "lbRecordatorio";
            this.lbRecordatorio.Size = new System.Drawing.Size(611, 32);
            this.lbRecordatorio.TabIndex = 28;
            this.lbRecordatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Último";
            // 
            // btAtras
            // 
            this.btAtras.FlatAppearance.BorderSize = 0;
            this.btAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAtras.ForeColor = System.Drawing.Color.Black;
            this.btAtras.Location = new System.Drawing.Point(171, 727);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(112, 34);
            this.btAtras.TabIndex = 30;
            this.btAtras.Text = "Atrás";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Visible = false;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // btJson
            // 
            this.btJson.Location = new System.Drawing.Point(171, 767);
            this.btJson.Name = "btJson";
            this.btJson.Size = new System.Drawing.Size(112, 34);
            this.btJson.TabIndex = 31;
            this.btJson.Text = "JSON";
            this.btJson.UseVisualStyleBackColor = true;
            this.btJson.Visible = false;
            this.btJson.Click += new System.EventHandler(this.btJson_Click);
            // 
            // txListaEmboques
            // 
            this.txListaEmboques.BackColor = System.Drawing.SystemColors.Control;
            this.txListaEmboques.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txListaEmboques.Location = new System.Drawing.Point(958, 28);
            this.txListaEmboques.Multiline = true;
            this.txListaEmboques.Name = "txListaEmboques";
            this.txListaEmboques.Size = new System.Drawing.Size(307, 714);
            this.txListaEmboques.TabIndex = 32;
            this.txListaEmboques.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txListaEmboques_MouseDown);
            // 
            // fPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 815);
            this.Controls.Add(this.txListaEmboques);
            this.Controls.Add(this.btJson);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRecordatorio);
            this.Controls.Add(this.lbSeparador);
            this.Controls.Add(this.lbFramesPlayer2);
            this.Controls.Add(this.lbFramesPlayer1);
            this.Controls.Add(this.PuntosPlayer2);
            this.Controls.Add(this.PuntosPlayer1);
            this.Controls.Add(this.JuegaPlayer2);
            this.Controls.Add(this.JuegaPlayer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NamePlayer2);
            this.Controls.Add(this.NamePlayer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cbPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPartida";
            this.Load += new System.EventHandler(this.fPartida_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSupernumerario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFalta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuegaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JuegaPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbPlayer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRoja1;
        private System.Windows.Forms.Button btNegra1;
        private System.Windows.Forms.Button btAmarilla1;
        private System.Windows.Forms.Button btRosa1;
        private System.Windows.Forms.Button btVerde1;
        private System.Windows.Forms.Button btAzul1;
        private System.Windows.Forms.Button btMarron1;
        private System.Windows.Forms.ComboBox NamePlayer2;
        private System.Windows.Forms.ComboBox NamePlayer1;
        private System.Windows.Forms.Label PuntosPlayer1;
        private System.Windows.Forms.Label PuntosPlayer2;
        private System.Windows.Forms.PictureBox JuegaPlayer1;
        private System.Windows.Forms.PictureBox JuegaPlayer2;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFramesPlayer1;
        private System.Windows.Forms.Label lbFramesPlayer2;
        private System.Windows.Forms.Button btFinFrame;
        private System.Windows.Forms.Label lbSeparador;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbFalta7;
        private System.Windows.Forms.PictureBox pbFalta6;
        private System.Windows.Forms.PictureBox pbFalta5;
        private System.Windows.Forms.PictureBox pbFalta4;
        private System.Windows.Forms.Label lbRecordatorio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.Button btJson;
        private System.Windows.Forms.TextBox txListaEmboques;
        private System.Windows.Forms.PictureBox pbSupernumerario;
    }
}