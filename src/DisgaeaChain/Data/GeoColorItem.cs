using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisgaeaChain
{
  public class GeoColorItem
  {
    public GeoColorItem(GeoColor color)
    {
      Color = color;
    }

    public GeoColor Color { get; }
    public Image Image { get; set; }

    public override string ToString()
    {
      return $"{Color}";
    }
  }
}
