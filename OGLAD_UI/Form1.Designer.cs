
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
            this.capturePlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStatValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAndExportSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.minMaxPlotTool = new System.Windows.Forms.CheckBox();
            this.SD2PlotTool = new System.Windows.Forms.CheckBox();
            this.SD1PlotTool = new System.Windows.Forms.CheckBox();
            this.meanPlotTool = new System.Windows.Forms.CheckBox();
            this.histPlotTool = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.signalGraphPow = new System.Windows.Forms.CheckBox();
            this.signalGraphFreq = new System.Windows.Forms.CheckBox();
            this.signalGraphPF = new System.Windows.Forms.CheckBox();
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
            this.statMax = new System.Windows.Forms.Label();
            this.statMin = new System.Windows.Forms.Label();
            this.statSD2 = new System.Windows.Forms.Label();
            this.statSD1 = new System.Windows.Forms.Label();
            this.statMean = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.meterToolStripMenuItem,
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
            this.settingsToolStripMenuItem,
            this.recentFileToolStripMenuItem,
            this.recentProfilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capturePlotToolStripMenuItem,
            this.saveStatValuesToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // capturePlotToolStripMenuItem
            // 
            this.capturePlotToolStripMenuItem.Name = "capturePlotToolStripMenuItem";
            this.capturePlotToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.capturePlotToolStripMenuItem.Text = "Capture Plot";
            this.capturePlotToolStripMenuItem.Click += new System.EventHandler(this.capturePlotToolStripMenuItem_Click);
            // 
            // saveStatValuesToolStripMenuItem
            // 
            this.saveStatValuesToolStripMenuItem.Name = "saveStatValuesToolStripMenuItem";
            this.saveStatValuesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveStatValuesToolStripMenuItem.Text = "Save Stat Values";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // recentFileToolStripMenuItem
            // 
            this.recentFileToolStripMenuItem.Name = "recentFileToolStripMenuItem";
            this.recentFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recentFileToolStripMenuItem.Text = "Recent Files";
            // 
            // recentProfilesToolStripMenuItem
            // 
            this.recentProfilesToolStripMenuItem.Name = "recentProfilesToolStripMenuItem";
            this.recentProfilesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recentProfilesToolStripMenuItem.Text = "Recent Profiles";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullScreenToolStripMenuItem,
            this.tabOrderToolStripMenuItem,
            this.displayMethodToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            // 
            // tabOrderToolStripMenuItem
            // 
            this.tabOrderToolStripMenuItem.Name = "tabOrderToolStripMenuItem";
            this.tabOrderToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.tabOrderToolStripMenuItem.Text = "Tab Order";
            // 
            // displayMethodToolStripMenuItem
            // 
            this.displayMethodToolStripMenuItem.Name = "displayMethodToolStripMenuItem";
            this.displayMethodToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.displayMethodToolStripMenuItem.Text = "Display Method";
            // 
            // meterToolStripMenuItem
            // 
            this.meterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deviceToolStripMenuItem});
            this.meterToolStripMenuItem.Name = "meterToolStripMenuItem";
            this.meterToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.meterToolStripMenuItem.Text = "Meter";
            // 
            // deviceToolStripMenuItem
            // 
            this.deviceToolStripMenuItem.Name = "deviceToolStripMenuItem";
            this.deviceToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.deviceToolStripMenuItem.Text = "Device";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.commandLineToolStripMenuItem,
            this.importAndExportSettingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // commandLineToolStripMenuItem
            // 
            this.commandLineToolStripMenuItem.Name = "commandLineToolStripMenuItem";
            this.commandLineToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.commandLineToolStripMenuItem.Text = "Command Line";
            // 
            // importAndExportSettingsToolStripMenuItem
            // 
            this.importAndExportSettingsToolStripMenuItem.Name = "importAndExportSettingsToolStripMenuItem";
            this.importAndExportSettingsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.importAndExportSettingsToolStripMenuItem.Text = "Import and Export Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.getStartedToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // getStartedToolStripMenuItem
            // 
            this.getStartedToolStripMenuItem.Name = "getStartedToolStripMenuItem";
            this.getStartedToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.getStartedToolStripMenuItem.Text = "Get Started";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox6.Size = new System.Drawing.Size(74, 153);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Plot Tools";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.46459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.53541F));
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
            this.groupBox3.Controls.Add(this.signalGraphPow);
            this.groupBox3.Controls.Add(this.signalGraphFreq);
            this.groupBox3.Controls.Add(this.signalGraphPF);
            this.groupBox3.Controls.Add(this.signalGraphCurr);
            this.groupBox3.Controls.Add(this.signalGraphVolt);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(74, 153);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display";
            // 
            // signalGraphPow
            // 
            this.signalGraphPow.AutoSize = true;
            this.signalGraphPow.Location = new System.Drawing.Point(6, 124);
            this.signalGraphPow.Name = "signalGraphPow";
            this.signalGraphPow.Size = new System.Drawing.Size(70, 22);
            this.signalGraphPow.TabIndex = 4;
            this.signalGraphPow.Text = "Power";
            this.signalGraphPow.UseVisualStyleBackColor = true;
            // 
            // signalGraphFreq
            // 
            this.signalGraphFreq.AutoSize = true;
            this.signalGraphFreq.Location = new System.Drawing.Point(6, 100);
            this.signalGraphFreq.Name = "signalGraphFreq";
            this.signalGraphFreq.Size = new System.Drawing.Size(96, 22);
            this.signalGraphFreq.TabIndex = 3;
            this.signalGraphFreq.Text = "Frequency";
            this.signalGraphFreq.UseVisualStyleBackColor = true;
            // 
            // signalGraphPF
            // 
            this.signalGraphPF.AutoSize = true;
            this.signalGraphPF.Location = new System.Drawing.Point(6, 76);
            this.signalGraphPF.Name = "signalGraphPF";
            this.signalGraphPF.Size = new System.Drawing.Size(117, 22);
            this.signalGraphPF.TabIndex = 2;
            this.signalGraphPF.Text = "Power Factor";
            this.signalGraphPF.UseVisualStyleBackColor = true;
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
            this.gbxView.Location = new System.Drawing.Point(83, 3);
            this.gbxView.Name = "gbxView";
            this.tableLayoutPanel1.SetRowSpan(this.gbxView, 2);
            this.gbxView.Size = new System.Drawing.Size(561, 312);
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
            this.plotGraph.Size = new System.Drawing.Size(552, 289);
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
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.statSD2UpperVal);
            this.groupBox7.Controls.Add(this.statSD1UpperVal);
            this.groupBox7.Controls.Add(this.statMaxVal);
            this.groupBox7.Controls.Add(this.statMinVal);
            this.groupBox7.Controls.Add(this.statSD2LowerVal);
            this.groupBox7.Controls.Add(this.statSD1LowerVal);
            this.groupBox7.Controls.Add(this.statMeanVal);
            this.groupBox7.Controls.Add(this.statMax);
            this.groupBox7.Controls.Add(this.statMin);
            this.groupBox7.Controls.Add(this.statSD2);
            this.groupBox7.Controls.Add(this.statSD1);
            this.groupBox7.Controls.Add(this.statMean);
            this.groupBox7.Controls.Add(this.richTextBox1);
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
            this.statMaxVal.Location = new System.Drawing.Point(109, 297);
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
            // statMax
            // 
            this.statMax.AutoSize = true;
            this.statMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMax.ForeColor = System.Drawing.Color.Black;
            this.statMax.Location = new System.Drawing.Point(21, 297);
            this.statMax.Name = "statMax";
            this.statMax.Size = new System.Drawing.Size(40, 18);
            this.statMax.TabIndex = 5;
            this.statMax.Text = "Max:";
            // 
            // statMin
            // 
            this.statMin.AutoSize = true;
            this.statMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.statMin.ForeColor = System.Drawing.Color.Black;
            this.statMin.Location = new System.Drawing.Point(21, 234);
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
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 291);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
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
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAndExportSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
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
        private System.Windows.Forms.CheckBox signalGraphPF;
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
        private System.Windows.Forms.ToolStripMenuItem capturePlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStatValuesToolStripMenuItem;
        private System.Windows.Forms.Label statSD2UpperVal;
        private System.Windows.Forms.Label statSD1UpperVal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox signalGraphPow;
        private System.Windows.Forms.Label label2;
    }
}

