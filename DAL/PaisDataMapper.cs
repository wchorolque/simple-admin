using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.Datasets;

namespace DAL
{
    public class PaisDataMapper
    {
        #region Propiedades
        private PaisDataSet m_paisDataSet;
        #endregion

        #region Constructores
        public PaisDataMapper()
        {
            m_paisDataSet = new PaisDataSet();
        }
        #endregion

        #region Metodos
        public List<Model.PaisDataEntity> GetPaises()
        {
            List<Model.PaisDataEntity> paisesList = new List<Model.PaisDataEntity>();
            foreach (PaisDataSet.PaisRow row in m_paisDataSet.Tables["Pais"].Rows)
            {
                Model.PaisDataEntity entidad = new Model.PaisDataEntity(row.CODIGO, row.descripcion);
                paisesList.Add(entidad);
            }

            return paisesList;
        }

        public void Save(Model.PaisDataEntity pais)
        {
            DataTable paisDataTable = m_paisDataSet.Tables["Pais"];
            PaisDataSet.PaisRow newRow = (PaisDataSet.PaisRow)paisDataTable.NewRow();
            newRow.CODIGO = pais.Codigo;
            newRow.descripcion = pais.Descripcion;
            paisDataTable.Rows.Add(newRow);
            paisDataTable.GetChanges();
            paisDataTable.AcceptChanges();
        }
        #endregion
    }
}
