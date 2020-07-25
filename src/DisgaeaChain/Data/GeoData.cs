using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class GeoData
{
  static Dictionary<GeoColor, Color> colors;

  static GeoData()
  {
    colors = new Dictionary<GeoColor, Color>();
    colors[GeoColor.Red] = Color.Red;
    colors[GeoColor.Green] = Color.LimeGreen;
    colors[GeoColor.Blue] = Color.Blue;
    colors[GeoColor.Yellow] = Color.Yellow;
    colors[GeoColor.Purple] = ControlPaint.Dark(Color.Violet, .01f);
    colors[GeoColor.Aqua] = Color.Cyan;
    colors[GeoColor.Null] = Color.GhostWhite;
  }

  public static IEnumerable<GeoColor> Colors
  {
    get
    {
      return colors.Keys;
    }
  }

  public static Image GenerateImage(GeoColor color)
  {
    return GenerateImage(GetColor(color));
  }

  public static Image GenerateImage(Color color)
  {
    Bitmap bitmap = new Bitmap(14, 14);
    using (var gra = Graphics.FromImage(bitmap))
    {
      gra.Clear(color);
      gra.DrawRectangle(Pens.Black, 0, 0, 13, 13);
    }
    return bitmap;
  }

  public static Color GetColor(GeoColor color)
  {
    return colors[color];
  }
}
