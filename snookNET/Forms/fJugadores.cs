using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using snookNET.Entities;
using System.Text.Json;
using System.IO;

namespace snookNET.Forms
{
    public partial class fJugadores : Form
    {
        private List<string> listaJugadores = new List<string>();

        public fJugadores()
        {

            InitializeComponent();            
            if (File.Exists("Jugadores.json"))
            { 
            string fileName = "Jugadores.json";
            string jsonString = File.ReadAllText(fileName);
            listaJugadores = JsonSerializer.Deserialize<List<string>>(jsonString)!;
            for (int i = 0; i < listaJugadores.Count; i++)
                {
                    this.lvJugadores.Items.Add(listaJugadores[i].ToString());
                }
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            int posicion = this.lvJugadores.SelectedIndices[0];
            string texto = this.lvJugadores.Items[posicion].ToString();
            this.lvJugadores.Items.RemoveAt(posicion);
            this.txJugador.Text = texto;
        }

        private void fJugadores_Load(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
           string nombre = this.txJugador.Text;
          
            for (int i = 0; i < this.lvJugadores.Items.Count; i++)
                if (this.lvJugadores.Items[i].ToString() == nombre)
                {
                    MessageBox.Show("Ya existe ese jugador.");
                    return; 
                }
            this.lvJugadores.Items.Add(nombre);
            this.txJugador.Text = "";
           // Salvar();
        }
        private void Salvar()
        {
            try
            { 
            string sJson = JsonSerializer.Serialize(this.lvJugadores.Items);
            int l = sJson.Length;
            string name = "Jugadores.json";
            System.IO.File.WriteAllText(name, sJson);
            MessageBox.Show("Lista de jugadores guardada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido guardar la lista de jugadores.");

            }

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void JuegaPlayer2_Click(object sender, EventArgs e)
        {
            btAgregar_Click(sender, e);
        }

        private void pbGuardar_MouseEnter(object sender, EventArgs e)
        {
            this.pbGuardar.Image = global::snookNET.Properties.Resources.Guardar_click;
        }

        private void pbGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.pbGuardar.Image = global::snookNET.Properties.Resources.Guardar;
        }
    }
}
