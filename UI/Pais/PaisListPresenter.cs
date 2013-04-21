using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using ViewModel;
using Model;

namespace UI.Pais
{
    class PaisListPresenter
    {
        #region Atributos
        private readonly IPaisListView m_view;
        private readonly IPaisDao m_paisDao;
        private IEnumerable<PaisViewModel> m_paisViewModelList;
        #endregion

        #region Constructores
        public PaisListPresenter(IPaisListView view, PaisDao dao)
        {
            m_view = view;
            m_paisDao = dao;

            Update();
        }
        #endregion

        #region Metodos
        private void Update()
        {
            IEnumerable<PaisDataEntity> paisDataEntityList = m_paisDao.GetPaises();
            IEnumerable<PaisViewModel> paisViewModelList = ResolveViewModelArray(paisDataEntityList);
            m_paisViewModelList = paisViewModelList;
            m_view.ShowPaises(m_paisViewModelList);
        }

        private IEnumerable<PaisViewModel> ResolveViewModelArray(IEnumerable<PaisDataEntity> paisDataEntityList)
        {
            foreach (PaisDataEntity pais in paisDataEntityList)
            {
                yield return new PaisViewModel(pais);
            }
        }

        public void AgregarPaisAction()
        {
            using (FrmPais view = new FrmPais(m_paisDao))
            {
                view.ShowDialog();
            }
            Update();
        }
        #endregion
    }
}
