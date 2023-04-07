using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LittleMiners
{
    internal class Transporter : Robot
    {
        public Transporter() : base()
        {

        }

        public override void Draw(Graphics handler)
        {
            int size = 7; 
            handler.FillEllipse(Brushes.Black, mapLocation.X - size, mapLocation.Y - size, 2*size + 1, 2*size +1);
            handler.DrawEllipse(Pens.Black, mapLocation.X - size, mapLocation.Y - size, 2*size +1, 2*size +1);
        }
    }
}
