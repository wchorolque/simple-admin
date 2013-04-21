using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PaisDataEntity
    {
        #region Propiedades
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        #endregion

        #region Constructores
        public PaisDataEntity()
        {
            Codigo = String.Empty;
            Descripcion = String.Empty;
        }

        public PaisDataEntity(string codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
        #endregion
    }
}
