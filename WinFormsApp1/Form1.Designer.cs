namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)graphic).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(208, 539);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(236, 65);
            button1.TabIndex = 1;
            button1.Text = "Класифікувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // graphic
            // 
            chartArea1.Name = "ChartArea1";
            graphic.ChartAreas.Add(chartArea1);
            graphic.Location = new Point(12, 45);
            graphic.Margin = new Padding(3, 4, 3, 4);
            graphic.Name = "graphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            graphic.Series.Add(series1);
            graphic.Size = new Size(664, 415);
            graphic.TabIndex = 2;
            graphic.Text = "chart1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(684, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(489, 658);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 682);
            Controls.Add(richTextBox1);
            Controls.Add(graphic);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)graphic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private RichTextBox richTextBox1;
    }
}