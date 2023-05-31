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
        float crystal;
        int processedCrystal;
        int fog;
        public PointF mapLocation;
        public PointF absoluteLocation;
        public static int dx = 20, dy = 20;
        public Robot robot;
        public Tile(int crystal, PointF mapLocation)
        {
            this.crystal = crystal;
            this.mapLocation = mapLocation;
            processedCrystal = 0;
            fog = 0;
            absoluteLocation = new PointF(mapLocation.X * dx, mapLocation.Y * dy);
        }
        public void AddCrystal(float value)
        {
            crystal += value;
        }
        public void Draw(Graphics handler)
        {
            int dx = 20;
            int dy = 20;
            handler.FillRectangle(Brushes.Gray, absoluteLocation.X, absoluteLocation.Y, dx, dy);
            handler.DrawRectangle(Pens.Black, absoluteLocation.X, absoluteLocation.Y , dx, dy);
            if (robot != null)
                robot.Draw(handler);
            if(crystal != 0)
            {
                PointF[] points = Engine.RegulatedPolygon(new PointF(this.absoluteLocation.X + dx / 2, this.absoluteLocation.Y + dy / 2), dx / 2, dy / 2, 6, 0);
                handler.DrawPolygon(Pens.Blue, points);
                handler.DrawString(crystal.ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, absoluteLocation);
            }
        }
        public void SetRobot(Robot toSet)
        {
            this.robot = toSet;
            this.robot.mapLocation = this.mapLocation;
            float X = this.absoluteLocation.X + dx/2;
            float Y = this.absoluteLocation.Y + dy/2;
            this.robot.absoluteLocation = new PointF(X,Y);
        }
    }
}
