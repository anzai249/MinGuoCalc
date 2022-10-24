namespace MinGuoCalc
{
    partial class CalcMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcMain));
            this.ADNumber = new System.Windows.Forms.TextBox();
            this.AD = new System.Windows.Forms.Label();
            this.Convert = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.Minguo = new System.Windows.Forms.Label();
            this.MinguoNumber = new System.Windows.Forms.TextBox();
            this.year1 = new System.Windows.Forms.Label();
            this.year2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADNumber
            // 
            this.ADNumber.Location = new System.Drawing.Point(66, 31);
            this.ADNumber.Name = "ADNumber";
            this.ADNumber.Size = new System.Drawing.Size(105, 23);
            this.ADNumber.TabIndex = 0;
            // 
            // AD
            // 
            this.AD.AutoSize = true;
            this.AD.Location = new System.Drawing.Point(28, 34);
            this.AD.Name = "AD";
            this.AD.Size = new System.Drawing.Size(32, 17);
            this.AD.TabIndex = 1;
            this.AD.Text = "公元";
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(28, 60);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(75, 23);
            this.Convert.TabIndex = 2;
            this.Convert.Text = "转换↓";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(121, 60);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(75, 23);
            this.Reverse.TabIndex = 2;
            this.Reverse.Text = "转换↑";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Minguo
            // 
            this.Minguo.AutoSize = true;
            this.Minguo.Location = new System.Drawing.Point(28, 92);
            this.Minguo.Name = "Minguo";
            this.Minguo.Size = new System.Drawing.Size(32, 17);
            this.Minguo.TabIndex = 4;
            this.Minguo.Text = "民国";
            // 
            // MinguoNumber
            // 
            this.MinguoNumber.Location = new System.Drawing.Point(66, 89);
            this.MinguoNumber.Name = "MinguoNumber";
            this.MinguoNumber.Size = new System.Drawing.Size(105, 23);
            this.MinguoNumber.TabIndex = 3;
            this.MinguoNumber.Enter += new System.EventHandler(this.MinguoNumber_Enter);
            // 
            // year1
            // 
            this.year1.AutoSize = true;
            this.year1.Location = new System.Drawing.Point(177, 34);
            this.year1.Name = "year1";
            this.year1.Size = new System.Drawing.Size(20, 17);
            this.year1.TabIndex = 1;
            this.year1.Text = "年";
            // 
            // year2
            // 
            this.year2.AutoSize = true;
            this.year2.Location = new System.Drawing.Point(177, 92);
            this.year2.Name = "year2";
            this.year2.Size = new System.Drawing.Size(20, 17);
            this.year2.TabIndex = 1;
            this.year2.Text = "年";
            // 
            // CalcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(229, 150);
            this.Controls.Add(this.Minguo);
            this.Controls.Add(this.MinguoNumber);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.year2);
            this.Controls.Add(this.year1);
            this.Controls.Add(this.AD);
            this.Controls.Add(this.ADNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalcMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "民国纪年计算器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ADNumber;
        private Label AD;
        private Button Convert;
        private Button Reverse;
        private Label Minguo;
        private TextBox MinguoNumber;
        private Label year1;
        private Label year2;
    }
}