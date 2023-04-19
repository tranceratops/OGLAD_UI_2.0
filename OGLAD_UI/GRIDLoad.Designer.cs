using System.Drawing;
using System.Windows.Forms;

namespace OGLAD_UI
{
    partial class GRIDLoad
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.plotGraph = new ScottPlot.FormsPlot();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportPlotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportStatValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importingAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interactingWithDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usingHistogramControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formattingExternalDataFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickControlAssistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayLoadProfileView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayLoadProfileData = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hourOn = new System.Windows.Forms.TextBox();
            this.hourOff = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.signalGraphActPower = new System.Windows.Forms.CheckBox();
            this.signalGraphAppPower = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotGraph
            // 
            this.plotGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.plotGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotGraph.Location = new System.Drawing.Point(21, 246);
            this.plotGraph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plotGraph.Name = "plotGraph";
            this.plotGraph.Size = new System.Drawing.Size(1402, 266);
            this.plotGraph.TabIndex = 0;
            this.plotGraph.Load += new System.EventHandler(this.formsPlot1_Load);
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
            this.menuStrip1.Size = new System.Drawing.Size(1436, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openLoadProfileToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem,
            this.exportPlotToolStripMenuItem,
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
            // openLoadProfileToolStripMenuItem
            // 
            this.openLoadProfileToolStripMenuItem.Name = "openLoadProfileToolStripMenuItem";
            this.openLoadProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openLoadProfileToolStripMenuItem.Text = "Open";
            this.openLoadProfileToolStripMenuItem.Click += new System.EventHandler(this.openLoadProfileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportPlotToolStripMenuItem
            // 
            this.exportPlotToolStripMenuItem.Name = "exportPlotToolStripMenuItem";
            this.exportPlotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportPlotToolStripMenuItem.Text = "Export Plot";
            this.exportPlotToolStripMenuItem.Click += new System.EventHandler(this.exportPlotToolStripMenuItem_Click);
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
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
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
            // 
            // openInNewWindowToolStripMenuItem
            // 
            this.openInNewWindowToolStripMenuItem.Name = "openInNewWindowToolStripMenuItem";
            this.openInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.openInNewWindowToolStripMenuItem.Text = "Open in New Window";
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
            this.exportStatValuesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportStatValuesToolStripMenuItem.Text = "Export Stat Values";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStartedToolStripMenuItem,
            this.quickControlAssistToolStripMenuItem,
            this.fAQToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // getStartedToolStripMenuItem
            // 
            this.getStartedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importingAFileToolStripMenuItem,
            this.interactingWithDataToolStripMenuItem,
            this.fAQToolStripMenuItem,
            this.usingHistogramControlsToolStripMenuItem,
            this.formattingExternalDataFilesToolStripMenuItem});
            this.getStartedToolStripMenuItem.Name = "getStartedToolStripMenuItem";
            this.getStartedToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.getStartedToolStripMenuItem.Text = "LAGUI Guide";
            // 
            // importingAFileToolStripMenuItem
            // 
            this.importingAFileToolStripMenuItem.Name = "importingAFileToolStripMenuItem";
            this.importingAFileToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.importingAFileToolStripMenuItem.Text = "Importing a File";
            // 
            // interactingWithDataToolStripMenuItem
            // 
            this.interactingWithDataToolStripMenuItem.Name = "interactingWithDataToolStripMenuItem";
            this.interactingWithDataToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.interactingWithDataToolStripMenuItem.Text = "Interacting with Data";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.fAQToolStripMenuItem.Text = "Exporting Data";
            // 
            // usingHistogramControlsToolStripMenuItem
            // 
            this.usingHistogramControlsToolStripMenuItem.Name = "usingHistogramControlsToolStripMenuItem";
            this.usingHistogramControlsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.usingHistogramControlsToolStripMenuItem.Text = "Using Histogram Controls";
            // 
            // formattingExternalDataFilesToolStripMenuItem
            // 
            this.formattingExternalDataFilesToolStripMenuItem.Name = "formattingExternalDataFilesToolStripMenuItem";
            this.formattingExternalDataFilesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.formattingExternalDataFilesToolStripMenuItem.Text = "Formatting External Data Files";
            // 
            // quickControlAssistToolStripMenuItem
            // 
            this.quickControlAssistToolStripMenuItem.Name = "quickControlAssistToolStripMenuItem";
            this.quickControlAssistToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.quickControlAssistToolStripMenuItem.Text = "Quick Control Assist";
            // 
            // fAQToolStripMenuItem1
            // 
            this.fAQToolStripMenuItem1.Name = "fAQToolStripMenuItem1";
            this.fAQToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.fAQToolStripMenuItem1.Text = "FAQ";
            // 
            // displayLoadProfileView
            // 
            this.displayLoadProfileView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.displayLoadProfileView.AllowColumnReorder = true;
            this.displayLoadProfileView.AutoArrange = false;
            this.displayLoadProfileView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.displayLoadProfileView.Font = new System.Drawing.Font("Rockwell", 11.5F);
            this.displayLoadProfileView.FullRowSelect = true;
            this.displayLoadProfileView.HideSelection = false;
            this.displayLoadProfileView.Location = new System.Drawing.Point(21, 39);
            this.displayLoadProfileView.Name = "displayLoadProfileView";
            this.displayLoadProfileView.Size = new System.Drawing.Size(257, 196);
            this.displayLoadProfileView.TabIndex = 0;
            this.displayLoadProfileView.UseCompatibleStateImageBehavior = false;
            this.displayLoadProfileView.View = System.Windows.Forms.View.Details;
            this.displayLoadProfileView.SelectedIndexChanged += new System.EventHandler(this.displayLoadProfileView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Load Profile";
            this.columnHeader1.Width = 270;
            // 
            // displayLoadProfileData
            // 
            this.displayLoadProfileData.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.displayLoadProfileData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.displayLoadProfileData.Font = new System.Drawing.Font("Rockwell", 11.5F);
            this.displayLoadProfileData.FullRowSelect = true;
            this.displayLoadProfileData.HideSelection = false;
            this.displayLoadProfileData.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.displayLoadProfileData.Location = new System.Drawing.Point(284, 39);
            this.displayLoadProfileData.Name = "displayLoadProfileData";
            this.displayLoadProfileData.Size = new System.Drawing.Size(397, 196);
            this.displayLoadProfileData.TabIndex = 23;
            this.displayLoadProfileData.UseCompatibleStateImageBehavior = false;
            this.displayLoadProfileData.View = System.Windows.Forms.View.Details;
            this.displayLoadProfileData.SelectedIndexChanged += new System.EventHandler(this.displayLoadProfileData_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Load Profile Data:";
            this.columnHeader4.Width = 241;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 150;
            // 
            // hourOn
            // 
            this.hourOn.Location = new System.Drawing.Point(708, 55);
            this.hourOn.MaxLength = 2;
            this.hourOn.Name = "hourOn";
            this.hourOn.Size = new System.Drawing.Size(120, 20);
            this.hourOn.TabIndex = 24;
            this.hourOn.TextChanged += new System.EventHandler(this.hourOn_TextChanged);
            this.hourOn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourOn_KeyDown);
            // 
            // hourOff
            // 
            this.hourOff.Location = new System.Drawing.Point(708, 118);
            this.hourOff.MaxLength = 2;
            this.hourOff.Name = "hourOff";
            this.hourOff.Size = new System.Drawing.Size(120, 20);
            this.hourOff.TabIndex = 24;
            this.hourOff.TextChanged += new System.EventHandler(this.hourOff_TextChanged);
            this.hourOff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hourOff_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hour of the day on (24-Hour): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(705, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hour of the day off (24-Hour): ";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(708, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Plot";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.GRIDLoad_Load);
            // 
            // signalGraphActPower
            // 
            this.signalGraphActPower.AutoSize = true;
            this.signalGraphActPower.Location = new System.Drawing.Point(820, 216);
            this.signalGraphActPower.Name = "signalGraphActPower";
            this.signalGraphActPower.Size = new System.Drawing.Size(89, 17);
            this.signalGraphActPower.TabIndex = 30;
            this.signalGraphActPower.Text = "Active Power";
            this.signalGraphActPower.UseVisualStyleBackColor = true;
            // 
            // signalGraphAppPower
            // 
            this.signalGraphAppPower.AutoSize = true;
            this.signalGraphAppPower.Location = new System.Drawing.Point(820, 166);
            this.signalGraphAppPower.Name = "signalGraphAppPower";
            this.signalGraphAppPower.Size = new System.Drawing.Size(102, 17);
            this.signalGraphAppPower.TabIndex = 29;
            this.signalGraphAppPower.Text = "Apparent Power";
            this.signalGraphAppPower.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(708, 212);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 31;
            this.btnStop.Text = "Clear";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // GRIDLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 525);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.signalGraphActPower);
            this.Controls.Add(this.signalGraphAppPower);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hourOff);
            this.Controls.Add(this.hourOn);
            this.Controls.Add(this.displayLoadProfileData);
            this.Controls.Add(this.displayLoadProfileView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.plotGraph);
            this.Name = "GRIDLoad";
            this.Text = "Grid Load";
            this.Load += new System.EventHandler(this.GRIDLoad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ScottPlot.FormsPlot plotGraph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportPlotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openInNewWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportStatValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getStartedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importingAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactingWithDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usingHistogramControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formattingExternalDataFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickControlAssistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openLoadProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ListView displayLoadProfileView;
        private System.Windows.Forms.ColumnHeader DeviceName;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ListView displayLoadProfileData;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox hourOn;
        private TextBox hourOff;
        private Label label1;
        private Label label2;
        private Button btnStart;
        private CheckBox signalGraphActPower;
        private CheckBox signalGraphAppPower;
        private Button btnStop;
        //private System.Windows.Forms.ListView displayLoadProfileData;
        //private System.Windows.Forms.ListView DisplayLoadProfileView;
    }
}