using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class SolicitarPrestamo : Form
    {
        public SolicitarPrestamo()
        {
            InitializeComponent();
        }

        private void SolicitarPrestamo_Load(object sender, EventArgs e)
        {
            Equipo();
            Carrera();
            TipoDeSolicitante();
            Horario();

            gbxDatosSoli.Enabled = true;
            gbxDetalles.Enabled = false;
            btnAceptar.Enabled = false;

            dtpfechasoli1.MinDate = DateTime.Today;
        }

        #region Métodos de Carga de Datos
        private void Equipo()
        {
            cbxDispositivo.Items.Clear();
            cbxDispositivo.Items.AddRange(new string[]
            {
                "Laptop Dell no serie 1234",
                "Laptop HP no serie 234",
                "Proyector Dell no serie 1234",
                "Laptop Lenovo no 34231124"
            });
        }

        private void Carrera()
        {
            cbxCarrera.Items.Clear();
            cbxCarrera.Items.AddRange(new string[]
            {
                "Biomédica",
                "Industrial",
                "Mecánica",
                "Mecatrónica",
                "Sistemas",
                "Informática"
            });
        }

        private void TipoDeSolicitante()
        {
            cbxTipodeSolicitante.Items.Clear();
            cbxTipodeSolicitante.Items.AddRange(new string[]
            {
                "Docente",
                "Alumno",
                "Administrador"
            });
        }

        private void Horario()
        {
            cbxHora.Items.Clear();
            cbxHora.Items.AddRange(new string[]
            {
                "7:00 - 8:00",
                "8:00 - 9:00",
                "9:00 - 10:00 No Disponible",
                "10:00 - 11:00 No Disponible",
                "11:00 - 12:00",
                "12:00 - 13:00"
            });
        }
        #endregion

        #region Validaciones Progresivas
        private void ValidarDatosSolicitante()
        {
            bool datosCompletos = !string.IsNullOrWhiteSpace(txtNombre.Text)
                && !string.IsNullOrWhiteSpace(txtNoControl2.Text)
                && cbxCarrera.SelectedIndex != -1
                && cbxTipodeSolicitante.SelectedIndex != -1;

            if (datosCompletos)
            {
                gbxDetalles.Enabled = true;
            }
            else
            {
                gbxDetalles.Enabled = false;
                //btnAceptar.Enabled = false;   
            }
        }

        private void ValidarDetallesPrestamo()
        {
            bool dispositivoValido = cbxDispositivo.SelectedIndex != -1;
            bool horaValida = cbxHora.SelectedIndex != -1;
            bool horaDisponible = horaValida && !cbxHora.Text.Contains("No Disponible");

            
            btnAceptar.Enabled = gbxDetalles.Enabled
                && horaDisponible
                && (dtpfechasoli.Value.Date >= DateTime.Today)
                && dvgSeleccionar.Rows.Count > 0; 
        }
        #endregion

        #region Eventos del Diseñador (Corregidos)
        private void cbxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatosSolicitante();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatosSolicitante();
        }

        private void ControlSolicitante_Changed(object sender, EventArgs e)
        {
            ValidarDatosSolicitante();
            ValidarDetallesPrestamo();
        }

        private void ControlDetalles_Changed(object sender, EventArgs e)
        {
            ValidarDetallesPrestamo();

            if (cbxHora.SelectedIndex != -1 && cbxHora.Text.Contains("No Disponible"))
            {
                MessageBox.Show("El horario seleccionado no está disponible. Selecciona otro.",
                    "Horario No Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxHora.SelectedIndex = -1;
            }
            if (dtpfechasoli.Value.Date == DateTime.Today && !string.IsNullOrWhiteSpace(cbxHora.Text))
            {
                string HoraTexto = cbxHora.Text.Split('-')[0].Trim();
                TimeSpan horaPrestamo = TimeSpan.Parse(HoraTexto);

                if (horaPrestamo <= DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("ERROR: LA HORA SELECCIONADA YA PASÓ. HORARIO NO VÁLIDO.",
                    "NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxHora.SelectedIndex = -1;
                }
            }
        }

        
        private void txtNoControl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        
        private void cbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Acciones de Botones y DataGridView
        private void btnAgregardispositivo_Click(object sender, EventArgs e)
        {
            
            if (cbxDispositivo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un dispositivo.", "Campo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            if (string.IsNullOrWhiteSpace(cbxCantidad.Text))
            {
                MessageBox.Show("Debes ingresar una cantidad.", "Campo no válido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            
            dvgSeleccionar.Rows.Add(cbxDispositivo.Text, cbxCantidad.Text);

            
            cbxDispositivo.SelectedIndex = -1;
            cbxCantidad.Text = "";

            ValidarDetallesPrestamo(); 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dvgSeleccionar.Rows.Count == 0 || (dvgSeleccionar.Rows.Count == 1 && dvgSeleccionar.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay elementos en la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (dvgSeleccionar.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dvgSeleccionar.SelectedRows[0];

                if (!filaSeleccionada.IsNewRow) 
                {
                    dvgSeleccionar.Rows.Remove(filaSeleccionada);
                    ValidarDetallesPrestamo(); 
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un renglón válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón para eliminar.", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            
            if (txtNoControl2.Text.Trim().Length != 8)
            {
                MessageBox.Show("El Número de Control debe tener exactamente 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoControl2.Focus();
                return;
            }

           
            if (dvgSeleccionar.Rows.Count == 0 || (dvgSeleccionar.Rows.Count == 1 && dvgSeleccionar.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un dispositivo a la lista.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Solicitud de préstamo registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitarPrestamo_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (DialogResult != DialogResult.OK)
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Deseas cancelar la solicitud y cerrar el Formulario?",
                    "Información del Sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

    
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e) { }

        private void txtNoControl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxHora.SelectedIndex == -1)
            {
                ValidarDetallesPrestamo();
                return;
            }

            
            string seleccion = cbxHora.SelectedItem.ToString();

            
            if (seleccion.Contains("No Disponible"))
            {
                MessageBox.Show("El horario seleccionado no está disponible. Selecciona otro.",
                    "Horario No Disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cbxHora.SelectedIndex = -1; 
                ValidarDetallesPrestamo();
                return;
            }

            
            if (dtpfechasoli1.Value.Date == DateTime.Today)
            {
                try
                {
                   
                    string HoraTexto = seleccion.Split('-')[0].Trim();
                    TimeSpan horaPrestamo = TimeSpan.Parse(HoraTexto);

                    if (horaPrestamo <= DateTime.Now.TimeOfDay)
                    {
                        MessageBox.Show("ERROR: LA HORA SELECCIONADA YA PASÓ. HORARIO NO VÁLIDO.",
                        "NO VÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cbxHora.SelectedIndex = -1;
                        ValidarDetallesPrestamo();
                        return;
                    }
                }
                catch
                {
                   
                }
            }

            
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtNoControl2.Text) ||
        cbxTipodeSolicitante.SelectedIndex == -1 ||
        cbxCarrera.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, completa todos los 'Datos del Solicitante'.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            if (txtNoControl2.Text.Trim().Length != 8)
            {
                MessageBox.Show("El Número de Control debe tener exactamente 8 dígitos.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNoControl2.Focus();
                return;
            }

            
            if (cbxHora.SelectedIndex == -1 || cbxHora.Text.Contains("No Disponible"))
            {
                MessageBox.Show("Por favor, selecciona una 'Hora de Uso' que esté disponible.", "Horario inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dvgSeleccionar.Rows.Count == 0 || (dvgSeleccionar.Rows.Count == 1 && dvgSeleccionar.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debes agregar al menos un dispositivo a la lista usando el botón 'Agregar'.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            MessageBox.Show("¡La solicitud de préstamo ha sido registrada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarFormulario();
            this.Close();
        }
        private void LimpiarFormulario()
        {
           
            txtNombre.Text = "";
            txtNoControl2.Text = "";
           
            cbxTipodeSolicitante.SelectedIndex = -1;
            cbxCarrera.SelectedIndex = -1;
 
            dtpfechasoli1.Value = DateTime.Today;
            cbxHora.SelectedIndex = -1;
            cbxDispositivo.SelectedIndex = -1;
            cbxCantidad.Text = "";
            cbxCantidad.SelectedIndex = -1;
            dvgSeleccionar.Rows.Clear();
            gbxDetalles.Enabled = false;
            btnAceptar.Enabled = false;

           
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           
            string textoLimpio = Regex.Replace(txtNombre.Text, @"[^a-zA-ZáéíóúÁÉÍÓÚñÑ\s]", "");

            if (txtNombre.Text != textoLimpio)
            {
                txtNombre.Text = textoLimpio;
                txtNombre.SelectionStart = txtNombre.Text.Length;
            }
        }

        

        private void txtNumControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }

        }

        private void cbxDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbxDetalles_Enter(object sender, EventArgs e)
        {

        }
    }
}