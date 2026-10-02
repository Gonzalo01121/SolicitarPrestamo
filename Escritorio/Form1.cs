using System;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IniciarSesion formSolicitud = new IniciarSesion();
            formSolicitud.ShowDialog();
        }

        private void solicitarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SolicitarPrestamo formSolicitud = new SolicitarPrestamo();
            formSolicitud.ShowDialog();

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarUsuario formSolicitud = new AgregarUsuario();
            formSolicitud.ShowDialog();
        }
    }
}
