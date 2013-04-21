using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using ViewModel;

namespace UI.Pais
{
    public class PaisPresenter
    {
        #region Atributos
        private IPaisView m_view;
        private IPaisDao m_paisDao;
        private PaisViewModel m_viewModel;
        #endregion

        #region Constructores
        public PaisPresenter(IPaisView view, IPaisDao paisDao)
        {
            m_view = view;
            m_paisDao = paisDao;

            PaisDataEntity paisDataEntity = m_paisDao.crearPaisDataEntity();
            PaisViewModel paisViewModel = new PaisViewModel(paisDataEntity);

            m_viewModel = paisViewModel;
            m_view.ShowPais(paisViewModel);
        }
        #endregion

        #region Metodos
        public void SaveAction()
        {
            m_view.ReadUserInput();
            PaisDataEntity pais = m_viewModel.PaisDataEntity;
            bool entidadExiste = !EsDuplicado(pais);
            if (entidadExiste)
            {
                m_paisDao.Save(pais);
                m_view.Close();
            } else {
                m_view.ShowError(string.Format("Pais {0} ya existe", m_viewModel.Descripcion));
            }
        }

        public void CancelAction ()
        {
            m_view.Close();
        }

        private bool EsDuplicado(PaisDataEntity nuevoPais)
        {
            PaisDataEntity pais = m_paisDao.GetByDescripcion(nuevoPais.Descripcion);

            return pais != null;
        }
        #endregion
    }
}
