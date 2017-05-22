namespace QueuingSystem {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.roTextBox = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.periodTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.muTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.R1TextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.R2TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "m";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ρ max";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(75, 104);
            this.mTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(66, 24);
            this.mTextBox.TabIndex = 3;
            this.mTextBox.Text = "0";
            // 
            // roTextBox
            // 
            this.roTextBox.Location = new System.Drawing.Point(75, 40);
            this.roTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roTextBox.Name = "roTextBox";
            this.roTextBox.Size = new System.Drawing.Size(66, 24);
            this.roTextBox.TabIndex = 4;
            this.roTextBox.Text = "5";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(23, 397);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(118, 44);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Поехали";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // periodTextBox
            // 
            this.periodTextBox.Location = new System.Drawing.Point(75, 136);
            this.periodTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.periodTextBox.Name = "periodTextBox";
            this.periodTextBox.Size = new System.Drawing.Size(66, 24);
            this.periodTextBox.TabIndex = 7;
            this.periodTextBox.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "L";
            // 
            // muTextBox
            // 
            this.muTextBox.Location = new System.Drawing.Point(75, 72);
            this.muTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.muTextBox.Name = "muTextBox";
            this.muTextBox.Size = new System.Drawing.Size(66, 24);
            this.muTextBox.TabIndex = 9;
            this.muTextBox.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "μ";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(75, 168);
            this.nTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(66, 24);
            this.nTextBox.TabIndex = 11;
            this.nTextBox.Text = "5000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "n";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(75, 201);
            this.stepTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(66, 24);
            this.stepTextBox.TabIndex = 13;
            this.stepTextBox.Text = "0,1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 204);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шаг λ";
            // 
            // R1TextBox
            // 
            this.R1TextBox.Location = new System.Drawing.Point(71, 333);
            this.R1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.R1TextBox.Name = "R1TextBox";
            this.R1TextBox.Size = new System.Drawing.Size(66, 24);
            this.R1TextBox.TabIndex = 16;
            this.R1TextBox.Text = "15";
            this.R1TextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 336);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "R1 =";
            this.label7.Visible = false;
            // 
            // R2TextBox
            // 
            this.R2TextBox.Location = new System.Drawing.Point(71, 365);
            this.R2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.R2TextBox.Name = "R2TextBox";
            this.R2TextBox.Size = new System.Drawing.Size(66, 24);
            this.R2TextBox.TabIndex = 18;
            this.R2TextBox.Text = "25";
            this.R2TextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 368);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "R2 =";
            this.label8.Visible = false;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(181, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Теория";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series17.Legend = "Legend1";
            series17.Name = "Эксперимент";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Отклонение";
            this.chart1.Series.Add(series16);
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Size = new System.Drawing.Size(381, 448);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 232);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(109, 22);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "M / M / 1 / m";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 258);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 22);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.Text = "Er1 / M / 1 / m";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 286);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(119, 22);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.Text = "M / Er2 / 1 / m";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 311);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(129, 22);
            this.radioButton4.TabIndex = 24;
            this.radioButton4.Text = "Er1 / Er2 / 1 / m";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 448);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.R2TextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.R1TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stepTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.muTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.periodTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.roTextBox);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Система массового обслуживания";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox roTextBox;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.TextBox periodTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox muTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox R1TextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox R2TextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

