﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Reportes
{
    public partial class VisorReportes : Form
    {
        public VisorReportes()
        {
            InitializeComponent();
        }

        public object visor { get; internal set; }
    }
}
