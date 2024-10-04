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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button1 = new Button();
            graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            radioButtonOR = new RadioButton();
            radioButtonAND = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)graphic).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(6, 96);
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
            chartArea2.Name = "ChartArea1";
            graphic.ChartAreas.Add(chartArea2);
            graphic.Location = new Point(12, 209);
            graphic.Margin = new Padding(3, 4, 3, 4);
            graphic.Name = "graphic";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            graphic.Series.Add(series2);
            graphic.Size = new Size(664, 460);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 6;
            label1.Text = "Оберіть функцію";
            label1.Click += label1_Click_1;
            // 
            // radioButtonOR
            // 
            radioButtonOR.AutoSize = true;
            radioButtonOR.Checked = true;
            radioButtonOR.Location = new Point(6, 26);
            radioButtonOR.Name = "radioButtonOR";
            radioButtonOR.Size = new Size(50, 24);
            radioButtonOR.TabIndex = 7;
            radioButtonOR.TabStop = true;
            radioButtonOR.Text = "OR";
            radioButtonOR.UseVisualStyleBackColor = true;
            radioButtonOR.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButtonAND
            // 
            radioButtonAND.AutoSize = true;
            radioButtonAND.Location = new Point(6, 56);
            radioButtonAND.Name = "radioButtonAND";
            radioButtonAND.Size = new Size(62, 24);
            radioButtonAND.TabIndex = 8;
            radioButtonAND.Text = "AND";
            radioButtonAND.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButtonAND);
            groupBox1.Controls.Add(radioButtonOR);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 186);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 682);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Controls.Add(graphic);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "OR";
            ((System.ComponentModel.ISupportInitialize)graphic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private RichTextBox richTextBox1;
        private Label label1;
        private RadioButton radioButtonOR;
        private RadioButton radioButtonAND;
        private GroupBox groupBox1;
    }
}