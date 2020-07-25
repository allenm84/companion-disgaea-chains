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
  public partial class GeoColorSelectControl : UserControl
  {
    public GeoColorSelectControl()
    {
      InitializeComponent();
    }

    public IEnumerable<GeoColor> SelectedColors
    {
      get
      {
        for (int r = 0; r < gridColors.Rows.Count; ++r)
        {
          var row = gridColors.Rows[r];
          if (row.Cells[clmnChecked.Name].Value.Equals(true))
          {
            yield return (GeoColor)row.Cells[clmnName.Name].Value;
          }
        }
      }
    }

    public void Fill(params GeoColor[] except)
    {
      foreach (var color in GeoData.Colors.Except(except))
      {
        gridColors.Rows.Add(false, GeoData.GenerateImage(color), color);
      }
    }

    private void SetAllItemsTo(bool isChecked)
    {
      for (int r = 0; r < gridColors.Rows.Count; ++r)
      {
        gridColors[clmnChecked.Name, r].Value = isChecked;
      }
    }

    public void ResetItems()
    {
      SetAllItemsTo(false);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      if (DesignMode)
      {
        Fill();
      }
    }

    private void btnSelectAll_Click(object sender, EventArgs e)
    {
      SetAllItemsTo(true);
    }

    private void btnSelectNone_Click(object sender, EventArgs e)
    {
      ResetItems();
    }
  }
}
