using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;


namespace ControlEscolarApp
{
    public partial class PrincipalMaestros : Form
    {
        Maestros _maestros;
        MaestroManejador _maestroManejador;
        public PrincipalMaestros()
        {
            InitializeComponent();
            _maestroManejador = new MaestroManejador();
            _maestros = new Maestros();
        }
        private void BuscarMaestro(String filtro)
        {
            dgvMaestros.DataSource = _maestroManejador.ObtenerLista(filtro);
        }

        private void PrincipalMaestros_Load(object sender, EventArgs e)
        {

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarMaestro(Txt_buscar.Text);
        }
        private void BindingMaestro()
        {
            _maestros.NumeroControl = dgvMaestros.CurrentRow.Cells["NumeroControl"].Value.ToString();
            _maestros.Nombre = dgvMaestros.CurrentRow.Cells["Nombre"].Value.ToString();
            _maestros.ApellidoP = dgvMaestros.CurrentRow.Cells["ApellidoP"].Value.ToString();
            _maestros.ApellidoM = dgvMaestros.CurrentRow.Cells["ApellidoM"].Value.ToString();
            _maestros.Sexo = dgvMaestros.CurrentRow.Cells["Sexo"].Value.ToString();
            _maestros.Fecha_Nan = dgvMaestros.CurrentRow.Cells["Fecha_Nan"].Value.ToString();
            _maestros.Email = dgvMaestros.CurrentRow.Cells["Email"].Value.ToString();
            _maestros.Tarjeta = dgvMaestros.CurrentRow.Cells["Tarjeta"].Value.ToString();
            _maestros.Estado = dgvMaestros.CurrentRow.Cells["Estado"].Value.ToString();
            _maestros.Ciudad = dgvMaestros.CurrentRow.Cells["Ciudad"].Value.ToString();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            MaestrosModal maestrosModal = new MaestrosModal();
            maestrosModal.ShowDialog();
            BuscarMaestro("");
        }
        private void BuscarUsuarios(string filtro)
        {
            dgvMaestros.DataSource = _maestroManejador.ObtenerLista(filtro);
        }
        private void DgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingMaestro();
            MaestrosModal maestrosModal = new MaestrosModal();
            maestrosModal.ShowDialog();
            BuscarMaestro("");

        }

        private void DgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingMaestro();
            MaestrosModal maestrosModal = new MaestrosModal();
            maestrosModal.ShowDialog();
            BuscarMaestro("");

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar ese registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscarMaestro("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Eliminar()
        {
            string NumeroControl = Convert.ToString(dgvMaestros.CurrentRow.Cells["NumeroControl"].Value);
            _maestroManejador.Eliminar(NumeroControl);
        }

    }
}
