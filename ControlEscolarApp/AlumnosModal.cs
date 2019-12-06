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
    public partial class AlumnosModal : Form
    {
       EstadoManejador _EstadoManejador;
        MunicipiosManejador _municipiosManejador;
        private AlumnosManejador _alumnosManejador;
        private Alumno _Alumno;
        private bool _isEnablebinding = false;

        public AlumnosModal()
        {
            InitializeComponent();
            _alumnosManejador = new AlumnosManejador();
            _Alumno = new Alumno();
            
            _EstadoManejador = new EstadoManejador();
            _municipiosManejador = new MunicipiosManejador();
            BindingAlumno();
            _isEnablebinding = true;

        }
        private void BindingAlumno()
        {
            if(_isEnablebinding)
            {
                _Alumno.NumeroControl = txtNumeroControl.Text;
                _Alumno.Nombre = txtNombre.Text;
                _Alumno.ApellidoP = txtApellidoP.Text;
                _Alumno.ApellidoM = txtApellidoM.Text;
                _Alumno.Sexo = CmbSexo.Text;
                _Alumno.FechaNacimiento = dtpFechaNacimiento.Text;
                _Alumno.E_mail = txtE_mail.Text;
                _Alumno.TelefonoContacto =txtTelefono.Text;
                _Alumno.Estado = CmbEstado.SelectedValue.ToString();
                _Alumno.Municipio = CmbMunicipio.Text;
                _Alumno.Domicilio = txtDomicilio.Text;
               
            }
        }
        public AlumnosModal(Alumno alumno)
        {
            InitializeComponent();
            _alumnosManejador = new AlumnosManejador();
            _Alumno = new Alumno();
            BindingAlumnoReload();
            _EstadoManejador = new EstadoManejador();
            _municipiosManejador = new MunicipiosManejador();
            _isEnablebinding = true;
           
        }

        private void BindingAlumnoReload()
        {

            txtNumeroControl.Text = _Alumno.NumeroControl;
            txtNombre.Text = _Alumno.Nombre;
            txtApellidoP.Text = _Alumno.ApellidoP;
            txtApellidoM.Text = _Alumno.ApellidoM;
            CmbSexo.Text = _Alumno.Sexo;
            dtpFechaNacimiento.Text = _Alumno.FechaNacimiento;
            txtE_mail.Text = _Alumno.E_mail;
            txtTelefono.Text = _Alumno.TelefonoContacto;
            CmbEstado.Text = _Alumno.Estado;
            CmbMunicipio.Text = _Alumno.Municipio;
            txtDomicilio.Text = _Alumno.Domicilio;                
        }

        

        private void AlumnosModal_Load(object sender, EventArgs e)
        {
            llenarEstados("");
            llenarMunicipios("");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            BindingAlumno();
            if (ValidarAlumno())
            {
                if (ValidarApellidoP())
                {
                    if (ValidarApellidoM())
                    {
                        if (ValidarTelefono())
                        {
                            Guardar();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void Guardar()
        {
            _alumnosManejador.Guardar(_Alumno);
        }

 

        private bool ValidarAlumno()
        {
            var res = _alumnosManejador.EsUsuarioValido(_Alumno);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;
          
        }

        private bool ValidarApellidoP()
        {
            var res = _alumnosManejador.EsApellidoPValido(_Alumno);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }

        private bool ValidarApellidoM()
        {
            var res = _alumnosManejador.EsApellidoMValido(_Alumno);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }
        private bool ValidarTelefono()
        {
            var res = _alumnosManejador.EsTelefonoValido(_Alumno);
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
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CmbEstado_TextChanged(object sender, EventArgs e)
        {
            llenarMunicipios(CmbEstado.SelectedValue.ToString());
        }

        private void CmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbMunicipio_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void CmbEstado_TextUpdate(object sender, EventArgs e)
        {

        }

        private void CmbEstado_TextChanged_1(object sender, EventArgs e)
        {
            llenarMunicipios(CmbEstado.SelectedValue.ToString());
        }

        private void CmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }

        private void TxtNumeroControl_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }

        private void TxtApellidoP_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }

        private void TxtApellidoM_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }

        private void TxtE_mail_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            BindingAlumno();
        }
    }
}
