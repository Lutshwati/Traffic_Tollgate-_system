﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traffic_Tollgate__system.UserInterface;
using System.Windows.Forms;

namespace Traffic_Tollgate__system
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
            Application.Run(new SignUp());
        }
    }
}
