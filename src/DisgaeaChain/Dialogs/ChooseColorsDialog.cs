using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisgaeaChain
{
  public partial class ChooseColorsDialog : BaseForm
  {
    public IEnumerable<GeoColor> Blocks { get { return colorBlocks.SelectedColors; } }
    public IEnumerable<GeoColor> Panels { get { return colorPanels.SelectedColors; } }

    public ChooseColorsDialog()
    {
      InitializeComponent();
      InitializeSelectors();
    }

    private void InitializeSelectors()
    {
      colorBlocks.Fill(GeoColor.Aqua);
      colorPanels.Fill(GeoColor.Null);
    }
  }
}
