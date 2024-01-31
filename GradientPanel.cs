﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CEM_Event_Managment_System
{
    class GradientPanel : Panel
    {
        public Color ColorLeft { get; set; }
        public Color ColorRight { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, this.ColorLeft, this.ColorRight, 180F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);

            base.OnPaint(e);
        }
    }
}
