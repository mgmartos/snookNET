namespace snookNET.Forms
{
    partial class fJugadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txJugador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lvJugadores = new System.Windows.Forms.ListBox();
            this.FlechaGuardar = new System.Windows.Forms.PictureBox();
            this.FlechaQuitar = new System.Windows.Forms.PictureBox();
            this.pbGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaQuitar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(110, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Jugador";
            // 
            // txJugador
            // 
            this.txJugador.BackColor = System.Drawing.SystemColors.Control;
            this.txJugador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txJugador.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txJugador.Location = new System.Drawing.Point(11, 397);
            this.txJugador.Name = "txJugador";
            this.txJugador.Size = new System.Drawing.Size(376, 46);
            this.txJugador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(626, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Jugador";
            // 
            // lvJugadores
            // 
            this.lvJugadores.BackColor = System.Drawing.SystemColors.Control;
            this.lvJugadores.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvJugadores.FormattingEnabled = true;
            this.lvJugadores.ItemHeight = 27;
            this.lvJugadores.Location = new System.Drawing.Point(565, 72);
            this.lvJugadores.Name = "lvJugadores";
            this.lvJugadores.Size = new System.Drawing.Size(316, 571);
            this.lvJugadores.Sorted = true;
            this.lvJugadores.TabIndex = 6;
            // 
            // FlechaGuardar
            // 
            this.FlechaGuardar.Image = global::snookNET.Properties.Resources.derecha;
            this.FlechaGuardar.Location = new System.Drawing.Point(440, 389);
            this.FlechaGuardar.Name = "FlechaGuardar";
            this.FlechaGuardar.Size = new System.Drawing.Size(78, 46);
            this.FlechaGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FlechaGuardar.TabIndex = 24;
            this.FlechaGuardar.TabStop = false;
            this.FlechaGuardar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // FlechaQuitar
            // 
            this.FlechaQuitar.Image = global::snookNET.Properties.Resources.Izquierda;
            this.FlechaQuitar.Location = new System.Drawing.Point(440, 223);
            this.FlechaQuitar.Name = "FlechaQuitar";
            this.FlechaQuitar.Size = new System.Drawing.Size(78, 46);
            this.FlechaQuitar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FlechaQuitar.TabIndex = 25;
            this.FlechaQuitar.TabStop = false;
            this.FlechaQuitar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // pbGuardar
            // 
            this.pbGuardar.ErrorImage = global::snookNET.Properties.Resources.Guardar_click;
            this.pbGuardar.Image = global::snookNET.Properties.Resources.Guardar;
            this.pbGuardar.Location = new System.Drawing.Point(918, 346);
            this.pbGuardar.Name = "pbGuardar";
            this.pbGuardar.Size = new System.Drawing.Size(150, 75);
            this.pbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGuardar.TabIndex = 26;
            this.pbGuardar.TabStop = false;
            this.pbGuardar.Click += new System.EventHandler(this.btSalvar_Click);
            this.pbGuardar.MouseEnter += new System.EventHandler(this.pbGuardar_MouseEnter);
            this.pbGuardar.MouseLeave += new System.EventHandler(this.pbGuardar_MouseLeave);
            // 
            // fJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 815);
            this.Controls.Add(this.pbGuardar);
            this.Controls.Add(this.FlechaQuitar);
            this.Controls.Add(this.FlechaGuardar);
            this.Controls.Add(this.lvJugadores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txJugador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fJugadores";
            this.Text = "fJugadores";
            this.Load += new System.EventHandler(this.fJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlechaGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlechaQuitar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lvJugadores;
        private System.Windows.Forms.PictureBox JuegaPlayer2;
        private System.Windows.Forms.PictureBox JuegaPlayer1;
        private System.Windows.Forms.PictureBox pbGuardar;
        private System.Windows.Forms.PictureBox FlechaGuardar;
        private System.Windows.Forms.PictureBox FlechaQuitar;
    }
}