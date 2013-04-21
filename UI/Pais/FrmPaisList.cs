using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace UI.Pais
{
    public partial class FrmPaisList : Form, IPaisListView
    {
        private PaisListPresenter m_presenter;

        public FrmPaisList()
        {
            InitializeComponent();
        }

        public FrmPaisList(PaisDao paisDao) : this()
        {
            m_presenter = new PaisListPresenter(this, paisDao);
        }

        public void ShowPaises(IEnumerable<ViewModel.PaisViewModel> paisViewModelList)
        {
            bindingSourcePais.DataSource = paisViewModelList;
        }

        private void tSBtnAdd_Click(object sender, EventArgs e)
        {
            m_presenter.AgregarPaisAction();
        }

        private void tSBtnClose_Click(object sender, EventArgs e)
        {
            m_presenter.CerrarAction();
        }
    }
}
