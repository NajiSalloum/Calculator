using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Calculator
{
    class MyButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, Width-1, Height -1);
            this.Region = new Region(gp);
          
        }

    }
}
