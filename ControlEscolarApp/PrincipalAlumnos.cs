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
    public partial class FrmPrincipalAlumnos : Form
    {
        AlumnosManejador _alumnosManejador;
        Alumno _alumno;
        public FrmPrincipalAlumnos()
        {
            InitializeComponent();
            _alumnosManejador = new AlumnosManejador();
            _alumno = new Alumno();
        }

        private void FrmPrincipalAlumnos_Load(object sender, EventArgs e)
        {
            BuscarAlumno("");
        }
        private void BuscarAlumno(String filtro)
        {
            dgvAlumnos.DataSource = _alumnosManejador.ObtenerLista(filtro);
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAlumno(Txt_buscar.Text);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar ese registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscarAlumno("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Eliminar()
        {
            string NumeroControl =Convert.ToString(dgvAlumnos.CurrentRow.Cells["NumeroControl"].Value);
            _alumnosManejador. Eliminar(NumeroControl);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AlumnosModal alumnosModal = new AlumnosModal();
            alumnosModal.ShowDialog();
            BuscarAlumno("");
        }

        private void BindingAlumno()
        {
            _alumno.NumeroControl = dgvAlumnos.CurrentRow.Cells["NumeroControl"].Value.ToString();
            _alumno.Nombre = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            _alumno.ApellidoP = dgvAlumnos.CurrentRow.Cells["ApellidoP"].Value.ToString();
            _alumno.ApellidoM = dgvAlumnos.CurrentRow.Cells["ApellidoM"].Value.ToString();
            _alumno.Sexo = dgvAlumnos.CurrentRow.Cells["Sexo"].Value.ToString();
            _alumno.FechaNacimiento = dgvAlumnos.CurrentRow.Cells["FechaNacimiento"].Value.ToString();
            _alumno.E_mail = dgvAlumnos.CurrentRow.Cells["E_mail"].Value.ToString();
            _alumno.TelefonoContacto = dgvAlumnos.CurrentRow.Cells["TelefonoContacto"].Value.ToString();
            _alumno.Estado = dgvAlumnos.CurrentRow.Cells["Estado"].Value.ToString();
            _alumno.Municipio = dgvAlumnos.CurrentRow.Cells["Municipio"].Value.ToString();
            _alumno.Domicilio = dgvAlumnos.CurrentRow.Cells["Domicilio"].Value.ToString();
        }

        private void DgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingAlumno();
            AlumnosModal alumnosModal = new AlumnosModal(_alumno);
            alumnosModal.ShowDialog();
            BuscarAlumno("");

        }

        private void DgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingAlumno();
           AlumnosModal alumnosModal = new AlumnosModal(_alumno);
            alumnosModal.ShowDialog();
            BuscarAlumno("");

        }
        private void BuscarUsuarios(string filtro)
        {
           dgvAlumnos.DataSource = _alumnosManejador.ObtenerLista(filtro);
        }

    }
}