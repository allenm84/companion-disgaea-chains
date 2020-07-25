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
  public partial class MainForm : BaseForm
  {
    private List<ChooseBlockForPanelControl> links;
    private GeoColor[] blocks;
    private GeoColor[] panels;

    public MainForm()
    {
      InitializeComponent();
      links = new List<ChooseBlockForPanelControl>(8);
    }

    private void Cleanup()
    {
      pnlSelections.SuspendLayout();
      pnlSelections.Controls.Clear();
      pnlSelections.ResumeLayout(true);

      foreach (var c in links)
      {
        c.Dispose();
      }
      links.Clear();
    }

    private void AddSelector(GeoColor color, IEnumerable<GeoColor> availableBlocks)
    {
      pnlSelections.SuspendLayout();
      
      var selector = new ChooseBlockForPanelControl();
      selector.Index = links.Count;
      selector.Setup(color, availableBlocks);
      selector.Location = new Point(0, 0);
      selector.BlockChanged += selector_ColorChanged;
      links.Add(selector);

      pnlSelections.Controls.Add(selector);
      pnlSelections.ResumeLayout(true);
    }

    private IEnumerable<GeoColor> GetSelectedBlocks(int stop)
    {
      for (int i = 0; i < stop; ++i)
      {
        yield return links[i].SelectedColor;
      }
    }

    private GeoColor GetNextColor(int me)
    {
      int parent = me - 1;
      if (parent < 0)
      {
        // I don't have a parent, so just use me
        return links[me].Target;
      }

      return links[parent].SelectedColor;
    }

    private void selector_ColorChanged(object sender, GeoColorChangedEventArgs e)
    {
      // retrieve the selector which triggered the change
      var selector = sender as ChooseBlockForPanelControl;

      // retrieve the block colors which are still available
      var available = blocks
        .Except(GetSelectedBlocks(selector.Index))
        .Minus(e.Color)
        .ToArray();

      // don't allow the user to choose null
      if (e.Color == GeoColor.Null && available.Length > 0)
      {
       MessageBox.Show(this, "Null should be the last block that is chosen", "Invalid", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // if there are no available colors, then do nothing
      if (available.Length == 0)
      {
        lblDestoryReminder.Visible = true;
        lblDestoryReminder.Text = $"Destory the {links[0].SelectedColor} block";
        return;
      }
      else
      {
        lblDestoryReminder.Visible = false;
      }

      // we need to determine what the NEXT selector target color
      // should be
      var nextTarget = GetNextColor(selector.Index);

      // "calculate" the index of my child
      var childIndex = selector.Index + 1;

      // now, we need to disable all of the selections after me (if there are any)
      for (int i = childIndex; i < links.Count; ++i)
      {
        links[i].Enabled = false;
      }

      // if our child exists, make sure it is enabled
      if (childIndex < links.Count)
      {
        var child = links[childIndex];
        child.Enabled = true;
        child.Setup(nextTarget, available);
      }
      else
      {
        // our child doesn't exist, so lets create it
        AddSelector(nextTarget, available);
      }
    }

    private void btnChoose_Click(object sender, EventArgs e)
    {
      using (var dlg = new ChooseColorsDialog())
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          // retrieve the data
          blocks = dlg.Blocks.ToArray();
          panels = dlg.Panels.ToArray();

          // get the missing color
          var missingArr = panels.Except(blocks).ToArray();
          if (missingArr.Length != 1)
          {
            var message = string.Format("The missing colors are:{0}{0}{1}{0}{0}There should be only one missing color.", 
              Environment.NewLine, 
              string.Join(Environment.NewLine, missingArr));

            MessageBox.Show(this, message, "Invalid", 
              MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
          }

          // set the missing color
          var startPanel = missingArr[0];
          pnlMissingColor.Text = startPanel.ToString();
          pnlMissingColor.BackColor = GeoData.GetColor(startPanel);

          // cleanup the last session
          Cleanup();

          // add a control for choosing which block goes on the missing panel
          AddSelector(startPanel, blocks);
        }
      }
    }
  }
}
