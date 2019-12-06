using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using Microsoft.VisualBasic.Devices;
using System.Runtime.ConstrainedExecution;

namespace ControlEscolarApp
{
    public partial class MaestrosModal : Form
    {
        EstadoManejador _EstadoManejador;
        MunicipiosManejador _municipiosManejador;
        private MaestroManejador _maestroManejador;
        private Maestros _maestros;
        private bool _isEnablebinding = false;
        Computer Compu = new Computer();
        public MaestrosModal()
        {
            InitializeComponent();
            _maestroManejador = new MaestroManejador();
            _maestros = new Maestros();
            _EstadoManejador = new EstadoManejador();
            _municipiosManejador = new MunicipiosManejador();
            BindingMaestro();
            _isEnablebinding = true;
        }
        private void BindingMaestro()
        {
            if (_isEnablebinding)
            {
                _maestros.NumeroControl = txtNumeroControl.Text;
                _maestros.Nombre = txtNombre.Text;
                _maestros.ApellidoP = txtApellidoP.Text;
                _maestros.ApellidoM = txtApellidoM.Text;
                _maestros.Sexo = CmbSexo.Text;
                _maestros.Fecha_Nan = dtpFechaNacimiento.Text;
                _maestros.Email = txtE_mail.Text;
                _maestros.Tarjeta = txtTarjeta.Text;
                _maestros.Estado = CmbEstado.SelectedValue.ToString();
                _maestros.Ciudad = CmbMunicipio.Text;
                _maestros.Licenciatura = txtLicenciatura.Text;
                _maestros.Maestria = txtMaestria.Text;
                _maestros.Doctorado = txtDoctorado.Text;

            }
        }
    
        private void BindingMaestroReload()
        {
            _maestros.NumeroControl = txtNumeroControl.Text;
            _maestros.Nombre = txtNombre.Text;
            _maestros.ApellidoP = txtApellidoP.Text;
            _maestros.ApellidoM = txtApellidoM.Text;
            _maestros.Sexo = CmbSexo.Text;
            _maestros.Fecha_Nan = dtpFechaNacimiento.Text;
            _maestros.Email = txtE_mail.Text;
            _maestros.Tarjeta = txtTarjeta.Text;
            _maestros.Estado = CmbEstado.SelectedValue.ToString();
            _maestros.Ciudad = CmbMunicipio.Text;
            _maestros.Licenciatura = txtLicenciatura.Text;
            _maestros.Maestria = txtMaestria.Text;
            _maestros.Doctorado = txtDoctorado.Text;

        }
        private void MaestrosModal_Load(object sender, EventArgs e)
        {
            llenarEstados("");
            llenarMunicipios("");
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BindingMaestro();
            if (ValidarMaestro())
            {
                if (ValidarApellidoP())
                {
                    if (ValidarApellidoM())
                    {
                        if (ValidarTarjeta())
                        {
                            if (txtLicenciatura.Text != "")
                                Compu.FileSystem.CopyFile(txtLicenciatura.Text, @"C:\Users\nuevo\Licenciatura.pdf");
                            else if (txtDoctorado.Text != "")
                                Compu.FileSystem.CopyFile(txtDoctorado.Text, @"C:\Users\nuevo\Doctorado.pdf");
                            else if (txtMaestria.Text != "")
                                Compu.FileSystem.CopyFile(txtMaestria.Text, @"C:\Users\nuevo\Maestria.pdf");
                            Guardar();
                            this.Close();
                            Guardar();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Guardar()
        {
            _maestroManejador.Guardar(_maestros);
        }
        private bool ValidarMaestro()
        {
            var res = _maestroManejador.EsUsuarioValido(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }

        private bool ValidarApellidoP()
        {
            var res = _maestroManejador.EsApellidoPValido(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }

        private bool ValidarApellidoM()
        {
            var res = _maestroManejador.EsApellidoMValido(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }
        private bool ValidarTarjeta()
        {
            var res = _maestroManejador.EsTarjetaValida(_maestros);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }
        private void llenarEstados(string filtro)
        {
            CmbEstado.DataSource = _EstadoManejador.ObtenerEstado(filtro);
            CmbEstado.DisplayMember = "Estado";
            CmbEstado.ValueMember = "Codigo";

        }
        private void llenarMunicipios(string filtro)
        {
            CmbMunicipio.DataSource = _municipiosManejador.ObtenerMunicipio(filtro);
            CmbMunicipio.DisplayMember = "municipio";
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarMunicipios(CmbEstado.SelectedValue.ToString());
        }

        private void CmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void TxtApellidoP_TextChanged(object sender, EventArgs e)
        {
            BindingMaestro();
        }

        private void TxtApellidoM_TextChanged(object sender, EventArgs e)
        {
            BindingMaestro();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            BindingMaestro();
        }

        private void TxtTarjeta_TextChanged(object sender, EventArgs e)
        {
            BindingMaestro();
        }

        private void BtnAgregarL_Click(object sender, EventArgs e)
        {
            var resultado = AgregarAE.ShowDialog();
            if (resultado == DialogResult.OK) { txtLicenciatura.Text = AgregarAE.FileName; }
        }

        private void BtnAgregarM_Click(object sender, EventArgs e)
        {
            var resultado = AgregarAE.ShowDialog();
            if (resultado == DialogResult.OK) { txtMaestria.Text = AgregarAE.FileName; }
        }

        private void BtnAgregarD_Click(object sender, EventArgs e)
        {
            var resultado = AgregarAE.ShowDialog();
            if (resultado == DialogResult.OK) {txtDoctorado.Text = AgregarAE.FileName; }
        }

        private void BtnLimpiarL_Click(object sender, EventArgs e)
        {
            txtLicenciatura.Clear();
        }

        private void BtnLimpiarM_Click(object sender, EventArgs e)
        {
            txtMaestria.Clear();
        }

        private void BtnLimpiarD_Click(object sender, EventArgs e)
        {
            txtDoctorado.Clear();
        }
    }
}
