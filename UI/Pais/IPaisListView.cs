using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.Pais
{
    interface IPaisListView
    {
        // TODO: Declarar PaisViewModel y cambiarlo por object
        void ShowPaises(IEnumerable<object> paisViewModelList);

    }
}
