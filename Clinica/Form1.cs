using Clinica.Modelo_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Form1 : Form
    {
        private CitasContext _context;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var context = new CitasContext())
            {
                // Crear una nueva instancia de Cita con los datos del formulario
                var nuevaCita = new Cita
                {
                    PacienteID = int.Parse(txtPacienteID.Text),
                    Fecha = dtpFecha.Value.Date,
                    Hora = TimeSpan.Parse(txtHora.Text),
                    Motivo = txtMotivo.Text,
                    Estado = cmbEstado.SelectedItem.ToString()
                };

                // Agregar la nueva cita al contexto y guardar los cambios
                context.Citas.Add(nuevaCita);
                context.SaveChanges();
            }

            MessageBox.Show("Cita agregada exitosamente.");
        }
    }
}


