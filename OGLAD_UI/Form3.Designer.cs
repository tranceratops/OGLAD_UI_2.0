namespace OGLAD_UI
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SectionTwo = new System.Windows.Forms.TextBox();
            this.SectionTwoExplain = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.61017F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.38983F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwoExplain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 435F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 610);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // SectionTwo
            // 
            this.SectionTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionTwo, 2);
            this.SectionTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwo.Location = new System.Drawing.Point(3, 48);
            this.SectionTwo.Name = "SectionTwo";
            this.SectionTwo.Size = new System.Drawing.Size(343, 31);
            this.SectionTwo.TabIndex = 7;
            this.SectionTwo.TabStop = false;
            this.SectionTwo.Text = "Interacting with Data";
            // 
            // SectionTwoExplain
            // 
            this.SectionTwoExplain.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwoExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionTwoExplain, 3);
            this.SectionTwoExplain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwoExplain.Location = new System.Drawing.Point(3, 85);
            this.SectionTwoExplain.Multiline = true;
            this.SectionTwoExplain.Name = "SectionTwoExplain";
            this.SectionTwoExplain.Size = new System.Drawing.Size(745, 87);
            this.SectionTwoExplain.TabIndex = 8;
            this.SectionTwoExplain.TabStop = false;
            this.SectionTwoExplain.Text = resources.GetString("SectionTwoExplain.Text");
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
            // pictureBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox4, 3);
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 178);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(606, 301);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "LAGUI Guide - Interacting with Data";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox SectionTwoExplain;
        private System.Windows.Forms.TextBox SectionTwo;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}