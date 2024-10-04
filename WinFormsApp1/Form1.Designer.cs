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
            labelChooseFunction = new Label();
            radioButtonOR = new RadioButton();
            radioButtonAND = new RadioButton();
            groupBox1 = new GroupBox();
            labelFunctionGraphics = new Label();
            labelClassification = new Label();
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
            chartArea1.Name = "ChartArea1";
            graphic.ChartAreas.Add(chartArea1);
            graphic.Location = new Point(12, 209);
            graphic.Margin = new Padding(3, 4, 3, 4);
            graphic.Name = "graphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            graphic.Series.Add(series1);
            graphic.Size = new Size(664, 460);
            graphic.TabIndex = 2;
            graphic.Text = "chart1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(682, 27);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(491, 642);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // labelChooseFunction
            // 
            labelChooseFunction.AutoSize = true;
            labelChooseFunction.ForeColor = SystemColors.WindowText;
            labelChooseFunction.Location = new Point(0, 3);
            labelChooseFunction.Name = "labelChooseFunction";
            labelChooseFunction.Size = new Size(129, 20);
            labelChooseFunction.TabIndex = 6;
            labelChooseFunction.Text = "Оберіть функцію:";
            labelChooseFunction.Click += label1_Click_1;
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
            groupBox1.Controls.Add(labelChooseFunction);
            groupBox1.Controls.Add(radioButtonAND);
            groupBox1.Controls.Add(radioButtonOR);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 170);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            // 
            // labelFunctionGraphics
            // 
            labelFunctionGraphics.AutoSize = true;
            labelFunctionGraphics.Enabled = false;
            labelFunctionGraphics.Location = new Point(12, 185);
            labelFunctionGraphics.Name = "labelFunctionGraphics";
            labelFunctionGraphics.Size = new Size(111, 20);
            labelFunctionGraphics.TabIndex = 10;
            labelFunctionGraphics.Text = "Графік функції:";
            labelFunctionGraphics.Click += labelFunctionGraphics_Click;
            // 
            // labelClassification
            // 
            labelClassification.AutoSize = true;
            labelClassification.Location = new Point(682, 4);
            labelClassification.Name = "labelClassification";
            labelClassification.Size = new Size(146, 20);
            labelClassification.TabIndex = 11;
            labelClassification.Text = "Класифікація точок:";
            labelClassification.Click += labelClassification_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 682);
            Controls.Add(labelClassification);
            Controls.Add(labelFunctionGraphics);
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
            PerformLayout();
        }

        #endregion
        private Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphic;
        private RichTextBox richTextBox1;
        private Label labelChooseFunction;
        private RadioButton radioButtonOR;
        private RadioButton radioButtonAND;
        private GroupBox groupBox1;
        private Label labelFunctionGraphics;
        private Label labelClassification;
    }
}