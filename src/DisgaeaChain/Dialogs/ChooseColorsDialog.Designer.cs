namespace DisgaeaChain
{
  partial class ChooseColorsDialog
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.radGroupBox1 = new System.Windows.Forms.GroupBox();
      this.colorPanels = new DisgaeaChain.GeoColorSelectControl();
      this.radGroupBox2 = new System.Windows.Forms.GroupBox();
      this.colorBlocks = new DisgaeaChain.GeoColorSelectControl();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.radGroupBox1.SuspendLayout();
      this.radGroupBox2.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.radGroupBox1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.radGroupBox2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(436, 272);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // radGroupBox1
      // 
      this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox1.Controls.Add(this.colorPanels);
      this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
      this.radGroupBox1.Name = "radGroupBox1";
      this.radGroupBox1.Size = new System.Drawing.Size(212, 236);
      this.radGroupBox1.TabIndex = 0;
      this.radGroupBox1.Text = "Panels";
      // 
      // colorPanels
      // 
      this.colorPanels.Dock = System.Windows.Forms.DockStyle.Fill;
      this.colorPanels.Location = new System.Drawing.Point(2, 18);
      this.colorPanels.Name = "colorPanels";
      this.colorPanels.Size = new System.Drawing.Size(208, 216);
      this.colorPanels.TabIndex = 0;
      // 
      // radGroupBox2
      // 
      this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
      this.radGroupBox2.Controls.Add(this.colorBlocks);
      this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radGroupBox2.Location = new System.Drawing.Point(221, 3);
      this.radGroupBox2.Name = "radGroupBox2";
      this.radGroupBox2.Size = new System.Drawing.Size(212, 236);
      this.radGroupBox2.TabIndex = 1;
      this.radGroupBox2.Text = "Blocks";
      // 
      // colorBlocks
      // 
      this.colorBlocks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.colorBlocks.Location = new System.Drawing.Point(2, 18);
      this.colorBlocks.Name = "colorBlocks";
      this.colorBlocks.Size = new System.Drawing.Size(208, 216);
      this.colorBlocks.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 242);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(436, 30);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(279, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 24);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(359, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      // 
      // ChooseColorsDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(436, 272);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ChooseColorsDialog";
      this.Text = "Choose Colors";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.radGroupBox1.ResumeLayout(false);
      this.radGroupBox2.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox radGroupBox1;
    private System.Windows.Forms.GroupBox radGroupBox2;
    private GeoColorSelectControl colorPanels;
    private GeoColorSelectControl colorBlocks;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}

