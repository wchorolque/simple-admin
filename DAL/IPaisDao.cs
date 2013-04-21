using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    interface IPaisDao
    {
        PaisDataEntity crearPaisDataEntity();
        IEnumerable<PaisDataEntity> GetPaises();
        void Save(PaisDataEntity pais);
        PaisDataEntity GetByDescripcion(string nombre_pais);
    }
}
