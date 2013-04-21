using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Model;
using ViewModel;

namespace UI.Pais
{
    public partial class FrmPais : Form, IPaisView
    {
        private PaisPresenter m_presenter;

        public FrmPais(IPaisDao dao)
        {
            InitializeComponent();

            m_presenter = new PaisPresenter(this, dao);
        }

        public void ShowPais(PaisViewModel paisViewModel)
        {
            bindingSourcePais.DataSource = paisViewModel;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            m_presenter.SaveAction();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            m_presenter.CancelAction();
        }
    }
}
