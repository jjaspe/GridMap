using Canvas_Window_Template;
using Canvas_Window_Template.Basic_Drawing_Functions;
using Canvas_Window_Template.Drawables;
using Canvas_Window_Template.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GridMaps
{
    public partial class GridMapsView : ReadyOpenGlTemplate
    {
        TileMap Map;
        int tileSize = 20;
        List<LowWall> lowWalls = new List<LowWall>();

        public GridMapsView()
        {
            InitializeComponent();           
        }

        public void CreateMap(List<GridPoint> gridPoints,int horizontalSize,int verticalSize)
        {
            Map = new TileMap(gridPoints[0], horizontalSize, verticalSize, Common.planeOrientation.Z, tileSize, Common.colorGreen,
                Common.colorBlack);
            foreach(GridPoint point in gridPoints)
            {
                if(point.HasHorizontalWall)
                {
                    MyWorld.add(new HorizontalWall(point));
                }
                if(point.HasVerticalWall)
                {
                    MyWorld.add(new VerticalWall(point));
                }
            }
        }

        public new void drawingLoop()
        {
            Common myDrawer = new Common();
            MyWorld.add(Map);
            MyView.setCameraView(simpleOpenGlView.VIEWS.Iso);

            while (!MyView.isDisposed() && !this.IsDisposed)
            {
                MyView.setupScene();
                //DRAW SCENE HERE
                myDrawer.drawWorld(MyWorld);
                //END DRAW SCENE HERE
                MyView.flushScene();
                this.Refresh();
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        public void Start()
        {
            this.Show();
            CreateMap(new List<GridPoint>() { new GridPoint() { X = 0, Y = 0, HasHorizontalWall = true, HasVerticalWall = true } }
               , 10, 10);
            drawingLoop();
        }
    }

    public class HorizontalWall:Tile
    {
        public static int tileSize = 20;
        public HorizontalWall(GridPoint point)
            :base(point,new GridPoint(){X=point.X+tileSize,Y=point.Y})
        {

        }
    }

    public class VerticalWall:Tile
    {
        public static int tileSize = 20;
        public VerticalWall(GridPoint point)
            :base(point,new GridPoint(){X=point.X,Y=point.Y+tileSize})
        {

        }
    }

    public class GridPoint:IPoint
    {
        public bool HasHorizontalWall { get; set; }
        public bool HasVerticalWall { get; set; }

        public double X
        {
            get;
            set;
        }

        public double Y
        {
            get;
            set;
        }

        public IPoint copy()
        {
            return new GridPoint() { X = this.X, Y = this.Y,
                HasHorizontalWall = this.HasHorizontalWall, HasVerticalWall = this.HasVerticalWall };
        }

        public bool equals(double[] p)
        {
            throw new NotImplementedException();
        }

        public bool equals(IPoint p)
        {
            throw new NotImplementedException();
        }

        public double[] toArray()
        {
            throw new NotImplementedException();
        }


        double IPoint.Z
        {
            get
            {
                return 0;
            }
            set
            {
                return;
            }
        }
    }
}
