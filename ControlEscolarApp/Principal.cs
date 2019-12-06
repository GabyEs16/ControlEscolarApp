using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEscolarApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void AlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipalAlumnos frmPrincipalAlumnos = new FrmPrincipalAlumnos();
            frmPrincipalAlumnos.ShowDialog();
        }

        private void CatalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void MaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrincipalMaestros principalMaestros = new PrincipalMaestros();
            principalMaestros.ShowDialog();
        }

        private void EscuelasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrincipalEscuelas principalEscuelas = new PrincipalEscuelas();
            principalEscuelas.ShowDialog();
        }
    }
}
