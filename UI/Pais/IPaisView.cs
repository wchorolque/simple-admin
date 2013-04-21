using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Pais
{
    interface IPaisView
    {
        // TODO: cambiar object por PaisViewModel
        void ShowPais(object paisViewModel);
        void ReadUserInput();
        void ShowError(string message);
        void Close();
    }
}
