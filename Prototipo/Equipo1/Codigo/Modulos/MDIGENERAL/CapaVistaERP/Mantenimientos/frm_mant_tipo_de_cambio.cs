﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frm_mant_tipo_de_cambio : Form
    {
        public frm_mant_tipo_de_cambio()
        {
            InitializeComponent();
            this.navegador1.config("tbl_tipocambio", this, "");
        }

        private void txt_estado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
