﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace UI.Pais
{
    public interface IPaisView
    {
        void ShowPais(PaisViewModel paisViewModel);
        void ReadUserInput();
        void ShowError(string message);
        void Close();
    }
}
