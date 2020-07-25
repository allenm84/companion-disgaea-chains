namespace DisgaeaChain
{
  partial class MainForm
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
      this.radLabel1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.pnlMissingColor = new System.Windows.Forms.Panel();
      this.btnChoose = new System.Windows.Forms.Button();
      this.radLabel2 = new System.Windows.Forms.Label();
      this.radPanel1 = new System.Windows.Forms.Panel();
      this.pnlSelections = new System.Windows.Forms.FlowLayoutPanel();
      this.lblDestoryReminder = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.radPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.radLabel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.radLabel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.radPanel1, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 304);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // radLabel1
      // 
      this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.radLabel1.AutoSize = true;
      this.radLabel1.Location = new System.Drawing.Point(3, 3);
      this.radLabel1.Name = "radLabel1";
      this.radLabel1.Size = new System.Drawing.Size(144, 13);
      this.radLabel1.TabIndex = 0;
      this.radLabel1.Text = "Choose Panels and Blocks:";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.pnlMissingColor, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnChoose, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 20);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(259, 30);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // pnlMissingColor
      // 
      this.pnlMissingColor.BackColor = System.Drawing.Color.White;
      this.pnlMissingColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnlMissingColor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMissingColor.Location = new System.Drawing.Point(3, 3);
      this.pnlMissingColor.Name = "pnlMissingColor";
      this.pnlMissingColor.Size = new System.Drawing.Size(173, 24);
      this.pnlMissingColor.TabIndex = 0;
      this.pnlMissingColor.Text = "No Color Yet";
      // 
      // btnChoose
      // 
      this.btnChoose.Location = new System.Drawing.Point(182, 3);
      this.btnChoose.Name = "btnChoose";
      this.btnChoose.Size = new System.Drawing.Size(74, 24);
      this.btnChoose.TabIndex = 1;
      this.btnChoose.Text = "Choose . . .";
      this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
      // 
      // radLabel2
      // 
      this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.radLabel2.AutoSize = true;
      this.radLabel2.Location = new System.Drawing.Point(3, 53);
      this.radLabel2.Name = "radLabel2";
      this.radLabel2.Size = new System.Drawing.Size(93, 13);
      this.radLabel2.TabIndex = 2;
      this.radLabel2.Text = "Make Selections:";
      // 
      // radPanel1
      // 
      this.radPanel1.BackColor = System.Drawing.SystemColors.Window;
      this.radPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.radPanel1.Controls.Add(this.pnlSelections);
      this.radPanel1.Controls.Add(this.lblDestoryReminder);
      this.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.radPanel1.Location = new System.Drawing.Point(3, 73);
      this.radPanel1.Name = "radPanel1";
      this.radPanel1.Padding = new System.Windows.Forms.Padding(1);
      this.radPanel1.Size = new System.Drawing.Size(253, 228);
      this.radPanel1.TabIndex = 3;
      // 
      // pnlSelections
      // 
      this.pnlSelections.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlSelections.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.pnlSelections.Location = new System.Drawing.Point(1, 1);
      this.pnlSelections.Name = "pnlSelections";
      this.pnlSelections.Size = new System.Drawing.Size(249, 191);
      this.pnlSelections.TabIndex = 0;
      this.pnlSelections.WrapContents = false;
      // 
      // lblDestoryReminder
      // 
      this.lblDestoryReminder.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblDestoryReminder.Location = new System.Drawing.Point(1, 192);
      this.lblDestoryReminder.Name = "lblDestoryReminder";
      this.lblDestoryReminder.Size = new System.Drawing.Size(249, 33);
      this.lblDestoryReminder.TabIndex = 1;
      this.lblDestoryReminder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblDestoryReminder.Visible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(279, 324);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Disgaea Chain";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.radPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label radLabel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Panel pnlMissingColor;
    private System.Windows.Forms.Button btnChoose;
    private System.Windows.Forms.Label radLabel2;
    private System.Windows.Forms.FlowLayoutPanel pnlSelections;
    private System.Windows.Forms.Panel radPanel1;
    private System.Windows.Forms.Label lblDestoryReminder;
  }
}