using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Configuration;

namespace DAL
{
    public class PaisDao : IPaisDao
    {
        #region Atributos
        private PaisDataMapper m_dataMapper;
        private List<PaisDataEntity> m_paisesList;
        #endregion

        #region Constructores
        public PaisDao()
        {
            m_dataMapper = new PaisDataMapper();
            m_paisesList = m_dataMapper.GetPaises();
        }
        #endregion

        #region Implentacion IPaisDao
        public PaisDataEntity crearPaisDataEntity()
        {
            return new PaisDataEntity();
        }

        public IEnumerable<PaisDataEntity> GetPaises()
        {
            return m_paisesList;
        }

        public void Save(PaisDataEntity pais)
        {
            m_dataMapper.Save(pais);
            m_paisesList.Add(pais);
        }

        public PaisDataEntity GetByDescripcion(string nombre_pais)
        {
            foreach (PaisDataEntity entidad in m_paisesList)
            {
                if (entidad.Descripcion == nombre_pais)
                {
                    return entidad;
                }
            }

            return null;
        }
        #endregion
    }
}
