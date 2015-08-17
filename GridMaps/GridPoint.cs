using System;
using Canvas_Window_Template.Interfaces;

namespace GridMaps
{
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

        public double Z
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
    }
}