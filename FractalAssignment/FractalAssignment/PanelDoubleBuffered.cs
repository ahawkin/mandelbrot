﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalAssignment
{
    public class PanelDoubleBuffered : System.Windows.Forms.Panel
    {
        public PanelDoubleBuffered()
        {
            this.DoubleBuffered = true;
        }
    }
}
