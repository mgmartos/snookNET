using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using snookNET.Entities;

namespace snookNET.Forms
{
    public partial class fPartida : Form
    {
        private Puntos Epuntos = new Puntos();
        private List<Puntos> LPuntos = new List<Puntos>();

        public fPartida()
        {
            InitializeComponent();
        }

        private void JuegaPlayer1_Click(object sender, EventArgs e)
        {
            if (!ComprobarPlayers()) return;
            this.JuegaPlayer1.Visible = false;
            this.JuegaPlayer2.Visible = true;
            this.Epuntos.PlayerActivo = 2;
            if (this.Epuntos.RojasEmbocadas < 15)
                this.Epuntos.BolaAnterior = 'C';
        }

        private void JuegaPlayer2_Click(object sender, EventArgs e)
        {
            if (!ComprobarPlayers()) return;
            this.JuegaPlayer1.Visible = true;
            this.JuegaPlayer2.Visible = false;
            this.Epuntos.PlayerActivo = 1;
            if (this.Epuntos.RojasEmbocadas < 15)
                this.Epuntos.BolaAnterior = 'C';

        }

        private void fPartida_Load(object sender, EventArgs e)
        {

            if (File.Exists("Jugadores.json"))
            {
                this.NamePlayer1.Items.Clear();
                this.NamePlayer2.Items.Clear();
                string fileName = "Jugadores.json";
                string jsonString = File.ReadAllText(fileName);
                List<string> listaJugadores = JsonSerializer.Deserialize<List<string>>(jsonString)!;
                for (int i = 0; i < listaJugadores.Count; i++)
                {
                    this.NamePlayer1.Items.Add(listaJugadores[i].ToString());
                    this.NamePlayer2.Items.Add(listaJugadores[i].ToString());
                }
            }
                this.PuntosPlayer1.Visible = this.PuntosPlayer2.Visible = true;
                PonPuntos();
        }

        private bool ComprobarPlayers()
        {
            if (this.NamePlayer1.Text.Length == 0 || this.NamePlayer2.Text.Length == 0)
            {
                MessageBox.Show("No se han seleccionado los jugadores.", "Aviso", MessageBoxButtons.OK);
                return false;
            }
            if (this.NamePlayer1.Text == this.NamePlayer2.Text)
            {
                MessageBox.Show("Debe seleccionar otro jugador", "Aviso", MessageBoxButtons.OK);
                return false;

            }

            return true;
        }

        private void btBola_Click(object sender, EventArgs e)
        {
            string bola = "";
            if (((Button)sender).Name.Contains("Roja"))
            {
                btRoja1_Click(sender, e);
                bola = "Roja";
            }
            else
            {
                btColor_Click(sender, e);
                switch (((Button)sender).Name)
                {
                    case "btAmarilla1":
                        bola = "Amarilla";
                        break;
                    case "btVerde1":
                        bola = "Verde";
                        break;
                    case "btMarron1":
                        bola = "Marrón";
                        break;
                    case "btAzul1":
                        bola = "Azul";
                        break;
                    case "btRosa1":
                        bola = "Rosa";
                        break;
                    case "btNegra1":
                        bola = "Negra";
                        break;
                }
            }
            this.Epuntos.ColorBola = bola;
            this.AgregarPaso();

            string player = this.Epuntos.PlayerActivo == 1 ? this.NamePlayer1.Text : this.NamePlayer2.Text;
            

             CLogger.serilogLogger.Information("Bola " + bola + " " + player + " - "+ this.Epuntos.PuntosPlayer1 + " - " +this.Epuntos.PuntosPlayer2 );
            this.lbRecordatorio.Text = "Bola " + bola + " " + player;

        }

