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
using System.IO;

namespace ControlEscolarApp
{
    public partial class EscuelasModal : Form
    {
        EstadoManejador _EstadoManejador;
        MunicipiosManejador _municipiosManejador;
        private EscuelasManejador _escuelaManejador;
        private Escuela _escuela;
        private bool _isEnablebinding = false;
        public EscuelasModal()
        {
            InitializeComponent();
            _escuelaManejador = new EscuelasManejador();
            _escuela = new Escuela();
            _EstadoManejador = new EstadoManejador();
            _municipiosManejador = new MunicipiosManejador();
            BindingEscuela();
            _isEnablebinding = true;
        }
        private void BindingEscuela()
        {
            if (_isEnablebinding)
            {
                _escuela.Nombre = txtNombre.Text;
                _escuela.Director = txtDirector.Text;
                _escuela.Nombre = txtNombre.Text;
                _escuela.Director = txtDirector.Text;
                _escuela.Domicilio = txtDomicilio.Text;
                _escuela.Numeroexterior = txtNumExterior.Text;
                _escuela.Telefono = txtTelefono.Text;
                _escuela.E_mail = txtE_mail.Text;
                _escuela.Estado = CmbEstado.SelectedValue.ToString();
                _escuela.Municipio = CmbMunicipio.Text;
                _escuela.Paginaweb = txtPaginaWeb.Text;
                _escuela.Logo = pictureBox1.ImageLocation;
                _escuela.Logo = textBox1.Text;

            }
        }
        private void BindingEscuelaReload()
        {

            txtNombre.Text = _escuela.Nombre;
            txtDirector.Text = _escuela.Director;
            txtDomicilio.Text = _escuela.Domicilio;
            txtNumExterior.Text = _escuela.Numeroexterior;
            txtTelefono.Text = _escuela.Telefono;
            txtE_mail.Text = _escuela.E_mail;
            CmbEstado.SelectedValue = _escuela.Estado.ToString();
            CmbMunicipio.Text = _escuela.Municipio;
            txtPaginaWeb.Text = _escuela.Paginaweb;
            CmbMunicipio.Text = _escuela.Municipio;
            txtDomicilio.Text = _escuela.Domicilio;
            pictureBox1.ImageLocation = Convert.ToString(_escuela.Logo);
            textBox1.Text = _escuela.Logo;

        }
        public EscuelasModal(Escuela escuela)
        {
            InitializeComponent();
            _escuelaManejador = new EscuelasManejador();
            _escuela = new Escuela();
            BindingEscuelaReload();
            _EstadoManejador = new EstadoManejador();
            _municipiosManejador = new MunicipiosManejador();
            _isEnablebinding = true;
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


        private void EscuelasModal_Load(object sender, EventArgs e)
        {
            llenarEstados("");
            llenarMunicipios("");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingEscuela();
        }
        private bool ValidarEscuela()
        {
            var res = _escuelaManejador.EsEscuelaValido(_escuela);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }
        private bool ValidarTelefono()
        {
            var res = _escuelaManejador.EsTelefonoValido(_escuela);
            if (!res.Item1)
            {
                MessageBox.Show(res.Item2);
            }
            return res.Item1;

        }
        private void Guardar()
        {
            _escuelaManejador.Guardar(_escuela);
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //m
            BindingEscuela();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string logo =pictureBox1.ToString();
            logo = (@"C:\Users\GEH\Documents\Logo Escuela" + textBox1.Text.Trim());
            bool exist;
            exist = (Directory.Exists(logo));
            if (exist)
            {
                Directory.CreateDirectory(logo);
                MessageBox.Show("Se creo en la Carpeta");
            }
            else
            {
                MessageBox.Show("No se creo");
            }
            saveFileDialog.FileName = txtNombre.Text;
            saveFileDialog.Filter = "jpg filles |*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save (saveFileDialog.FileName);
            }
            try
            {
                if (ValidarEscuela())
                {
                    if (ValidarTelefono())
                    {
                        Guardar();
                        this.Close();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("");
            }
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbMunicipio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CmbEstado_TextChanged(object sender, EventArgs e)
        {
            llenarMunicipios(CmbEstado.SelectedValue.ToString());
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"C:\Users\GEH\Documents\BackGrounImage");
        }

        private void BtnAgregarImagen_Click(object sender, EventArgs e)
        {
            //Metodo para agregar Imagen

            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            //Aquí incluiremos los filtros que queramos.
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Titulo del Dialogo";
            BuscarImagen.InitialDirectory = "C:/Users/GEH/Documents/Logo Escuela/";
            BuscarImagen.FileName = this.textBox1.Text;
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                //validacion de tamaño va Logica de negocio 
                FileStream img = File.OpenRead(BuscarImagen.FileName);
                if (img.Length <= 512000)
                {

                    /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                    this.textBox1.Text = BuscarImagen.FileName;
                    String Direccion = BuscarImagen.FileName;
                    this.pictureBox1.ImageLocation = Direccion;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("No se admiten imagenes mayores a 5 MB");
                }
            }
            else
            {
                MessageBox.Show("Imagen Guardada", MessageBoxButtons.OK.ToString());
            }
            
        }

        private void BtnEliminaI_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Clear();
        }
    }
}
