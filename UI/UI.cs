using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace UI
{
    public partial class UI : Form
    {
        public List<Personas> personasLista;
        public Personas operario1;
        public Personas directivo1;
        public Personas admin1;

        public UI()
        {
            InitializeComponent();
            personasLista = new List<Personas>();
            operario1 = new Operarios("Facundo", "Tulian", "90180", 100000);
            directivo1 = new Directivos("Federico", "Bustos", "90181", 300000);
            admin1 = new Administrativos("Martin", "Mora", "90182", 200000);
            personasLista.Add(operario1);
            personasLista.Add(directivo1);
            personasLista.Add(admin1);
            CargarCategorias();
        }
        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Personas nuevo;
            try
            {
                switch (cbxCategorias.SelectedIndex)
                {
                    case 0:
                        nuevo = new Administrativos(tbxNombre.Text, tbxApellido.Text, tbxLegajo.Text, (float)numSueldo.Value);
                        personasLista.Add(nuevo);
                        MostrarPersonas();
                        break;
                    case 1:
                        nuevo = new Operarios(tbxNombre.Text, tbxApellido.Text, tbxLegajo.Text, (float)numSueldo.Value);
                        personasLista.Add(nuevo);
                        MostrarPersonas();
                        break;
                    case 2:
                        nuevo = new Directivos(tbxNombre.Text, tbxApellido.Text, tbxLegajo.Text, (float)numSueldo.Value);
                        personasLista.Add(nuevo);
                        MostrarPersonas();
                        break;
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado.", ex.Message);
            }
        }

        private void CargarCategorias()
        {
            cbxCategorias.Items.Add("Administrativo");
            cbxCategorias.Items.Add("Operario");
            cbxCategorias.Items.Add("Directivo");
        }
        public void MostrarPersonas()
        {
            dgrPersonas.DataSource = null;
            dgrPersonas.DataSource = personasLista;
        }

    }
}
