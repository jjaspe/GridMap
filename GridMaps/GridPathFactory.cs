using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridMaps
{
    public class GridPathFactory:IGridPathProvider
    {
        private int steps;
        private int tileSize;
        private List<GridPoint> gridPoints;

        public GridPathFactory(int tileSize,int steps=1)
        {
            this.steps = steps;
            this.tileSize = tileSize;
        }

        public GridPathFactory(List<GridPoint> gridPoints)
        {
            this.gridPoints = gridPoints;
        }

        public GridPath getGridPath()
        {
            if (gridPoints == null)
            {
                gridPoints = new List<GridPoint>();
                gridPoints.Add(new GridPoint() { X = 0, Y = 0 });
                gridPoints.Add(new GridPoint() { X = tileSize, Y = 0 });
            }
            
            return new GridPath(gridPoints,tileSize);
        }
    }
}
