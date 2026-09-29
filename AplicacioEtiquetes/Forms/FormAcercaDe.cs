using System;
using System.Windows.Forms;

namespace AplicacioEtiquetes.Forms
{
    public partial class FormAcercaDe : Form
    {
        public FormAcercaDe()
        {
            InitializeComponent();
        }

        private void FormAcercaDe_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
/*
        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
*/

        private void gitHubLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            gitHubLink.LinkVisited = true;

            try
            {
                System.Diagnostics.Process.Start("https://github.com/Alek0MC2009");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obrir l'enllaç: " + ex.Message);
            }
        }
    }
}