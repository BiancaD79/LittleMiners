using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleMiners
{
    public static class Engine
    {
        public static PointF[] RegulatedPolygon(PointF mapLocation, float radius, int n, float rotAngle)
        {
            float alfa = (float)(Math.PI * 2) / n;
            PointF[] toR = new PointF[n];
            for (int i = 0; i < n; i++)
            {
                float x, y;
                x = mapLocation.X + radius * (float)Math.Cos(i * alfa + rotAngle);
                y = mapLocation.Y + radius * (float)Math.Sin(i * alfa + rotAngle);
                toR[i] = new PointF(x, y);
            }
            return toR;
        }
    }
}
