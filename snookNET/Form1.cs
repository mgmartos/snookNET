using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace snookNET
{
    public partial class fPpalSnooker : Form
    {
        public fPpalSnooker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Maximized;
            this.btnMaximizar.Visible=false;
            this.btnRestaurar.Visible=true;
            
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnMaximizar.Visible = true;
            this.btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form f = new Forms.fPartida();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(f);
            this.pnlCentral.Tag = f;
            f.Show();


        }

        private void fPpalSnooker_Load(object sender, EventArgs e)
        {
            CLogger.serilogLogger.Information("Entramos en Form1");

            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible=true;
            
        }

        private void btJugadores_Click(object sender, EventArgs e)
        {
            if (this.pnlCentral.Controls.Count > 0)
                this.pnlCentral.Controls.RemoveAt(0);
            Form f = new Forms.fJugadores();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlCentral.Controls.Add(f);
            this.pnlCentral.Tag = f;
            f.Show();
        }
    }
}
