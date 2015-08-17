using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Canvas_Window_Template.Drawables;
using System.Drawing;
using Canvas_Window_Template.Drawables.Shapes;
using Canvas_Window_Template.Interfaces;

namespace GridMaps
{
    public class GridPointMap:TileMap
    {
        List<OpenGLTile> walls = new List<OpenGLTile>(); 
        public GridPointMap(GridPoint origin, List<GridPoint> points,int tileSize,Color color=default(Color))
            :base(origin,points.ToList<IPoint>(),tileSize,color)
        {
            CreateWalls(points,tileSize);
        }

        private void CreateWalls(List<GridPoint> points,int tileSize)
        {
            foreach (GridPoint gridPoint in points)
            {
                if (gridPoint.HasHorizontalWall)
                {
                    walls.Add(new HorizontalWall(gridPoint,tileSize));
                }
                if (gridPoint.HasVerticalWall)
                {
                    walls.Add(new VerticalWall(gridPoint,tileSize));
                }
            }
        }

        public override void draw()
        {
            base.draw();
            foreach (OpenGLTile wall in walls)
            {
                wall.draw();
            }
        }
    }
}
