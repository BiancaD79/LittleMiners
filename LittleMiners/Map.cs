using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace LittleMiners
{
    public class Map
    {
        Tile[,] tiles;
        public Map(int n, int m)
        {
            tiles = new Tile[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tiles[i, j] = new Tile(0, new PointF(i, j));
                }
            }
        }

        public void Draw(Graphics handler)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i,j].Draw(handler);
                }
            }
        }
    }
}
