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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CUPersonal frmPrueba = new CUPersonal();
            PanelGeneral.Controls.Clear();
            frmPrueba.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmPrueba);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelUsuario_Click(object sender, EventArgs e)
        {
            CUPaneUsuario frmUsuarios = new CUPaneUsuario();
            PanelGeneral.Controls.Clear();
            frmUsuarios.Dock = DockStyle.Fill;
            PanelGeneral.Controls.Add(frmUsuarios);
        }
    }
}
