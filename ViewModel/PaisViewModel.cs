using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace ViewModel
{
    public class PaisViewModel
    {
        #region Atributos
        private readonly PaisDataEntity m_paisDataEntity;
        #endregion

        #region Propiedades
        public string Codigo { 
            get {
                return m_paisDataEntity.Codigo;
            }
            set {
                m_paisDataEntity.Codigo = value;
            }
        }

        public string Descripcion { 
            get {
                return m_paisDataEntity.Descripcion;
            }
            set {
                m_paisDataEntity.Descripcion = value;
            }
        }

        public PaisDataEntity PaisDataEntity {
            get { return m_paisDataEntity; } 
        }
        #endregion

        #region Constructores
        public PaisViewModel (PaisDataEntity paisDataEntity)
        {
            m_paisDataEntity = paisDataEntity;
        }
        #endregion
    }
}
