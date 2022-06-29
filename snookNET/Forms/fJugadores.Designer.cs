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
            this.btEliminar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.lvJugadores = new System.Windows.Forms.ListBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(238, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Jugador";
            // 
            // txJugador
            // 
            this.txJugador.Location = new System.Drawing.Point(139, 137);
            this.txJugador.Name = "txJugador";
            this.txJugador.Size = new System.Drawing.Size(376, 31);
            this.txJugador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(624, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo Jugador";
            // 
            // btEliminar
            // 
            this.btEliminar.ForeColor = System.Drawing.Color.Black;
            this.btEliminar.Location = new System.Drawing.Point(935, 223);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(118, 35);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.ForeColor = System.Drawing.Color.Black;
            this.btAgregar.Location = new System.Drawing.Point(256, 193);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(118, 35);
            this.btAgregar.TabIndex = 5;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // lvJugadores
            // 
            this.lvJugadores.Font = new System.Drawing.Font("Century", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvJugadores.FormattingEnabled = true;
            this.lvJugadores.ItemHeight = 27;
            this.lvJugadores.Location = new System.Drawing.Point(552, 137);
            this.lvJugadores.Name = "lvJugadores";
            this.lvJugadores.Size = new System.Drawing.Size(316, 598);
            this.lvJugadores.Sorted = true;
            this.lvJugadores.TabIndex = 6;
            // 
            // btSalvar
            // 
            this.btSalvar.ForeColor = System.Drawing.Color.Black;
            this.btSalvar.Location = new System.Drawing.Point(935, 427);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(118, 35);
            this.btSalvar.TabIndex = 7;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // fJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 815);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.lvJugadores);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txJugador);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fJugadores";
            this.Text = "fJugadores";
            this.Load += new System.EventHandler(this.fJugadores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.ListBox lvJugadores;
        private System.Windows.Forms.Button btSalvar;
    }
}