        private void PonPuntos()
        {
            this.PuntosPlayer1.Text = this.Epuntos.PuntosPlayer1.ToString();
            this.PuntosPlayer2.Text = this.Epuntos.PuntosPlayer2.ToString();
            this.Epuntos.Diferencia =  (this.Epuntos.PuntosPlayer1 > this.Epuntos.PuntosPlayer2) ?
                    this.Epuntos.PuntosPlayer1 - this.Epuntos.PuntosPlayer2 : 
                    this.Epuntos.PuntosPlayer2 - this.Epuntos.PuntosPlayer1;
            this.lblDiferencia.Text = this.Epuntos.Diferencia.ToString();
            this.lblPendientes.Text = this.Epuntos.PuntosRestantes.ToString();
            this.lbFramesPlayer1.Text = this.Epuntos.FramesPlayer1.ToString();
            this.lbFramesPlayer2.Text = this.Epuntos.FramesPlayer2.ToString();
            if ((this.Epuntos.RojasEmbocadas == 16) && (this.Epuntos.ColoresEmbocadas == 6))
            {
                FinalizarFrame();
            }
        }

            private void btRoja1_Click(object sender, EventArgs e)
        {
            if (this.Epuntos.BolaAnterior == 'R')
            {
                DialogResult dialogResult = MessageBox.Show("No se puede jugar Roja, ¿Es Free ball?", "Orden de Bola", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
            }
            if (!ComprobarPlayers()) return;
            if (this.Epuntos.PlayerActivo == 1)
                this.Epuntos.PuntosPlayer1 += Epuntos.Roja;
            else
                this.Epuntos.PuntosPlayer2 += Epuntos.Roja;
            this.Epuntos.PuntosRestantes = this.Epuntos.PuntosRestantes - 8;
            this.Epuntos.RojasEmbocadas++;
            this.btRoja1.Enabled = this.Epuntos.RojasEmbocadas < 15;
            this.Epuntos.BolaAnterior = 'R';
            PonPuntos();

        }


        private bool CompruebaAnteriorColor(string nameboton)
        {
            if (this.Epuntos.RojasEmbocadas < 16)
            {
                if (this.Epuntos.BolaAnterior != 'R')
                {
                    DialogResult dialogResult = MessageBox.Show("No se puede jugar de Color, ¿Es Free ball?", "Orden de Bola", MessageBoxButtons.YesNo);
                    if (dialogResult != DialogResult.No)
                    {
                        return true;
                    } 
                    else
                        return false;
                }
               
            }
            else
            {
                switch (nameboton)
                {
                    case "btAmarilla1":
                        if (this.Epuntos.BolaAnterior != 'R')
                            return false;
                        break;
                    case "btVerde1":
                        if (this.Epuntos.BolaAnterior != 'A')
                            return false;
                        break;
                    case "btMarron1":
                        if (this.Epuntos.BolaAnterior != 'V')
                            return false;
                        break;
                    case "btAzul1":
                        if (this.Epuntos.BolaAnterior != 'M')
                            return false;
                        break;
                    case "btRosa1":
                        if (this.Epuntos.BolaAnterior != 'Z')
                            return false;
                        break;
                    case "btNegra1":
                        if (this.Epuntos.BolaAnterior != 'S')
                            return false;
                        break;
                }
            }
            return true;
        }
            private void btColor_Click(object sender, EventArgs e)
        {
            if (!CompruebaAnteriorColor(((Button)sender).Name))
                {
                //MessageBox.Show("Bola de Color","",MessageBoxButtons.OK);
                return;
                }
            int puntos = 0;
            switch (((Button)sender).Name) 
            {
                case "btAmarilla1":
                    puntos = 2;
                    this.Epuntos.BolaAnterior = 'A';
                    break;
                case "btVerde1":
                    puntos = 3;
                    this.Epuntos.BolaAnterior = 'V';
                    break;
                case "btMarron1":
                    puntos = 4;
                    this.Epuntos.BolaAnterior = 'M';
                    break;
                case "btAzul1":
                    puntos = 5;
                    this.Epuntos.BolaAnterior = 'Z';
                    break;
                case "btRosa1":
                    puntos = 6;
                    this.Epuntos.BolaAnterior = 'S';
                    break;
                case "btNegra1":
                    puntos = 7;
                    this.Epuntos.BolaAnterior = 'N';
                    break;
            }

            if (!ComprobarPlayers()) return;
            if (this.Epuntos.PlayerActivo == 1)
                this.Epuntos.PuntosPlayer1 += puntos;
            else
                this.Epuntos.PuntosPlayer2 += puntos;
            ((Button)sender).Enabled = this.Epuntos.RojasEmbocadas < 16;
            if (!((Button)sender).Enabled)
            {
                this.Epuntos.ColoresEmbocadas++;
                this.Epuntos.PuntosRestantes -= puntos;
            }
            PonPuntos();
            if (this.Epuntos.RojasEmbocadas == 15)
            { 
                this.Epuntos.RojasEmbocadas++;
                this.Epuntos.BolaAnterior = 'R';
            }
        }

      
        private void btFinFrame_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro?", "Finalizar Frame", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FinalizarFrame();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void FinalizarFrame()
        {
            string TextoMensaje = "Frame para ";

            if (this.Epuntos.PuntosPlayer1 > this.Epuntos.PuntosPlayer2)
            {
                this.Epuntos.FramesPlayer1++;
                TextoMensaje += this.NamePlayer1.Text;
            }
            else
                { 
                this.Epuntos.FramesPlayer2++;
                TextoMensaje += this.NamePlayer2.Text;
                }
            int f1 = this.Epuntos.FramesPlayer1;
            int f2 = this.Epuntos.FramesPlayer2;
            int activo = this.Epuntos.PlayerActivo;
            this.Epuntos = new Entities.Puntos();
            this.Epuntos.FramesPlayer1 = f1;
            this.Epuntos.FramesPlayer2 = f2;
            this.Epuntos.PlayerActivo = (activo == 1) ? 2 : 1;
            this.JuegaPlayer1.Visible = this.Epuntos.PlayerActivo == 1;
            this.JuegaPlayer2.Visible = this.Epuntos.PlayerActivo == 2;
            this.btRoja1.Enabled =
            this.btAmarilla1.Enabled =
            this.btVerde1.Enabled =
            this.btMarron1.Enabled =
            this.btAzul1.Enabled =
            this.btRosa1.Enabled =
            this.btNegra1.Enabled = true;
            PonPuntos();
            this.Epuntos.BolaAnterior = 'C';
            this.Epuntos.ColorBola = string.Empty;
            this.txListaEmboques.Text = string.Empty;
            this.LPuntos.Clear();

            MessageBox.Show(TextoMensaje, "Finalizar Frame", MessageBoxButtons.OK);
        }

        private void pbFalta_Click(object sender, EventArgs e)
        {
            int puntos = 4;
            switch(((PictureBox)sender).Name)
            {
                case "pbFalta5":
                    puntos = 5;
                    break;
                case "pbFalta6":
                    puntos = 6;
                    break;
                case "pbFalta7":
                    puntos = 7;
                    break;
            }

            if (!ComprobarPlayers()) return;
            if (this.Epuntos.PlayerActivo == 1)
                this.Epuntos.PuntosPlayer2 += puntos;
            else
                this.Epuntos.PuntosPlayer1 += puntos;

            PonPuntos();
            AgregarFalta(puntos);
            string player = this.Epuntos.PlayerActivo == 1 ? this.NamePlayer1.Text : this.NamePlayer2.Text;
            CLogger.serilogLogger.Information("Falta " + puntos.ToString()  + " " + player + " - " + this.Epuntos.PuntosPlayer1 + " - " + this.Epuntos.PuntosPlayer2);

        }


        private void AgregarPaso(bool atras = false)
        {
            Entities.Puntos ep = new Entities.Puntos();
            ep.PuntosPlayer1 = this.Epuntos.PuntosPlayer1;
            ep.PuntosPlayer2 = this.Epuntos.PuntosPlayer2;
            ep.FramesPlayer1 = this.Epuntos.FramesPlayer2;
            ep.FramesPlayer2 = this.Epuntos.FramesPlayer2;

            ep.Diferencia = this.Epuntos.Diferencia;
            ep.PuntosRestantes = this.Epuntos.PuntosRestantes;
            ep.PlayerActivo = this.Epuntos.PlayerActivo;
            ep.RojasEmbocadas = this.Epuntos.RojasEmbocadas;
            ep.ColoresEmbocadas = this.Epuntos.ColoresEmbocadas;
            ep.BolaAnterior = this.Epuntos.BolaAnterior;
            ep.ColorBola = this.Epuntos.ColorBola;
            if (!atras) this.LPuntos.Add(ep);

            int fin = this.LPuntos.Count;
            int inicio = fin - 25;
            inicio = inicio < 0 ? 0 : inicio;
            this.txListaEmboques.Text = String.Empty;
            if (this.LPuntos.Count > 0)
            {
                for (int i = inicio; i < fin; i++)
                {
                    string nombre = this.LPuntos[i].PlayerActivo == 1 ? this.NamePlayer1.Text : NamePlayer2.Text;
                    this.txListaEmboques.Text += nombre + " " + this.LPuntos[i].ColorBola.ToString() + " - " + this.LPuntos[i].PuntosPlayer1 + ":" + this.LPuntos[i].PuntosPlayer2 + Environment.NewLine;
                }
            }
        }
        private void AgregarFalta(int puntos)
        {
            Entities.Puntos ep = new Entities.Puntos();
            ep.PuntosPlayer1 = this.Epuntos.PuntosPlayer1;
            ep.PuntosPlayer2 = this.Epuntos.PuntosPlayer2;
            ep.FramesPlayer1 = this.Epuntos.FramesPlayer2;
            ep.FramesPlayer2 = this.Epuntos.FramesPlayer2;

            ep.Diferencia = this.Epuntos.Diferencia;
            ep.PuntosRestantes = this.Epuntos.PuntosRestantes;
            ep.PlayerActivo = this.Epuntos.PlayerActivo;
            ep.RojasEmbocadas = this.Epuntos.RojasEmbocadas;
            ep.ColoresEmbocadas = this.Epuntos.ColoresEmbocadas;
            ep.BolaAnterior = this.Epuntos.BolaAnterior;
            ep.ColorBola = "Falta " + puntos.ToString() + " p. ";
            this.LPuntos.Add(ep);

            int fin = this.LPuntos.Count;
            int inicio = fin - 25;
            inicio = inicio < 0 ? 0 : inicio;

            this.txListaEmboques.Text = String.Empty;
            if (this.LPuntos.Count > 0)
            {
                for (int i = inicio; i < fin; i++)
                {
                    string nombre = this.LPuntos[i].PlayerActivo == 1 ? this.NamePlayer1.Text : NamePlayer2.Text;
                        this.txListaEmboques.Text += nombre + " " + this.LPuntos[i].ColorBola.ToString() + " - " + this.LPuntos[i].PuntosPlayer1 + ":" + this.LPuntos[i].PuntosPlayer2 + Environment.NewLine;
                }
            }
        }

        private void CargaEpuntos(Puntos puntos)
        {
            this.Epuntos.PuntosPlayer1 = puntos.PuntosPlayer1;
            this.Epuntos.PuntosPlayer2 = puntos.PuntosPlayer2;
            this.Epuntos.FramesPlayer1 = puntos.FramesPlayer1;
            this.Epuntos.FramesPlayer2 = puntos.FramesPlayer2;
            this.Epuntos.PuntosRestantes = puntos.PuntosRestantes;
            this.Epuntos.Diferencia = puntos.Diferencia;
            this.Epuntos.PlayerActivo = puntos.PlayerActivo;
            this.Epuntos.RojasEmbocadas = puntos.RojasEmbocadas;
            this.Epuntos.ColoresEmbocadas = puntos.ColoresEmbocadas;
            this.Epuntos.BolaAnterior = puntos.BolaAnterior;
            this.Epuntos.ColorBola = puntos.ColorBola;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            if (this.LPuntos.Count > 1)
            {
                CargaEpuntos(this.LPuntos[this.LPuntos.Count - 2]);
                CLogger.serilogLogger.Information("Paso atrás");
                string player = this.Epuntos.PlayerActivo == 1 ? this.NamePlayer1.Text : this.NamePlayer2.Text;
                CLogger.serilogLogger.Information(player + " - " + this.Epuntos.PuntosPlayer1 + " - " + this.Epuntos.PuntosPlayer2);
                this.JuegaPlayer1.Visible = Epuntos.PlayerActivo == 1;
                this.JuegaPlayer2.Visible = Epuntos.PlayerActivo == 2;

                PonPuntos();


            }
        }

        private void btJson_Click(object sender, EventArgs e)
        {
            try
            {
                string sJson = JsonSerializer.Serialize(this.LPuntos);
                int l = sJson.Length;
                string name = "Snook-" + DateTime.Now.ToLongDateString();
                System.IO.File.WriteAllText(name, sJson);
            }
            catch (Exception ex) 
            {
                CLogger.serilogLogger.Error("Creación fichero Json ");
                CLogger.serilogLogger.Error(ex.ToString());
            }
        }

        private void txListaEmboques_MouseDown(object sender, MouseEventArgs e)
        {
            int charIndex = txListaEmboques.GetCharIndexFromPosition(e.Location);
            int line = txListaEmboques.GetLineFromCharIndex(charIndex);

            List<string> lista = txListaEmboques.Text.Split("\r\n").ToList();
            string tanteo = lista[line].ToString().Substring(lista[line].ToString().IndexOf('-')+1);
            List<string> tantos = tanteo.Split(':').ToList();
            int FinLista = -1;
            int tantos1 = Convert.ToInt16((string)tantos[0]);
            int tantos2 = Convert.ToInt16((string)tantos[1]);
            for (int i=0;i<this.LPuntos.Count;i++)
            {
                if ((this.LPuntos[i].PuntosPlayer1 == tantos1) && (this.LPuntos[i].PuntosPlayer2 == tantos2))
                    {
                    FinLista = i;
                    break;
                    }
            }
            if (FinLista >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Volver al punto seleccionado?", "Historial de Tantos", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    this.LPuntos.RemoveRange(FinLista + 1, this.LPuntos.Count - FinLista -1);
               
                CargaEpuntos(this.LPuntos[this.LPuntos.Count - 1]);
                CLogger.serilogLogger.Information("Paso Muuuy atrás");
                string player = this.Epuntos.PlayerActivo == 1 ? this.NamePlayer1.Text : this.NamePlayer2.Text;
                CLogger.serilogLogger.Information(player + " - " + this.Epuntos.PuntosPlayer1 + " - " + this.Epuntos.PuntosPlayer2);
                this.JuegaPlayer1.Visible = Epuntos.PlayerActivo == 1;
                this.JuegaPlayer2.Visible = Epuntos.PlayerActivo == 2;
                PonPuntos();
                AgregarPaso(true);
                }
            }


    //MessageBox.Show("Click on line=" + line + ", Text=" + txListaEmboques.Lines(line))
        }

        private void pbSupernumerario_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
                
                {
                    if (this.Epuntos.RojasEmbocadas < 15)
                    {
                        this.Epuntos.RojasEmbocadas++;
                        this.Epuntos.PuntosRestantes -= 8;
                        this.lblPendientes.Text = this.Epuntos.PuntosRestantes.ToString();
                    }
                }
                else 
                { 
                    if (this.Epuntos.RojasEmbocadas > 0)
                    {
                        this.Epuntos.RojasEmbocadas--;
                        this.Epuntos.PuntosRestantes += 8;
                        this.lblPendientes.Text = this.Epuntos.PuntosRestantes.ToString();
                    }
                }
        }
        

        private void pbSupernumerario_DoubleClick(object sender, EventArgs e)
        {
            if (this.Epuntos.RojasEmbocadas > 0)
            {
                this.Epuntos.RojasEmbocadas--;
                this.Epuntos.PuntosRestantes += 8;
                this.lblPendientes.Text = this.Epuntos.PuntosRestantes.ToString();
            }
        }
    }
}
