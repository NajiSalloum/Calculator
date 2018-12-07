using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculator
{
    class MyTextBox : TextBox
    {
        public MyTextBox()
        {
            this.BackColor = Color.Yellow;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

    
    }
}
