using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL.Datasets;
using DAL.Datasets.PaisDataSetTableAdapters;

namespace DAL
{
    public class PaisDataMapper
    {
        #region Atributos
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
            PaisTableAdapter paisTableAdapter = new PaisTableAdapter();
            PaisDataSet.PaisDataTable paisDataTable = new PaisDataSet.PaisDataTable();
            paisTableAdapter.Fill(paisDataTable);
            foreach (PaisDataSet.PaisRow row in paisDataTable.Rows)
            {
                Model.PaisDataEntity entidad = new Model.PaisDataEntity(row.CODIGO, row.descripcion);
                paisesList.Add(entidad);
            }

            return paisesList;
        }

        public void Save(Model.PaisDataEntity pais)
        {
            try
            {
                PaisTableAdapter paisTableAdapter = new PaisTableAdapter();
                int rows = paisTableAdapter.Insert(pais.Codigo, pais.Descripcion);
            } catch(SqlException) 
            {
                throw;
            } catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
