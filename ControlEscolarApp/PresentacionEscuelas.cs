using System;
using System.Windows.Forms;
using LogicaNegocio.ControlEscolarApp;
using Entidades.ControlEscolarApp;
using Extensions.ControlEscolar;

namespace ControlEscolarApp
{
    public partial class PresentacionEscuelas : Form
    {
        private OpenFileDialog _dialogCargarLogo;
        private EscuelasManejador _escuelaManejador;
        private bool _isEnableBinding = false;
        private bool _isImagenClear = false;
        private Escuela _escuelas;
        private RutasManager _rutasManager;

        public PresentacionEscuelas()
        {
            InitializeComponent();
            _dialogCargarLogo = new OpenFileDialog();
            _rutasManager = new RutasManager(Application.StartupPath);

            _escuelas = new Escuela();
            _escuelaManejador = new EscuelasManejador(_rutasManager);
            _escuelas = _escuelaManejador.GetEscuela();

            if (!string.IsNullOrEmpty(_escuelas.Idescuela.ToString()))
            {
                LoadEntity();
            }
            _isEnableBinding = true;
        }
        public void LoadEntity()
        {
            txtNombre.Text = _escuelas.Nombre;
            txtDirector.Text = _escuelas.Director;
            picLogo.ImageLocation = null;
            if (!string.IsNullOrEmpty(_escuelas.Logo)&& string.IsNullOrEmpty(_dialogCargarLogo.FileName))
            {
                picLogo.ImageLocation = _rutasManager.RutaLogoEscuela(_escuela);
            }
        }


        private void BtnAgregarLogo_Click(object sender, EventArgs e)
        {
            CargarLogo();
        }
        private void CargarLogo()
        {
            _dialogCargarLogo.Filter = "Imagen tipo (*.png)|*.png";
            _dialogCargarLogo.Title = "Cargar Archivo Imagen";
            _dialogCargarLogo.ShowDialog();

            if (_dialogCargarLogo.FileName != "")
            {
                if (_escuelaManejador.CargarLogo (_dialogCargarLogo.FileName))
                {
                    picLogo.ImageLocation = _dialogCargarLogo.FileName;
                    _isImagenClear = false;
                }
                else
                {
                    MessageBox.Show("");
                }
            }
        }

        private void PresentacionEscuelas_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminarLogo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar Logo","Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                EliminarLogo();
            }
        }
        private void EliminarLogo()
        {
            picLogo.ImageLocation = null;
            _isImagenClear = true;
        }
        private void ActivarCuadros()
        { }
        private void ActivarBotoner()
        { }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //ActivarCuadros(false);
            //ActivarBonotes(true, false, false, false, false);
            if (MessageBox.Show("Esta seguro que desea salir", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                EliminarLogo();
            }
        }
        private void BindEntity()
        {
            if (_isEnableBinding)
            {
                _escuelas.Nombre = txtNombre.Text;
                _escuelas.Director = txtDirector.Text;
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            BindEntity();
        }

        private void TxtDirector_TextChanged(object sender, EventArgs e)
        {
            BindEntity();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
        }
        private void Guardar()
        {
            try
            {
                if (picLogo.Image != null)
                {
                    if (!string.IsNullOrEmpty(_dialogCargarLogo.FileName))
                    {
                        _escuelas.Logo = _escuelaManejador.GetNombreLogo(_dialogCargarLogo.FileName);
                        if (!string.IsNullOrEmpty(_escuelas.Logo))
                        {
                            _escuelaManejador.GuardarLogo(_dialogCargarLogo.FileName, 1);
                            _dialogCargarLogo.Dispose();
                        }
                    }
                }
                else
                {
                    _escuelas.Logo = string.Empty;
                }

                if (_isImagenClear)
                {
                    _escuelaManejador.LimpiarDocumento(1, "png");
                    _escuelaManejador.LimpiarDocumento(1, "jpg");
                }

                _escuelaManejador.Guardar(_escuelas);
                //solo sirve para guardar vasio o con el nombre en la base de datos 
            }
            catch (Exception ex)
            {
            }
        }

    }
}
