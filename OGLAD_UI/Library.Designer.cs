
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System;


namespace OGLAD_UI
{
    partial class Library
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
        /// 

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLoadProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLoadProfileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.fAQToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDeviceListBox = new System.Windows.Forms.ListBox();
            this.displayDeviceDataView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayLoadProfileView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteDeviceButton = new System.Windows.Forms.Button();
            this.displayLoadProfileData = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1609, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openLoadProfileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveLoadProfileAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openLoadProfileToolStripMenuItem
            // 
            this.openLoadProfileToolStripMenuItem.Name = "openLoadProfileToolStripMenuItem";
            this.openLoadProfileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openLoadProfileToolStripMenuItem.Text = "Open";
            this.openLoadProfileToolStripMenuItem.Click += new System.EventHandler(this.openLoadProfileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveLoadProfileAsToolStripMenuItem
            // 
            this.saveLoadProfileAsToolStripMenuItem.Name = "saveLoadProfileAsToolStripMenuItem";
            this.saveLoadProfileAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveLoadProfileAsToolStripMenuItem.Text = "Save As";
            this.saveLoadProfileAsToolStripMenuItem.Click += new System.EventHandler(this.saveLoadProfileAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
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
            this.exportStatValuesToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getStartedToolStripMenuItem,
            this.fAQToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // getStartedToolStripMenuItem
            // 
            this.getStartedToolStripMenuItem.Name = "getStartedToolStripMenuItem";
            this.getStartedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.getStartedToolStripMenuItem.Text = "LAGUI Guide";
            // 
            // fAQToolStripMenuItem1
            // 
            this.fAQToolStripMenuItem1.Name = "fAQToolStripMenuItem1";
            this.fAQToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.fAQToolStripMenuItem1.Text = "FAQ";
            // 
            // displayDeviceListBox
            // 
            this.displayDeviceListBox.Font = new System.Drawing.Font("Rockwell", 11.5F);
            this.displayDeviceListBox.FormattingEnabled = true;
            this.displayDeviceListBox.ItemHeight = 17;
            this.displayDeviceListBox.Items.AddRange(new object[] {
            "...",
            "Fan",
            "Lightbulb",
            "Saw",
            "Hair Dryer"});
            this.displayDeviceListBox.Location = new System.Drawing.Point(12, 37);
            this.displayDeviceListBox.Name = "displayDeviceListBox";
            this.displayDeviceListBox.Size = new System.Drawing.Size(397, 378);
            this.displayDeviceListBox.TabIndex = 15;
            this.displayDeviceListBox.SelectedIndexChanged += new System.EventHandler(this.displayDeviceListBox_SelectedIndexChanged);
            // 
            // displayDeviceDataView
            // 
            this.displayDeviceDataView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.displayDeviceDataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.displayDeviceDataView.Font = new System.Drawing.Font("Rockwell", 11.5F);
            this.displayDeviceDataView.FullRowSelect = true;
            this.displayDeviceDataView.HideSelection = false;
            this.displayDeviceDataView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.displayDeviceDataView.Location = new System.Drawing.Point(427, 37);
            this.displayDeviceDataView.Name = "displayDeviceDataView";
            this.displayDeviceDataView.Size = new System.Drawing.Size(368, 378);
            this.displayDeviceDataView.TabIndex = 16;
            this.displayDeviceDataView.UseCompatibleStateImageBehavior = false;
            this.displayDeviceDataView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Device Data:";
            this.columnHeader2.Width = 241;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 150;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 30);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 35);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Add Device";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(0, 97);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(106, 33);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.displayLoadProfileView);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Location = new System.Drawing.Point(801, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 378);
            this.panel1.TabIndex = 20;
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
            this.displayLoadProfileView.Location = new System.Drawing.Point(115, 0);
            this.displayLoadProfileView.Name = "displayLoadProfileView";
            this.displayLoadProfileView.Size = new System.Drawing.Size(295, 378);
            this.displayLoadProfileView.TabIndex = 0;
            this.displayLoadProfileView.UseCompatibleStateImageBehavior = false;
            this.displayLoadProfileView.View = System.Windows.Forms.View.Details;
            this.displayLoadProfileView.SelectedIndexChanged += new System.EventHandler(this.displayLoadProfileView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Load Profile:";
            this.columnHeader1.Width = 270;
            // 
            // deleteDeviceButton
            // 
            this.deleteDeviceButton.Location = new System.Drawing.Point(12, 433);
            this.deleteDeviceButton.Name = "deleteDeviceButton";
            this.deleteDeviceButton.Size = new System.Drawing.Size(106, 33);
            this.deleteDeviceButton.TabIndex = 22;
            this.deleteDeviceButton.Text = "Delete Device";
            this.deleteDeviceButton.UseVisualStyleBackColor = true;
            this.deleteDeviceButton.Click += new System.EventHandler(this.deleteDeviceButton_Click);
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
            listViewItem2});
            this.displayLoadProfileData.Location = new System.Drawing.Point(1228, 37);
            this.displayLoadProfileData.Name = "displayLoadProfileData";
            this.displayLoadProfileData.Size = new System.Drawing.Size(368, 378);
            this.displayLoadProfileData.TabIndex = 23;
            this.displayLoadProfileData.UseCompatibleStateImageBehavior = false;
            this.displayLoadProfileData.View = System.Windows.Forms.View.Details;
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
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 478);
            this.Controls.Add(this.displayLoadProfileData);
            this.Controls.Add(this.deleteDeviceButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayDeviceDataView);
            this.Controls.Add(this.displayDeviceListBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Library";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem1;
        private ListBox displayDeviceListBox;
        private System.Windows.Forms.ListView displayDeviceDataView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private Panel panel1;
        private System.Windows.Forms.ListView displayLoadProfileView;
        private ColumnHeader columnHeader1;
        private ToolStripMenuItem openLoadProfileToolStripMenuItem;
        private ToolStripMenuItem saveLoadProfileAsToolStripMenuItem;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private System.Windows.Forms.Button deleteDeviceButton;
        private System.Windows.Forms.ListView displayLoadProfileData;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}