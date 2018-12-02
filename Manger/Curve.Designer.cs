namespace Manger
{
    partial class Curve
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.radDust = new System.Windows.Forms.RadioButton();
            this.radNose = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // radDust
            // 
            this.radDust.AutoSize = true;
            this.radDust.Location = new System.Drawing.Point(384, 12);
            this.radDust.Name = "radDust";
            this.radDust.Size = new System.Drawing.Size(47, 16);
            this.radDust.TabIndex = 1;
            this.radDust.TabStop = true;
            this.radDust.Text = "粉尘";
            this.radDust.UseVisualStyleBackColor = true;
            this.radDust.Click += new System.EventHandler(this.radDust_Click_1);
            // 
            // radNose
            // 
            this.radNose.AutoSize = true;
            this.radNose.Location = new System.Drawing.Point(516, 12);
            this.radNose.Name = "radNose";
            this.radNose.Size = new System.Drawing.Size(47, 16);
            this.radNose.TabIndex = 2;
            this.radNose.TabStop = true;
            this.radNose.Text = "噪音";
            this.radNose.UseVisualStyleBackColor = true;
            this.radNose.Click += new System.EventHandler(this.radNose_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(921, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(66, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 57);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(922, 436);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // Curve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 505);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.radNose);
            this.Controls.Add(this.radDust);
            this.Controls.Add(this.chart1);
            this.Name = "Curve";
            this.Text = "Curve";
            this.Load += new System.EventHandler(this.Curve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radDust;
        private System.Windows.Forms.RadioButton radNose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}