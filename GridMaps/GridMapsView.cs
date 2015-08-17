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
        private GridPath Path;
        public static int tileSize = 20;
        public IGridPointListProvider GridPointListGenerator=new GridPointListFactory(tileSize,10,10,false); 
        public IGridPathProvider GridPathProvider=new GridPathFactory(tileSize,1);

        public GridMapsView()
        {
            InitializeComponent();           
        }

        public void CreateMap()
        {
            List<GridPoint> gridPoints = GridPointListGenerator.getGridPoints();
            Map = new GridPointMap(gridPoints[0], gridPoints,tileSize, Color.Chartreuse);
        }

        private void CreatePath()
        {
            Path = GridPathProvider.getGridPath();
        }

        public new void drawingLoop()
        {
            OpenGLDrawer myDrawer = new OpenGLDrawer();
            MyView.setCameraView(simpleOpenGlView.VIEWS.Iso);

            while (!MyView.isDisposed() && !this.IsDisposed)
            {
                MyView.setupScene();
                //DRAW SCENE HERE
                myDrawer.drawWorld(MyWorld);
                //END DRAW SCENE HERE
                MyView.flushScene();
                ((Control) this).Refresh();
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        public void Start()
        {
            this.Show();
            CreateMap();
            CreatePath();
            Refresh();
            drawingLoop();
        }

        public override void Refresh()
        {
            MyWorld.RemoveAll();
            MyWorld.add(Map);
            MyWorld.add(Path);
        }

        private void frontButton_Click(object sender, EventArgs e)
        {
            MyView.setCameraView(simpleOpenGlView.VIEWS.Front);
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            MyView.setCameraView(simpleOpenGlView.VIEWS.Top);
        }

        private void btnIsoFront_Click(object sender, EventArgs e)
        {
            MyView.setCameraView(simpleOpenGlView.VIEWS.FrontUp);
        }

        private void btnIso_Click(object sender, EventArgs e)
        {
            MyView.setCameraView(simpleOpenGlView.VIEWS.Iso);
        }

        private void btnGetNewMap_Click(object sender, EventArgs e)
        {
            CreateMap();
            Refresh();
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            Path.Advance();
            Refresh();
        }
    }
}
