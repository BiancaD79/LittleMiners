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
            handler.FillEllipse(Brushes.Green, absoluteLocation.X - size, absoluteLocation.Y - size, 2*size + 1, 2*size +1);
            handler.DrawEllipse(Pens.Black, absoluteLocation.X - size, absoluteLocation.Y - size, 2*size +1, 2*size +1);
        }
    }
}
