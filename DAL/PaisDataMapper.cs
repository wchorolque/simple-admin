using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Datasets;
using DAL.Datasets.PaisDataSetTableAdapters;

namespace DAL
{
    public class PaisDataMapper
    {
        #region Atributos
        private PaisDataSet m_paisDataSet;
        #endregion

        #region Propiedades
        public string ConnectionString { get; private set; }
        #endregion

        #region Constructores
        public PaisDataMapper()
        {
            m_paisDataSet = new PaisDataSet();
            ConnectionStringSettingsCollection connections = null;
            connections = ConfigurationManager.ConnectionStrings;
            ConnectionString = connections["DAL.Properties.Settings.DefaultConnection"].ConnectionString;
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
                if (0 == rows)
                {
                    throw new Exception("No Se pudo Insertar el Registro");
                }

            } catch(SqlException ex) 
            {
                throw ex;
            } catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
