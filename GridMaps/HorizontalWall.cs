using System.Drawing;
using Canvas_Window_Template.Basic_Drawing_Functions;
using Canvas_Window_Template.Drawables.Shapes;

namespace GridMaps
{
    public class HorizontalWall:OpenGLTile
    {
        public static Color color = Color.Red,
            outlineColor = Color.Black;
        public HorizontalWall(GridPoint point,int tileSize)
            :base(point,new OpenGLPoint(){X=point.X+tileSize,Y=point.Y, Z = point.Z + tileSize},color,outlineColor)
        {

        }
    }
}