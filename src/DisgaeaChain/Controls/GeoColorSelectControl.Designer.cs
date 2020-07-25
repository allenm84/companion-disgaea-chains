namespace DisgaeaChain
{
  partial class GeoColorSelectControl
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.btnSelectAll = new System.Windows.Forms.Button();
      this.btnSelectNone = new System.Windows.Forms.Button();
      this.gridColors = new System.Windows.Forms.DataGridView();
      this.clmnChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.clmnColor = new System.Windows.Forms.DataGridViewImageColumn();
      this.clmnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridColors)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.Controls.Add(this.btnSelectAll, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.btnSelectNone, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.gridColors, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(193, 150);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // imageList
      // 
      this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imageList.ImageSize = new System.Drawing.Size(16, 16);
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // btnSelectAll
      // 
      this.btnSelectAll.Location = new System.Drawing.Point(3, 123);
      this.btnSelectAll.Name = "btnSelectAll";
      this.btnSelectAll.Size = new System.Drawing.Size(74, 24);
      this.btnSelectAll.TabIndex = 1;
      this.btnSelectAll.Text = "Select All";
      this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
      // 
      // btnSelectNone
      // 
      this.btnSelectNone.Location = new System.Drawing.Point(116, 123);
      this.btnSelectNone.Name = "btnSelectNone";
      this.btnSelectNone.Size = new System.Drawing.Size(74, 24);
      this.btnSelectNone.TabIndex = 2;
      this.btnSelectNone.Text = "Select None";
      this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
      // 
      // gridColors
      // 
      this.gridColors.AllowUserToAddRows = false;
      this.gridColors.AllowUserToDeleteRows = false;
      this.gridColors.AllowUserToResizeColumns = false;
      this.gridColors.AllowUserToResizeRows = false;
      this.gridColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridColors.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridColors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gridColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridColors.ColumnHeadersVisible = false;
      this.gridColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnChecked,
            this.clmnColor,
            this.clmnName});
      this.tableLayoutPanel1.SetColumnSpan(this.gridColors, 3);
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.gridColors.DefaultCellStyle = dataGridViewCellStyle1;
      this.gridColors.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridColors.Location = new System.Drawing.Point(3, 3);
      this.gridColors.Name = "gridColors";
      this.gridColors.RowHeadersVisible = false;
      this.gridColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridColors.Size = new System.Drawing.Size(187, 114);
      this.gridColors.TabIndex = 3;
      // 
      // clmnChecked
      // 
      this.clmnChecked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.clmnChecked.FillWeight = 33.50254F;
      this.clmnChecked.HeaderText = "Checked";
      this.clmnChecked.MinimumWidth = 22;
      this.clmnChecked.Name = "clmnChecked";
      this.clmnChecked.Width = 22;
      // 
      // clmnColor
      // 
      this.clmnColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.clmnColor.FillWeight = 33.50254F;
      this.clmnColor.HeaderText = "Color";
      this.clmnColor.MinimumWidth = 22;
      this.clmnColor.Name = "clmnColor";
      this.clmnColor.ReadOnly = true;
      this.clmnColor.Width = 22;
      // 
      // clmnName
      // 
      this.clmnName.FillWeight = 232.9949F;
      this.clmnName.HeaderText = "Name";
      this.clmnName.Name = "clmnName";
      this.clmnName.ReadOnly = true;
      // 
      // GeoColorSelectControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "GeoColorSelectControl";
      this.Size = new System.Drawing.Size(193, 150);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridColors)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnSelectAll;
    private System.Windows.Forms.Button btnSelectNone;
    private System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.DataGridView gridColors;
    private System.Windows.Forms.DataGridViewCheckBoxColumn clmnChecked;
    private System.Windows.Forms.DataGridViewImageColumn clmnColor;
    private System.Windows.Forms.DataGridViewTextBoxColumn clmnName;
  }
}
