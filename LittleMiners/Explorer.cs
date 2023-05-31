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
            handler.FillEllipse(Brushes.Blue, absoluteLocation.X - size, absoluteLocation.Y - size, 2*size +1, 2*size +1);
            handler.FillEllipse(Brushes.Yellow, absoluteLocation.X - size, absoluteLocation.Y - size, size / 2, size / 2);
            handler.DrawEllipse(Pens.Black, absoluteLocation.X - size, absoluteLocation.Y - size, 2*size +1, 2*size +1);
        }
    }
}
