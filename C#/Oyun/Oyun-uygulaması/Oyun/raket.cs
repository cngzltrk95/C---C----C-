﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    class raket
    {
        public void cizimAraci(Graphics e, int x)
        {
            x = x - 101;
            SolidBrush firca = new SolidBrush(Color.Yellow);
            if (x <= 5)
                x = 5;
            if (x >= 668)
                x = 668;
            e.FillRectangle(firca, x, 445, 201, 25);
        }
    }
}
