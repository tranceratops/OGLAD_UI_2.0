
namespace OGLAD_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStatValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.leadLagPlotTool = new System.Windows.Forms.CheckBox();
            this.minMaxPlotTool = new System.Windows.Forms.CheckBox();
            this.SD2PlotTool = new System.Windows.Forms.CheckBox();
            this.SD1PlotTool = new System.Windows.Forms.CheckBox();
            this.meanPlotTool = new System.Windows.Forms.CheckBox();
            this.histPlotTool = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.signalGraphCE24 = new System.Windows.Forms.CheckBox();
            this.signalGraphCE1 = new System.Windows.Forms.CheckBox();
            this.signalGraphPow = new System.Windows.Forms.CheckBox();
            this.signalGraphFreq = new System.Windows.Forms.CheckBox();
            this.signalGraphCurr = new System.Windows.Forms.CheckBox();
            this.signalGraphVolt = new System.Windows.Forms.CheckBox();
            this.gbxView = new System.Windows.Forms.GroupBox();
            this.plotGraph = new ScottPlot.FormsPlot();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.statSD2UpperVal = new System.Windows.Forms.Label();
            this.statSD1UpperVal = new System.Windows.Forms.Label();
            this.statMaxVal = new System.Windows.Forms.Label();
            this.statMinVal = new System.Windows.Forms.Label();
            this.statSD2LowerVal = new System.Windows.Forms.Label();
            this.statSD1LowerVal = new System.Windows.Forms.Label();
            this.statMeanVal = new System.Windows.Forms.Label();
            this.statMin = new System.Windows.Forms.Label();
            this.statSD2 = new System.Windows.Forms.Label();
            this.statSD1 = new System.Windows.Forms.Label();
            this.statMean = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statLeadLagVal = new System.Windows.Forms.Label();
            this.statLeadLag = new System.Windows.Forms.Label();
            this.statMax = new System.Windows.Forms.Label();
            this.openInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickControlAssistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxView.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save Plot";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.openInNewWindowToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportStatValuesToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportStatValuesToolStripMenuItem
            // 
            this.exportStatValuesToolStripMenuItem.Name = "exportStatValuesToolStripMenuItem";
            this.exportStatValuesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportStatValuesToolStripMenuItem.Text = "Export Stat Values";
            this.exportStatValuesToolStripMenuItem.Click += new System.EventHandler(this.exportStatValuesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStartedToolStripMenuItem,
            this.quickControlAssistToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // getStartedToolStripMenuItem
            // 
            this.getStartedToolStripMenuItem.Name = "getStartedToolStripMenuItem";
            this.getStartedToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.getStartedToolStripMenuItem.Text = "Get Started";
            this.getStartedToolStripMenuItem.Click += new System.EventHandler(this.getStartedToolStripMenuItem_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.leadLagPlotTool);
            this.groupBox6.Controls.Add(this.minMaxPlotTool);
            this.groupBox6.Controls.Add(this.SD2PlotTool);
            this.groupBox6.Controls.Add(this.SD1PlotTool);
            this.groupBox6.Controls.Add(this.meanPlotTool);
            this.groupBox6.Controls.Add(this.histPlotTool);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 162);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(80, 153);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Plot Tools";
            // 
            // leadLagPlotTool
            // 
            this.leadLagPlotTool.AutoSize = true;
            this.leadLagPlotTool.Location = new System.Drawing.Point(6, 170);
            this.leadLagPlotTool.Name = "leadLagPlotTool";
            this.leadLagPlotTool.Size = new System.Drawing.Size(133, 22);
            this.leadLagPlotTool.TabIndex = 5;
            this.leadLagPlotTool.Text = "Leading/Lagging";
            this.leadLagPlotTool.UseVisualStyleBackColor = true;
            // 
            // minMaxPlotTool
            // 
            this.minMaxPlotTool.AutoSize = true;
            this.minMaxPlotTool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minMaxPlotTool.Location = new System.Drawing.Point(6, 142);
            this.minMaxPlotTool.Name = "minMaxPlotTool";
            this.minMaxPlotTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minMaxPlotTool.Size = new System.Drawing.Size(83, 22);
            this.minMaxPlotTool.TabIndex = 4;
            this.minMaxPlotTool.Text = "Min/Max";
            this.minMaxPlotTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.minMaxPlotTool.UseVisualStyleBackColor = true;
            // 
            // SD2PlotTool
            // 
            this.SD2PlotTool.AutoSize = true;
            this.SD2PlotTool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SD2PlotTool.Location = new System.Drawing.Point(6, 114);
            this.SD2PlotTool.Name = "SD2PlotTool";
            this.SD2PlotTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SD2PlotTool.Size = new System.Drawing.Size(60, 22);
            this.SD2PlotTool.TabIndex = 3;
            this.SD2PlotTool.Text = "SD 2";
            this.SD2PlotTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SD2PlotTool.UseVisualStyleBackColor = true;
            // 
            // SD1PlotTool
            // 
            this.SD1PlotTool.AutoSize = true;
            this.SD1PlotTool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SD1PlotTool.Location = new System.Drawing.Point(6, 86);
            this.SD1PlotTool.Name = "SD1PlotTool";
            this.SD1PlotTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SD1PlotTool.Size = new System.Drawing.Size(60, 22);
            this.SD1PlotTool.TabIndex = 2;
            this.SD1PlotTool.Text = "1 SD";
            this.SD1PlotTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SD1PlotTool.UseVisualStyleBackColor = true;
            // 
            // meanPlotTool
            // 
            this.meanPlotTool.AutoSize = true;
            this.meanPlotTool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.meanPlotTool.Location = new System.Drawing.Point(6, 58);
            this.meanPlotTool.Name = "meanPlotTool";
            this.meanPlotTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.meanPlotTool.Size = new System.Drawing.Size(64, 22);
            this.meanPlotTool.TabIndex = 1;
            this.meanPlotTool.Text = "Mean";
            this.meanPlotTool.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.meanPlotTool.UseVisualStyleBackColor = true;
            // 
            // histPlotTool
            // 
            this.histPlotTool.AutoSize = true;
            this.histPlotTool.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.histPlotTool.Location = new System.Drawing.Point(6, 30);
            this.histPlotTool.Name = "histPlotTool";
            this.histPlotTool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.histPlotTool.Size = new System.Drawing.Size(96, 22);
            this.histPlotTool.TabIndex = 0;
            this.histPlotTool.Text = "Histogram";
            this.histPlotTool.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.tableLayoutPanel1);
            this.groupBox5.Location = new System.Drawing.Point(12, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(855, 462);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.29212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.70789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbxView, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(843, 446);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.signalGraphCE24);
            this.groupBox3.Controls.Add(this.signalGraphCE1);
            this.groupBox3.Controls.Add(this.signalGraphPow);
            this.groupBox3.Controls.Add(this.signalGraphFreq);
            this.groupBox3.Controls.Add(this.signalGraphCurr);
            this.groupBox3.Controls.Add(this.signalGraphVolt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(80, 153);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display";
            // 
            // signalGraphCE24
            // 
            this.signalGraphCE24.AutoSize = true;
            this.signalGraphCE24.Location = new System.Drawing.Point(6, 145);
            this.signalGraphCE24.Name = "signalGraphCE24";
            this.signalGraphCE24.Size = new System.Drawing.Size(136, 22);
            this.signalGraphCE24.TabIndex = 6;
            this.signalGraphCE24.Text = "Tot. Energy 24hr";
            this.signalGraphCE24.UseVisualStyleBackColor = true;
            // 
            // signalGraphCE1
            // 
            this.signalGraphCE1.AutoSize = true;
            this.signalGraphCE1.Location = new System.Drawing.Point(6, 122);
            this.signalGraphCE1.Name = "signalGraphCE1";
            this.signalGraphCE1.Size = new System.Drawing.Size(128, 22);
            this.signalGraphCE1.TabIndex = 5;
            this.signalGraphCE1.Text = "Tot. Energy 1hr";
            this.signalGraphCE1.UseVisualStyleBackColor = true;
            // 
            // signalGraphPow
            // 
            this.signalGraphPow.AutoSize = true;
            this.signalGraphPow.Location = new System.Drawing.Point(6, 99);
            this.signalGraphPow.Name = "signalGraphPow";
            this.signalGraphPow.Size = new System.Drawing.Size(70, 22);
            this.signalGraphPow.TabIndex = 4;
            this.signalGraphPow.Text = "Power";
            this.signalGraphPow.UseVisualStyleBackColor = true;
            // 
            // signalGraphFreq
            // 
            this.signalGraphFreq.AutoSize = true;
            this.signalGraphFreq.Location = new System.Drawing.Point(6, 76);
            this.signalGraphFreq.Name = "signalGraphFreq";
            this.signalGraphFreq.Size = new System.Drawing.Size(96, 22);
            this.signalGraphFreq.TabIndex = 3;
            this.signalGraphFreq.Text = "Frequency";
            this.signalGraphFreq.UseVisualStyleBackColor = true;
            // 
            // signalGraphCurr
            // 
            this.signalGraphCurr.AutoSize = true;
            this.signalGraphCurr.Location = new System.Drawing.Point(6, 53);
            this.signalGraphCurr.Name = "signalGraphCurr";
            this.signalGraphCurr.Size = new System.Drawing.Size(76, 22);
            this.signalGraphCurr.TabIndex = 1;
            this.signalGraphCurr.Text = "Current";
            this.signalGraphCurr.UseVisualStyleBackColor = true;
            // 
            // signalGraphVolt
            // 
            this.signalGraphVolt.AutoSize = true;
            this.signalGraphVolt.Location = new System.Drawing.Point(6, 30);
            this.signalGraphVolt.Name = "signalGraphVolt";
            this.signalGraphVolt.Size = new System.Drawing.Size(76, 22);
            this.signalGraphVolt.TabIndex = 0;
            this.signalGraphVolt.Text = "Voltage";
            this.signalGraphVolt.UseVisualStyleBackColor = true;
            // 
            // gbxView
            // 
            this.gbxView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxView.Controls.Add(this.plotGraph);
            this.gbxView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxView.ForeColor = System.Drawing.Color.White;
            this.gbxView.Location = new System.Drawing.Point(89, 3);
            this.gbxView.Name = "gbxView";
            this.tableLayoutPanel1.SetRowSpan(this.gbxView, 2);
            this.gbxView.Size = new System.Drawing.Size(555, 312);
            this.gbxView.TabIndex = 5;
            this.gbxView.TabStop = false;
            this.gbxView.Text = "View";
            // 
            // plotGraph
            // 
            this.plotGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.plotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotGraph.Location = new System.Drawing.Point(6, 19);
            this.plotGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plotGraph.Name = "plotGraph";
            this.plotGraph.Size = new System.Drawing.Size(546, 289);
            this.plotGraph.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(837, 122);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(175, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 82);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data View";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.txtStatus.Location = new System.Drawing.Point(62, 32);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(588, 24);
            this.txtStatus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plot Controls";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(198)))));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(43, 56);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Clear";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(135)))), ((int)(((byte)(198)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(43, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Plot";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.statSD2UpperVal);
            this.groupBox7.Controls.Add(this.statSD1UpperVal);
            this.groupBox7.Controls.Add(this.statMaxVal);
            this.groupBox7.Controls.Add(this.statMinVal);
            this.groupBox7.Controls.Add(this.statSD2LowerVal);
            this.groupBox7.Controls.Add(this.statSD1LowerVal);
            this.groupBox7.Controls.Add(this.statMeanVal);
            this.groupBox7.Controls.Add(this.statMin);
            this.groupBox7.Controls.Add(this.statSD2);
            this.groupBox7.Controls.Add(this.statSD1);
            this.groupBox7.Controls.Add(this.statMean);
            this.groupBox7.Controls.Add(this.panel1);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(650, 3);
            this.groupBox7.Name = "groupBox7";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox7, 2);
            this.groupBox7.Size = new System.Drawing.Size(190, 312);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stat Values";
            // 
            // statSD2UpperVal
            // 
            this.statSD2UpperVal.AutoSize = true;
            this.statSD2UpperVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD2UpperVal.ForeColor = System.Drawing.Color.Black;
            this.statSD2UpperVal.Location = new System.Drawing.Point(111, 189);
            this.statSD2UpperVal.Name = "statSD2UpperVal";
            this.statSD2UpperVal.Size = new System.Drawing.Size(46, 18);
            this.statSD2UpperVal.TabIndex = 12;
            this.statSD2UpperVal.Text = "label3";
            this.statSD2UpperVal.Visible = false;
            // 
            // statSD1UpperVal
            // 
            this.statSD1UpperVal.AutoSize = true;
            this.statSD1UpperVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD1UpperVal.ForeColor = System.Drawing.Color.Black;
            this.statSD1UpperVal.Location = new System.Drawing.Point(111, 124);
            this.statSD1UpperVal.Name = "statSD1UpperVal";
            this.statSD1UpperVal.Size = new System.Drawing.Size(46, 18);
            this.statSD1UpperVal.TabIndex = 11;
            this.statSD1UpperVal.Text = "label2";
            this.statSD1UpperVal.Visible = false;
            // 
            // statMaxVal
            // 
            this.statMaxVal.AutoSize = true;
            this.statMaxVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMaxVal.ForeColor = System.Drawing.Color.Black;
            this.statMaxVal.Location = new System.Drawing.Point(110, 297);
            this.statMaxVal.Name = "statMaxVal";
            this.statMaxVal.Size = new System.Drawing.Size(32, 18);
            this.statMaxVal.TabIndex = 10;
            this.statMaxVal.Text = "N/A";
            // 
            // statMinVal
            // 
            this.statMinVal.AutoSize = true;
            this.statMinVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMinVal.ForeColor = System.Drawing.Color.Black;
            this.statMinVal.Location = new System.Drawing.Point(109, 234);
            this.statMinVal.Name = "statMinVal";
            this.statMinVal.Size = new System.Drawing.Size(32, 18);
            this.statMinVal.TabIndex = 9;
            this.statMinVal.Text = "N/A";
            // 
            // statSD2LowerVal
            // 
            this.statSD2LowerVal.AutoSize = true;
            this.statSD2LowerVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD2LowerVal.ForeColor = System.Drawing.Color.Black;
            this.statSD2LowerVal.Location = new System.Drawing.Point(109, 169);
            this.statSD2LowerVal.Name = "statSD2LowerVal";
            this.statSD2LowerVal.Size = new System.Drawing.Size(32, 18);
            this.statSD2LowerVal.TabIndex = 8;
            this.statSD2LowerVal.Text = "N/A";
            // 
            // statSD1LowerVal
            // 
            this.statSD1LowerVal.AutoSize = true;
            this.statSD1LowerVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD1LowerVal.ForeColor = System.Drawing.Color.Black;
            this.statSD1LowerVal.Location = new System.Drawing.Point(111, 104);
            this.statSD1LowerVal.Name = "statSD1LowerVal";
            this.statSD1LowerVal.Size = new System.Drawing.Size(32, 18);
            this.statSD1LowerVal.TabIndex = 7;
            this.statSD1LowerVal.Text = "N/A";
            // 
            // statMeanVal
            // 
            this.statMeanVal.AutoSize = true;
            this.statMeanVal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMeanVal.ForeColor = System.Drawing.Color.Black;
            this.statMeanVal.Location = new System.Drawing.Point(109, 43);
            this.statMeanVal.Name = "statMeanVal";
            this.statMeanVal.Size = new System.Drawing.Size(32, 18);
            this.statMeanVal.TabIndex = 6;
            this.statMeanVal.Text = "N/A";
            // 
            // statMin
            // 
            this.statMin.AutoSize = true;
            this.statMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMin.ForeColor = System.Drawing.Color.Black;
            this.statMin.Location = new System.Drawing.Point(23, 234);
            this.statMin.Name = "statMin";
            this.statMin.Size = new System.Drawing.Size(36, 18);
            this.statMin.TabIndex = 4;
            this.statMin.Text = "Min:";
            // 
            // statSD2
            // 
            this.statSD2.AutoSize = true;
            this.statSD2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD2.ForeColor = System.Drawing.Color.Black;
            this.statSD2.Location = new System.Drawing.Point(21, 169);
            this.statSD2.Name = "statSD2";
            this.statSD2.Size = new System.Drawing.Size(45, 18);
            this.statSD2.TabIndex = 3;
            this.statSD2.Text = "SD 2:";
            // 
            // statSD1
            // 
            this.statSD1.AutoSize = true;
            this.statSD1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statSD1.ForeColor = System.Drawing.Color.Black;
            this.statSD1.Location = new System.Drawing.Point(21, 104);
            this.statSD1.Name = "statSD1";
            this.statSD1.Size = new System.Drawing.Size(45, 18);
            this.statSD1.TabIndex = 2;
            this.statSD1.Text = "SD 1:";
            // 
            // statMean
            // 
            this.statMean.AutoSize = true;
            this.statMean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMean.ForeColor = System.Drawing.Color.Black;
            this.statMean.Location = new System.Drawing.Point(21, 43);
            this.statMean.Name = "statMean";
            this.statMean.Size = new System.Drawing.Size(49, 18);
            this.statMean.TabIndex = 1;
            this.statMean.Text = "Mean:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.statLeadLagVal);
            this.panel1.Controls.Add(this.statLeadLag);
            this.panel1.Controls.Add(this.statMax);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 289);
            this.panel1.TabIndex = 13;
            // 
            // statLeadLagVal
            // 
            this.statLeadLagVal.AutoSize = true;
            this.statLeadLagVal.ForeColor = System.Drawing.Color.Black;
            this.statLeadLagVal.Location = new System.Drawing.Point(112, 338);
            this.statLeadLagVal.Name = "statLeadLagVal";
            this.statLeadLagVal.Size = new System.Drawing.Size(32, 18);
            this.statLeadLagVal.TabIndex = 9;
            this.statLeadLagVal.Text = "N/A";
            // 
            // statLeadLag
            // 
            this.statLeadLag.AutoSize = true;
            this.statLeadLag.ForeColor = System.Drawing.Color.Black;
            this.statLeadLag.Location = new System.Drawing.Point(18, 338);
            this.statLeadLag.Name = "statLeadLag";
            this.statLeadLag.Size = new System.Drawing.Size(65, 18);
            this.statLeadLag.TabIndex = 8;
            this.statLeadLag.Text = "Current: ";
            // 
            // statMax
            // 
            this.statMax.AutoSize = true;
            this.statMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMax.ForeColor = System.Drawing.Color.Black;
            this.statMax.Location = new System.Drawing.Point(18, 278);
            this.statMax.Name = "statMax";
            this.statMax.Size = new System.Drawing.Size(40, 18);
            this.statMax.TabIndex = 5;
            this.statMax.Text = "Max:";
            // 
            // openInNewWindowToolStripMenuItem
            // 
            this.openInNewWindowToolStripMenuItem.Name = "openInNewWindowToolStripMenuItem";
            this.openInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openInNewWindowToolStripMenuItem.Text = "Open in New Window";
            this.openInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openInNewWindowToolStripMenuItem_Click);
            // 
            // quickControlAssistToolStripMenuItem
            // 
            this.quickControlAssistToolStripMenuItem.Name = "quickControlAssistToolStripMenuItem";
            this.quickControlAssistToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quickControlAssistToolStripMenuItem.Text = "Quick Control Assist";
            this.quickControlAssistToolStripMenuItem.Click += new System.EventHandler(this.quickControlAssistToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(124)))));
            this.ClientSize = new System.Drawing.Size(879, 501);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KWH Load Analyzer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxView.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStartedToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox histPlotTool;
        private System.Windows.Forms.CheckBox SD1PlotTool;
        private System.Windows.Forms.CheckBox meanPlotTool;
        private System.Windows.Forms.CheckBox SD2PlotTool;
        private System.Windows.Forms.CheckBox minMaxPlotTool;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox signalGraphFreq;
        private System.Windows.Forms.CheckBox signalGraphCurr;
        private System.Windows.Forms.CheckBox signalGraphVolt;
        private System.Windows.Forms.GroupBox gbxView;
        private ScottPlot.FormsPlot plotGraph;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label statMax;
        private System.Windows.Forms.Label statMin;
        private System.Windows.Forms.Label statSD2;
        private System.Windows.Forms.Label statSD1;
        private System.Windows.Forms.Label statMean;
        private System.Windows.Forms.Label statMaxVal;
        private System.Windows.Forms.Label statMinVal;
        private System.Windows.Forms.Label statSD2LowerVal;
        private System.Windows.Forms.Label statSD1LowerVal;
        private System.Windows.Forms.Label statMeanVal;
        private System.Windows.Forms.Label statSD2UpperVal;
        private System.Windows.Forms.Label statSD1UpperVal;
        private System.Windows.Forms.CheckBox signalGraphPow;
        private System.Windows.Forms.Label statLeadLag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statLeadLagVal;
        private System.Windows.Forms.CheckBox leadLagPlotTool;
        private System.Windows.Forms.CheckBox signalGraphCE1;
        private System.Windows.Forms.CheckBox signalGraphCE24;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStatValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickControlAssistToolStripMenuItem;
    }
}

