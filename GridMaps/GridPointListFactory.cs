using System;
using System.Collections.Generic;

namespace GridMaps
{
    public class GridPointListFactory:IGridPointListProvider
    {
        private int tileSize;
        private int width;
        private int length;
        private bool randomWalls;

        public GridPointListFactory(int tileSize,int width,int length,bool randomWalls)
        {
            this.tileSize = tileSize;
            this.width = width;
            this.length = length;
            this.randomWalls = randomWalls;
        }

        public List<GridPoint> getGridPoints()
        {
            List<GridPoint> points = new List<GridPoint>();
            bool hasVertical = false, hasHorizontal = false;
            Random r=new Random();
            int halfWayLength = length*tileSize/2;
            int halfWayWidth = width*tileSize/2;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (randomWalls)
                    {
                        hasVertical = r.Next(2) == 1;
                        hasHorizontal = r.Next(2) == 1;
                    }
                    points.Add(new GridPoint(){X=i*tileSize-halfWayLength,Y=j*tileSize-halfWayWidth,
                        HasHorizontalWall = hasHorizontal,HasVerticalWall = hasVertical});
                }
            }
            return points;
        }
    }
}