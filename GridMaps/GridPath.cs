using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using Canvas_Window_Template.Basic_Drawing_Functions;
using Canvas_Window_Template.Drawables.Shapes;
using Canvas_Window_Template.Interfaces;

namespace GridMaps
{
    public class GridPath:IDrawable
    {
        public static Color markerColor = Color.Blue, coveredTileColor = Color.Green, remainingTileColor = Color.White,
            OutlineColor=Color.Black;
        private OpenGLRombus Marker;
        private double RombusHeight = 0.5;
        Stack<OpenGLTile> CoveredTiles = new Stack<OpenGLTile>(),
            RemainingTiles = new Stack<OpenGLTile>();

        public GridPath(List<GridPoint> pathPoints,int tileSize)
        {
            foreach (GridPoint point in pathPoints)
            {
                RemainingTiles.Push(new OpenGLTile(point,new GridPoint(){X=point.X+tileSize,Y=point.Y+tileSize},
                    remainingTileColor,OutlineColor));
            }
            OpenGLTile markerTile = RemainingTiles.Peek();
            IPoint origin=new OpenGLPoint(markerTile.MyOrigin.X,markerTile.MyOrigin.Y,RombusHeight),
                end=new OpenGLPoint(markerTile.MyEnd.X,markerTile.MyEnd.Y,RombusHeight);
            Marker = new OpenGLRombus(origin,end,OpenGLDrawer.colorToArray(markerColor),OpenGLDrawer.colorToArray(OutlineColor));
        }

        public void Advance(int steps = 1)
        {
            for (int i = 0; i < steps; i++)
            {
                if (RemainingTiles.Count > 0)
                {
                    OpenGLTile currentTile = RemainingTiles.Pop();
                    currentTile.MyColor = OpenGLDrawer.colorToArray(coveredTileColor);
                    CoveredTiles.Push(currentTile);
                    Marker.setPosition(currentTile.MyOrigin);
                }
            }
        }

        public void draw()
        {
            Marker.draw();
            foreach (OpenGLTile tile in RemainingTiles)
            {
                tile.draw();
            }
            foreach (OpenGLTile tile in CoveredTiles)
            {
                tile.draw();
            }
        }

        public int getId()
        {
            return 0;
        }

        public double[] getPosition()
        {
            return Marker.getPosition();
        }

        public void setPosition(IPoint newPosition)
        {
            throw new NotImplementedException();
        }

        public bool Visible { get; set; }
    }
}
