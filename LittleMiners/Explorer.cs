using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleMiners
{
    public class Explorer :Robot
    {
        public Explorer() : base()
        {

        }

        public override void Draw(Graphics handler)
        {
            int size = 8;
            handler.FillEllipse(Brushes.Black, mapLocation.X - size, mapLocation.Y - size, 2*size +1, 2*size +1);
            handler.FillEllipse(Brushes.Yellow, mapLocation.X - size, mapLocation.Y - size, size / 2, size / 2);
            handler.DrawEllipse(Pens.Black, mapLocation.X - size, mapLocation.Y - size, 2*size +1, 2*size +1);
        }
    }
}
