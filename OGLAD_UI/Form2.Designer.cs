
namespace OGLAD_UI
{
    partial class GettingStarted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GettingStarted));
            this.Title = new System.Windows.Forms.TextBox();
            this.FirstSection = new System.Windows.Forms.TextBox();
            this.SectionOneExplain = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SectionOneExplain2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SectionTwo = new System.Windows.Forms.TextBox();
            this.SectionTwoExplain = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Menu;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.Title, 2);
            this.Title.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(580, 41);
            this.Title.TabIndex = 0;
            this.Title.TabStop = false;
            this.Title.Text = "Getting Started - LAGUI Guide";
            // 
            // FirstSection
            // 
            this.FirstSection.BackColor = System.Drawing.SystemColors.Menu;
            this.FirstSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstSection.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstSection.Location = new System.Drawing.Point(3, 51);
            this.FirstSection.Name = "FirstSection";
            this.FirstSection.Size = new System.Drawing.Size(163, 31);
            this.FirstSection.TabIndex = 1;
            this.FirstSection.TabStop = false;
            this.FirstSection.Text = "File Loading";
            // 
            // SectionOneExplain
            // 
            this.SectionOneExplain.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionOneExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionOneExplain, 3);
            this.SectionOneExplain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionOneExplain.Location = new System.Drawing.Point(3, 88);
            this.SectionOneExplain.Multiline = true;
            this.SectionOneExplain.Name = "SectionOneExplain";
            this.SectionOneExplain.Size = new System.Drawing.Size(745, 53);
            this.SectionOneExplain.TabIndex = 2;
            this.SectionOneExplain.TabStop = false;
            this.SectionOneExplain.Text = "Upon importing the CSV from the O-GLAD to the Window\'s machine, loading the file " +
    "onto the LAGUI will be in File -> Open File. The control status should read: \"Re" +
    "ady for data read-in.\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(188, 201);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SectionOneExplain2
            // 
            this.SectionOneExplain2.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionOneExplain2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionOneExplain2, 3);
            this.SectionOneExplain2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionOneExplain2.Location = new System.Drawing.Point(3, 363);
            this.SectionOneExplain2.Multiline = true;
            this.SectionOneExplain2.Name = "SectionOneExplain2";
            this.SectionOneExplain2.Size = new System.Drawing.Size(745, 23);
            this.SectionOneExplain2.TabIndex = 4;
            this.SectionOneExplain2.TabStop = false;
            this.SectionOneExplain2.Text = "Once a file is selected, the control status will change to: \"Data is loaded and r" +
    "eady to plot.\"";
            // 
            // pictureBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox3, 2);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(609, 138);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // SectionTwo
            // 
            this.SectionTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwo.Location = new System.Drawing.Point(3, 536);
            this.SectionTwo.Name = "SectionTwo";
            this.SectionTwo.Size = new System.Drawing.Size(188, 31);
            this.SectionTwo.TabIndex = 7;
            this.SectionTwo.TabStop = false;
            this.SectionTwo.Text = "Data Plotting";
            // 
            // SectionTwoExplain
            // 
            this.SectionTwoExplain.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwoExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionTwoExplain, 3);
            this.SectionTwoExplain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwoExplain.Location = new System.Drawing.Point(3, 577);
            this.SectionTwoExplain.Multiline = true;
            this.SectionTwoExplain.Name = "SectionTwoExplain";
            this.SectionTwoExplain.Size = new System.Drawing.Size(745, 69);
            this.SectionTwoExplain.TabIndex = 8;
            this.SectionTwoExplain.TabStop = false;
            this.SectionTwoExplain.Text = resources.GetString("SectionTwoExplain.Text");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(259, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(437, 188);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38983F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Controls.Add(this.FirstSection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SectionOneExplain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwoExplain, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwo, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.SectionOneExplain2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.50224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.49776F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 743);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(770, 3);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 737);
            this.vScrollBar1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 749);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // pictureBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox4, 3);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 652);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(704, 88);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // GettingStarted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "GettingStarted";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.GettingStarted_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox FirstSection;
        private System.Windows.Forms.TextBox SectionOneExplain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SectionOneExplain2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox SectionTwo;
        private System.Windows.Forms.TextBox SectionTwoExplain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}