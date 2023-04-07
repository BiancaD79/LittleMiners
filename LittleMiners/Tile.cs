using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LittleMiners
{
    public class Tile
    {
        int crystal;
        int processedCrystal;
        int fog;
        public PointF mapLocation;
        public Tile(int crystal, PointF mapLocation)
        {
            this.crystal = crystal;
            this.mapLocation = mapLocation;
            processedCrystal = 0;
            fog = 0;
        }

        public void Draw(Graphics handler)
        {
            int dx = 20;
            int dy = 20;
            handler.FillRectangle(Brushes.Gray, mapLocation.X * dx, mapLocation.Y * dy, dx, dy);
            handler.DrawRectangle(Pens.Black, mapLocation.X * dx, mapLocation.Y * dy, dx, dy);
        }
    }
}
