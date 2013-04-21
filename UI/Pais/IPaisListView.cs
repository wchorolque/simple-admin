using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViewModel;

namespace UI.Pais
{
    interface IPaisListView
    {
        void ShowPaises(IEnumerable<PaisViewModel> paisViewModelList);
    }
}
