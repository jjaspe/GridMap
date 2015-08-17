using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridMaps
{
    public interface IGridPointListProvider
    {
        List<GridPoint> getGridPoints();
    }
}
