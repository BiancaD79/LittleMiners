using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleMiners
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Robot t = new Explorer();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.g = new MyGraphics();
            Engine.g.InitGraph(pictureBox1);
            Engine.map = new Map(20,30);
            Engine.InitTest();
            Engine.map.Draw(Engine.g.grp);
            Engine.g.RefreshGraph();
        }

        /*for (float t = 0; t <= (float)Math.PI/2 ; t+=0.01f)
            {
                PointF[] points = Engine.RegulatedPolygon(new PointF(pictureBox1.Width / 2, pictureBox1.Height / 2), 150, 4, t);
                g.grp.DrawPolygon(Pens.Black, points);
            }*/
    }
}
