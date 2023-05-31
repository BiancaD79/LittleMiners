using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace LittleMiners
{
    public abstract class Robot
    {
        public PointF mapLocation;
        public PointF absoluteLocation;
        public Robot()
        {

        }

        public void SetOnMap(PointF toSet)
        {
            mapLocation = toSet;
            absoluteLocation = new PointF(toSet.X * Tile.dx, toSet.Y * Tile.dy);
        }

        public abstract void Draw(Graphics handler);
        
    }
}
