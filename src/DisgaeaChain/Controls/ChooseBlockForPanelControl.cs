using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisgaeaChain
{
  public partial class ChooseBlockForPanelControl : UserControl
  {
    public event GeoColorChangedEventHandler BlockChanged;

    public int Index { get; set; }
    public GeoColor Target { get; private set; }

    public GeoColor SelectedColor
    {
      get { return (cboColors.SelectedItem as GeoColorItem).Color; }
    }

    public ChooseBlockForPanelControl()
    {
      InitializeComponent();
    }

    public void Setup(GeoColor color, IEnumerable<GeoColor> available)
    {
      cboColors.SelectedIndexChanged -= cboColors_SelectedIndexChanged;
      Target = color;
      cboColors.Items.Clear();
      lblInstructions.Text = $"block goes on {color}";
      cboColors.Items.AddRange(available.Select(CreateItem).ToArray());
      cboColors.SelectedIndexChanged += cboColors_SelectedIndexChanged;
    }

    private object CreateItem(GeoColor color)
    {
      var item = new GeoColorItem(color);
      item.Image = GeoData.GenerateImage(color);
      return item;
    }

    private void cboColors_SelectedIndexChanged(object sender, EventArgs e)
    {
      BlockChanged?.Invoke(this, new GeoColorChangedEventArgs(SelectedColor));
    }

    private void cboColors_DrawItem(object sender, DrawItemEventArgs e)
    {
      if ((uint)e.Index < (uint)cboColors.Items.Count)
      {
        e.DrawBackground();
        e.DrawFocusRectangle();

        var item = cboColors.Items[e.Index] as GeoColorItem;
        e.Graphics.DrawImage(item.Image, e.Bounds.Left, e.Bounds.Top);

        using (var brush = new SolidBrush(e.ForeColor))
        {
          e.Graphics.DrawString($"{item.Color}", e.Font, brush, e.Bounds.Left + item.Image.Width, e.Bounds.Top + 2);
        }
      }
    }
  }
}
