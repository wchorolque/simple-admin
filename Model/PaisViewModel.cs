using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PaisViewModel
    {
        #region Atributos
        private readonly PaisDataEntity m_paisDataEntity;
        #endregion

        #region Propiedades
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public PaisDataEntity PaisDataEntity 
        {
            get { return m_paisDataEntity; } 
        }
        #endregion

        #region Constructores
        public PaisViewModel(PaisDataEntity paisDataEntity)
        {
            m_paisDataEntity = paisDataEntity;
        }
        #endregion

    }
}
