namespace OGLAD_UI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Title = new System.Windows.Forms.TextBox();
            this.SectionTwoExplain = new System.Windows.Forms.TextBox();
            this.SectionTwo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.76289F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.23711F));
            this.tableLayoutPanel1.Controls.Add(this.Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwoExplain, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SectionTwo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.65854F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 488);
            this.tableLayoutPanel1.TabIndex = 11;
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
            // SectionTwoExplain
            // 
            this.SectionTwoExplain.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwoExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.SectionTwoExplain, 2);
            this.SectionTwoExplain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwoExplain.Location = new System.Drawing.Point(3, 87);
            this.SectionTwoExplain.Multiline = true;
            this.SectionTwoExplain.Name = "SectionTwoExplain";
            this.SectionTwoExplain.Size = new System.Drawing.Size(745, 59);
            this.SectionTwoExplain.TabIndex = 8;
            this.SectionTwoExplain.TabStop = false;
            this.SectionTwoExplain.Text = resources.GetString("SectionTwoExplain.Text");
            // 
            // SectionTwo
            // 
            this.SectionTwo.BackColor = System.Drawing.SystemColors.Menu;
            this.SectionTwo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SectionTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTwo.Location = new System.Drawing.Point(3, 47);
            this.SectionTwo.Name = "SectionTwo";
            this.SectionTwo.Size = new System.Drawing.Size(188, 31);
            this.SectionTwo.TabIndex = 7;
            this.SectionTwo.TabStop = false;
            this.SectionTwo.Text = "Exporting Data";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 152);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(517, 48);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Saving current plot as an image: File -> Save Plot\r\nSaving statistical values as " +
    "a text file: Tools -> Export Stat Values";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OGLAD_UI.Properties.Resources.Screenshot_2022_06_07_210929;
            this.pictureBox1.Location = new System.Drawing.Point(3, 206);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 195);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OGLAD_UI.Properties.Resources.Screenshot_2022_06_07_214633;
            this.pictureBox2.Location = new System.Drawing.Point(265, 206);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 180);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox SectionTwoExplain;
        private System.Windows.Forms.TextBox SectionTwo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}