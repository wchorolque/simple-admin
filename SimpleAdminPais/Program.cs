﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleAdminPais
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAL.PaisDao dao = new DAL.PaisDao();
            UI.Pais.FrmPaisList view = new UI.Pais.FrmPaisList(dao);
            Application.Run(view);
        }
    }
}
