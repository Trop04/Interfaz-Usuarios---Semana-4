﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Mi_Primera_Vez.Presentacion
{
    public partial class CUPaneUsuario : UserControl
    {
        public CUPaneUsuario()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            frmAñadirUsuario frmUsuario = new frmAñadirUsuario();
            frmUsuario.ShowDialog();
        }
    }
}
