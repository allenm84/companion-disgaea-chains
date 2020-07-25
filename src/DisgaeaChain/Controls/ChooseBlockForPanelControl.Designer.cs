namespace DisgaeaChain
{
  partial class ChooseBlockForPanelControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblInstructions = new System.Windows.Forms.Label();
      this.cboColors = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
      this.tableLayoutPanel1.Controls.Add(this.lblInstructions, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.cboColors, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 27);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // lblInstructions
      // 
      this.lblInstructions.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblInstructions.AutoSize = true;
      this.lblInstructions.Location = new System.Drawing.Point(96, 7);
      this.lblInstructions.Name = "lblInstructions";
      this.lblInstructions.Size = new System.Drawing.Size(121, 13);
      this.lblInstructions.TabIndex = 0;
      this.lblInstructions.Text = "block goes on Blue Red";
      // 
      // cboColors
      // 
      this.cboColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboColors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
      this.cboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboColors.Location = new System.Drawing.Point(3, 3);
      this.cboColors.Name = "cboColors";
      this.cboColors.Size = new System.Drawing.Size(87, 21);
      this.cboColors.TabIndex = 1;
      this.cboColors.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboColors_DrawItem);
      // 
      // ChooseBlockForPanelControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ChooseBlockForPanelControl";
      this.Size = new System.Drawing.Size(223, 27);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblInstructions;
    private System.Windows.Forms.ComboBox cboColors;
  }
}
