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
        public Robot()
        {

        }

        public void SetOnMap(PointF toSet)
        {
            mapLocation = toSet;
        }

        public abstract void Draw(Graphics handler);
        
    }
}
