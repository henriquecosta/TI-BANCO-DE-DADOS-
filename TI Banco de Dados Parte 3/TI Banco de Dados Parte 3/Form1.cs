﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TI_Banco_de_Dados_Parte_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedico(object sender, EventArgs e)
        {
            MedicoCadastro medico = new MedicoCadastro();
            medico.Show();
        }
    }
}
