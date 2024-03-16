using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaLogica;

namespace CapaPresentacion
{
    public partial class FrmModuloEspecialista : Form
    {
        public FrmModuloEspecialista()
        {
            InitializeComponent();
        }

        //Mostrar mensaje de ok
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Clinico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Mostrar mensaje Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Clinico",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtEspecialistaCMP.Text = "0";
            this.txtNombreEspecialista.Text = string.Empty;
            this.txtApellidoEspecialista.Text = string.Empty;
            this.comboBoxEspecialista.SelectedIndex = -1;
        }

        //Cargar Datos en GV
        private void CargarDatosEspecialista()
        {
            try
            {
                DataTable dtEspecialista = NEspecialista.ListarEspecialista();
                if (dtEspecialista != null && dtEspecialista.Rows.Count > 0)
                {
                    this.dgvEspecialista.DataSource = dtEspecialista;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos de pacientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de pacientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarDatosEspecialista()
        {
            try
            {
                this.dgvEspecialista.DataSource = NEspecialista.ListarEspecialistaCMP(this.txtEspecialistaCMP.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar los datos del especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmModuloEspecialista_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatosEspecialista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los especialistas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuscarDatosEspecialista();
        }

        private void InsertaEspecialista()
        {
            try
            {
                // Convertir el valor del cuadro de texto a entero para EspecialistaCMP
                int EspecialistaCMP = int.Parse(txtEspecialistaCMP.Text.Trim());

                // Obtener el nombre del especialista del cuadro de texto y limpiarlo
                string NombreEspecialista = txtNombreEspecialista.Text.Trim();

                // Obtener el apellido del especialista del cuadro de texto y limpiarlo
                string ApellidoEspecialista = txtApellidoEspecialista.Text.Trim();

                // Validación básica (puedes agregar más validaciones)
                if (EspecialistaCMP == 0 || string.IsNullOrEmpty(NombreEspecialista) || string.IsNullOrEmpty(ApellidoEspecialista))
                {
                    MessageBox.Show("Los campos código, nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Aquí puedes llamar a NEspecialista.Insertar para insertar el especialista en la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificaEspecialista()
        {
            try
            {
                // Convertir el valor del cuadro de texto a entero para EspecialistaCMP
                int EspecialistaCMP = int.Parse(txtEspecialistaCMP.Text.Trim());

                // Obtener el nombre del especialista del cuadro de texto y limpiarlo
                string NombreEspecialista = txtNombreEspecialista.Text.Trim();

                // Obtener el apellido del especialista del cuadro de texto y limpiarlo
                string ApellidoEspecialista = txtApellidoEspecialista.Text.Trim();

                // Aquí puedes llamar a NEspecialista.Actualizar para actualizar el especialista en la base de datos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el especialista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
