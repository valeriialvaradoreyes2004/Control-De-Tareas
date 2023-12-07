using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeTareas
{
    public partial class TareasForm : MetroFramework.Forms.MetroForm
    {
        private GestorProyectos gestorProyectos = new GestorProyectos();
        private List<Proyectos> listaProyectos;
        public TareasForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
