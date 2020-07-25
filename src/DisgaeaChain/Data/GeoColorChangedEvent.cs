using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgaeaChain
{
  public delegate void GeoColorChangedEventHandler(object sender, GeoColorChangedEventArgs e);

  public class GeoColorChangedEventArgs : EventArgs
  {
    public GeoColor Color { get; private set; }

    public GeoColorChangedEventArgs(GeoColor color)
    {
      Color = color;
    }
  }
}
