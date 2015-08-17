using Canvas_Window_Template.Drawables.Shapes;
using System.Drawing;
using Canvas_Window_Template.Basic_Drawing_Functions;

namespace GridMaps
{
    public class VerticalWall : OpenGLTile
    {
        public static Color color = Color.DarkBlue,
            outlineColor = Color.Black;
        public VerticalWall(GridPoint point,int tileSize)
            : base(point, new OpenGLPoint() { X = point.X, Y = point.Y + tileSize, Z = point.Z + tileSize },color,outlineColor)
        {

        }
    }
}