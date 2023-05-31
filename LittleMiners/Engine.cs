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
        public static List<Robot> robots = new List<Robot>();
        public static Map map;
        public static MyGraphics g;
        public static Random rnd = new Random();
        public static void InitTest()
        {
            Robot t = new Explorer();
            map.SetRobot(t, 1, 2);
            Robot t1 = new Exploiter();
            map.SetRobot(t1, 3, 5);
            Robot t2 = new Exploiter();
            map.SetRobot(t2, 6, 4);
            Robot t3 = new Transporter();
            map.SetRobot(t3, 3, 2);
            Robot t4 = new Transporter();
            map.SetRobot(t4, 4, 2);

            //map.SetCrystals(new Point(7, 9), 20, 5, 1);
            map.SetCrystals(new Point(rnd.Next(map.n), rnd.Next(map.m)), 50, 5, 10);
            //map.SetCrystals(new Point(1, 3), 200, 5, 10);
        }
        public static PointF[] RegulatedPolygon(PointF mapLocation, float radiusX, float radiusY, int n, float rotAngle)
        {
            float alfa = (float)(Math.PI * 2) / n;
            PointF[] toR = new PointF[n];
            for (int i = 0; i < n; i++)
            {
                float x, y;
                x = mapLocation.X + radiusX * (float)Math.Cos(i * alfa + rotAngle);
                y = mapLocation.Y + radiusY * (float)Math.Sin(i * alfa + rotAngle);
                toR[i] = new PointF(x, y);
            }
            return toR;
        }

    }
}
