﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controle_de_Perdas_Winform_3._0
    {
    static class Program
        {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            }
        }
    }
