using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;


namespace ControlEscolarApp
{
    public partial class PrincipalEscuelas : Form
    {
        EscuelasManejador _escuelaManejador;
        Escuela _escuela;

        public PrincipalEscuelas()
        {
            InitializeComponent();
            InitializeComponent();
            _escuelaManejador = new EscuelasManejador();
            _escuela = new Escuela();
        }
        private void BuscaEscuelas(String filtro)
        {
            dgvEscuelas.DataSource = _escuelaManejador.ObtenerLista(filtro);
        }
        private void PrincipalEscuelas_Load(object sender, EventArgs e)
        {
            BuscaEscuelas("");
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            EscuelasModal escuelaModal = new EscuelasModal();
            escuelaModal.ShowDialog();
            BuscaEscuelas("");
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas eliminar ese registro", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Eliminar();
                    BuscaEscuelas("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void Eliminar()
        {
            Int32 IdEscuela = Convert.ToInt32(dgvEscuelas.CurrentRow.Cells["idescuela "].Value);
            _escuelaManejador.Eliminar(IdEscuela);
        }
        private void BindingEscuela()
        {

            _escuela.Idescuela = int.Parse(dgvEscuelas.CurrentRow.Cells["idescuela"].Value.ToString());
            _escuela.Nombre = dgvEscuelas.CurrentRow.Cells["nombre"].Value.ToString();
            _escuela.Director = dgvEscuelas.CurrentRow.Cells["director"].Value.ToString();
            _escuela.Domicilio = dgvEscuelas.CurrentRow.Cells["domicilio"].Value.ToString();
            _escuela.Numeroexterior = dgvEscuelas.CurrentRow.Cells["numeroexterior"].Value.ToString();
            _escuela.Estado = dgvEscuelas.CurrentRow.Cells["estado"].Value.ToString();
            _escuela.Municipio = dgvEscuelas.CurrentRow.Cells["municipio"].Value.ToString();
            _escuela.Telefono = _escuela.Telefono = dgvEscuelas.CurrentRow.Cells["telefono"].Value.ToString();
            _escuela.E_mail = dgvEscuelas.CurrentRow.Cells["e_mail"].Value.ToString();
            _escuela.Paginaweb = dgvEscuelas.CurrentRow.Cells["paginaweb"].Value.ToString();

        }

        private void DgvEscuelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BindingEscuela();
            EscuelasModal escuelaModal = new EscuelasModal(_escuela);
            escuelaModal.ShowDialog();
            BuscaEscuelas("");
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            BuscaEscuelas(Txt_buscar.Text);
        }
    }
}
