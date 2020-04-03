namespace BrilliantApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.waterLimitStateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.reduceInputStreamButton = new System.Windows.Forms.Button();
            this.increaseInputStreamButton = new System.Windows.Forms.Button();
            this.preasureLabel = new System.Windows.Forms.Label();
            this.helpInputStreamLabel = new System.Windows.Forms.Label();
            this.helpWaterLavelLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.x10Button = new System.Windows.Forms.Button();
            this.x1Button = new System.Windows.Forms.Button();
            this.objectPictureBox = new System.Windows.Forms.PictureBox();
            this.manualControlButton = new System.Windows.Forms.Button();
            this.automaticControlButton = new System.Windows.Forms.Button();
            this.regulatorTaskTextBox = new System.Windows.Forms.TextBox();
            this.regulatorTaskHelpLabel = new System.Windows.Forms.Label();
            this.currentRegulatorHelpLabel = new System.Windows.Forms.Label();
            this.currentRegulatorTaskLabel = new System.Windows.Forms.Label();
            this.sendRegulatorTaskButton = new System.Windows.Forms.Button();
            this.workStateLabel = new System.Windows.Forms.Label();
            this.kHelpLabel = new System.Windows.Forms.Label();
            this.kiHelpLabel = new System.Windows.Forms.Label();
            this.kdHelpLabel = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.kiTextBox = new System.Windows.Forms.TextBox();
            this.kdTextBox = new System.Windows.Forms.TextBox();
            this.sendSettingsButton = new System.Windows.Forms.Button();
            this.currentRegulatorSettingsHelpLabel = new System.Windows.Forms.Label();
            this.kLabel = new System.Windows.Forms.Label();
            this.kiLabel = new System.Windows.Forms.Label();
            this.kdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waterLimitStateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // waterLimitStateChart
            // 
            chartArea2.Name = "ChartArea1";
            this.waterLimitStateChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.waterLimitStateChart.Legends.Add(legend2);
            this.waterLimitStateChart.Location = new System.Drawing.Point(508, 115);
            this.waterLimitStateChart.Name = "waterLimitStateChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Water level";
            this.waterLimitStateChart.Series.Add(series2);
            this.waterLimitStateChart.Size = new System.Drawing.Size(475, 268);
            this.waterLimitStateChart.TabIndex = 1;
            this.waterLimitStateChart.Text = "chart1";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(287, 274);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(13, 13);
            this.waterLevelLabel.TabIndex = 6;
            this.waterLevelLabel.Text = "0";
            // 
            // reduceInputStreamButton
            // 
            this.reduceInputStreamButton.Location = new System.Drawing.Point(37, 44);
            this.reduceInputStreamButton.Name = "reduceInputStreamButton";
            this.reduceInputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.reduceInputStreamButton.TabIndex = 8;
            this.reduceInputStreamButton.Text = "<";
            this.reduceInputStreamButton.UseVisualStyleBackColor = true;
            this.reduceInputStreamButton.Click += new System.EventHandler(this.reducePreasureButton_Click);
            // 
            // increaseInputStreamButton
            // 
            this.increaseInputStreamButton.Location = new System.Drawing.Point(122, 44);
            this.increaseInputStreamButton.Name = "increaseInputStreamButton";
            this.increaseInputStreamButton.Size = new System.Drawing.Size(31, 23);
            this.increaseInputStreamButton.TabIndex = 9;
            this.increaseInputStreamButton.Text = ">";
            this.increaseInputStreamButton.UseVisualStyleBackColor = true;
            this.increaseInputStreamButton.Click += new System.EventHandler(this.increasePreasureButton_Click);
            // 
            // preasureLabel
            // 
            this.preasureLabel.AutoSize = true;
            this.preasureLabel.Location = new System.Drawing.Point(88, 49);
            this.preasureLabel.Name = "preasureLabel";
            this.preasureLabel.Size = new System.Drawing.Size(13, 13);
            this.preasureLabel.TabIndex = 10;
            this.preasureLabel.Text = "0";
            // 
            // helpInputStreamLabel
            // 
            this.helpInputStreamLabel.AutoSize = true;
            this.helpInputStreamLabel.Location = new System.Drawing.Point(34, 28);
            this.helpInputStreamLabel.Name = "helpInputStreamLabel";
            this.helpInputStreamLabel.Size = new System.Drawing.Size(68, 13);
            this.helpInputStreamLabel.TabIndex = 11;
            this.helpInputStreamLabel.Text = "Input stream:";
            // 
            // helpWaterLavelLabel
            // 
            this.helpWaterLavelLabel.AutoSize = true;
            this.helpWaterLavelLabel.Location = new System.Drawing.Point(264, 245);
            this.helpWaterLavelLabel.Name = "helpWaterLavelLabel";
            this.helpWaterLavelLabel.Size = new System.Drawing.Size(64, 13);
            this.helpWaterLavelLabel.TabIndex = 12;
            this.helpWaterLavelLabel.Text = "Water level:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(37, 409);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 16;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(118, 409);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 17;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(199, 409);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 18;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // x10Button
            // 
            this.x10Button.Location = new System.Drawing.Point(37, 486);
            this.x10Button.Name = "x10Button";
            this.x10Button.Size = new System.Drawing.Size(75, 23);
            this.x10Button.TabIndex = 19;
            this.x10Button.Text = "+ x10";
            this.x10Button.UseVisualStyleBackColor = true;
            this.x10Button.Click += new System.EventHandler(this.x10Button_Click);
            // 
            // x1Button
            // 
            this.x1Button.Location = new System.Drawing.Point(199, 486);
            this.x1Button.Name = "x1Button";
            this.x1Button.Size = new System.Drawing.Size(75, 23);
            this.x1Button.TabIndex = 21;
            this.x1Button.Text = "x1";
            this.x1Button.UseVisualStyleBackColor = true;
            this.x1Button.Click += new System.EventHandler(this.x1Button_Click);
            // 
            // objectPictureBox
            // 
            this.objectPictureBox.Image = global::BrilliantApplication.Properties.Resources.Boiler;
            this.objectPictureBox.Location = new System.Drawing.Point(25, 115);
            this.objectPictureBox.Name = "objectPictureBox";
            this.objectPictureBox.Size = new System.Drawing.Size(352, 268);
            this.objectPictureBox.TabIndex = 0;
            this.objectPictureBox.TabStop = false;
            // 
            // manualControlButton
            // 
            this.manualControlButton.Location = new System.Drawing.Point(232, 44);
            this.manualControlButton.Name = "manualControlButton";
            this.manualControlButton.Size = new System.Drawing.Size(133, 22);
            this.manualControlButton.TabIndex = 22;
            this.manualControlButton.Text = "Manual control";
            this.manualControlButton.UseVisualStyleBackColor = true;
            this.manualControlButton.Click += new System.EventHandler(this.manualControlButton_Click);
            // 
            // automaticControlButton
            // 
            this.automaticControlButton.Location = new System.Drawing.Point(232, 86);
            this.automaticControlButton.Name = "automaticControlButton";
            this.automaticControlButton.Size = new System.Drawing.Size(133, 23);
            this.automaticControlButton.TabIndex = 23;
            this.automaticControlButton.Text = "Automatic control";
            this.automaticControlButton.UseVisualStyleBackColor = true;
            this.automaticControlButton.Click += new System.EventHandler(this.automaticControlButton_Click);
            // 
            // regulatorTaskTextBox
            // 
            this.regulatorTaskTextBox.Location = new System.Drawing.Point(430, 48);
            this.regulatorTaskTextBox.Name = "regulatorTaskTextBox";
            this.regulatorTaskTextBox.Size = new System.Drawing.Size(100, 20);
            this.regulatorTaskTextBox.TabIndex = 24;
            this.regulatorTaskTextBox.Text = "0";
            // 
            // regulatorTaskHelpLabel
            // 
            this.regulatorTaskHelpLabel.AutoSize = true;
            this.regulatorTaskHelpLabel.Location = new System.Drawing.Point(430, 28);
            this.regulatorTaskHelpLabel.Name = "regulatorTaskHelpLabel";
            this.regulatorTaskHelpLabel.Size = new System.Drawing.Size(79, 13);
            this.regulatorTaskHelpLabel.TabIndex = 25;
            this.regulatorTaskHelpLabel.Text = "Regulator task:";
            // 
            // currentRegulatorHelpLabel
            // 
            this.currentRegulatorHelpLabel.AutoSize = true;
            this.currentRegulatorHelpLabel.Location = new System.Drawing.Point(430, 86);
            this.currentRegulatorHelpLabel.Name = "currentRegulatorHelpLabel";
            this.currentRegulatorHelpLabel.Size = new System.Drawing.Size(111, 13);
            this.currentRegulatorHelpLabel.TabIndex = 26;
            this.currentRegulatorHelpLabel.Text = "Current regulator task:";
            // 
            // currentRegulatorTaskLabel
            // 
            this.currentRegulatorTaskLabel.AutoSize = true;
            this.currentRegulatorTaskLabel.Location = new System.Drawing.Point(547, 86);
            this.currentRegulatorTaskLabel.Name = "currentRegulatorTaskLabel";
            this.currentRegulatorTaskLabel.Size = new System.Drawing.Size(13, 13);
            this.currentRegulatorTaskLabel.TabIndex = 27;
            this.currentRegulatorTaskLabel.Text = "0";
            // 
            // sendRegulatorTaskButton
            // 
            this.sendRegulatorTaskButton.Location = new System.Drawing.Point(550, 46);
            this.sendRegulatorTaskButton.Name = "sendRegulatorTaskButton";
            this.sendRegulatorTaskButton.Size = new System.Drawing.Size(75, 23);
            this.sendRegulatorTaskButton.TabIndex = 28;
            this.sendRegulatorTaskButton.Text = "Send task";
            this.sendRegulatorTaskButton.UseVisualStyleBackColor = true;
            this.sendRegulatorTaskButton.Click += new System.EventHandler(this.sendRegulatorTaskButton_Click);
            // 
            // workStateLabel
            // 
            this.workStateLabel.AutoSize = true;
            this.workStateLabel.Location = new System.Drawing.Point(264, 18);
            this.workStateLabel.Name = "workStateLabel";
            this.workStateLabel.Size = new System.Drawing.Size(42, 13);
            this.workStateLabel.TabIndex = 29;
            this.workStateLabel.Text = "Manual";
            // 
            // kHelpLabel
            // 
            this.kHelpLabel.AutoSize = true;
            this.kHelpLabel.Location = new System.Drawing.Point(693, 29);
            this.kHelpLabel.Name = "kHelpLabel";
            this.kHelpLabel.Size = new System.Drawing.Size(17, 13);
            this.kHelpLabel.TabIndex = 30;
            this.kHelpLabel.Text = "K:";
            // 
            // kiHelpLabel
            // 
            this.kiHelpLabel.AutoSize = true;
            this.kiHelpLabel.Location = new System.Drawing.Point(691, 51);
            this.kiHelpLabel.Name = "kiHelpLabel";
            this.kiHelpLabel.Size = new System.Drawing.Size(19, 13);
            this.kiHelpLabel.TabIndex = 31;
            this.kiHelpLabel.Text = "Ki:";
            // 
            // kdHelpLabel
            // 
            this.kdHelpLabel.AutoSize = true;
            this.kdHelpLabel.Location = new System.Drawing.Point(687, 72);
            this.kdHelpLabel.Name = "kdHelpLabel";
            this.kdHelpLabel.Size = new System.Drawing.Size(23, 13);
            this.kdHelpLabel.TabIndex = 32;
            this.kdHelpLabel.Text = "Kd:";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(716, 26);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(58, 20);
            this.kTextBox.TabIndex = 33;
            this.kTextBox.Text = "0";
            // 
            // kiTextBox
            // 
            this.kiTextBox.Location = new System.Drawing.Point(716, 48);
            this.kiTextBox.Name = "kiTextBox";
            this.kiTextBox.Size = new System.Drawing.Size(58, 20);
            this.kiTextBox.TabIndex = 34;
            this.kiTextBox.Text = "0";
            // 
            // kdTextBox
            // 
            this.kdTextBox.Location = new System.Drawing.Point(716, 69);
            this.kdTextBox.Name = "kdTextBox";
            this.kdTextBox.Size = new System.Drawing.Size(58, 20);
            this.kdTextBox.TabIndex = 35;
            this.kdTextBox.Text = "0";
            // 
            // sendSettingsButton
            // 
            this.sendSettingsButton.Location = new System.Drawing.Point(690, 91);
            this.sendSettingsButton.Name = "sendSettingsButton";
            this.sendSettingsButton.Size = new System.Drawing.Size(84, 23);
            this.sendSettingsButton.TabIndex = 36;
            this.sendSettingsButton.Text = "Send settings";
            this.sendSettingsButton.UseVisualStyleBackColor = true;
            this.sendSettingsButton.Click += new System.EventHandler(this.sendSettingsButton_Click);
            // 
            // currentRegulatorSettingsHelpLabel
            // 
            this.currentRegulatorSettingsHelpLabel.AutoSize = true;
            this.currentRegulatorSettingsHelpLabel.Location = new System.Drawing.Point(781, 9);
            this.currentRegulatorSettingsHelpLabel.Name = "currentRegulatorSettingsHelpLabel";
            this.currentRegulatorSettingsHelpLabel.Size = new System.Drawing.Size(127, 13);
            this.currentRegulatorSettingsHelpLabel.TabIndex = 37;
            this.currentRegulatorSettingsHelpLabel.Text = "Current regulator settings:";
            // 
            // kLabel
            // 
            this.kLabel.AutoSize = true;
            this.kLabel.Location = new System.Drawing.Point(780, 29);
            this.kLabel.Name = "kLabel";
            this.kLabel.Size = new System.Drawing.Size(13, 13);
            this.kLabel.TabIndex = 38;
            this.kLabel.Text = "0";
            // 
            // kiLabel
            // 
            this.kiLabel.AutoSize = true;
            this.kiLabel.Location = new System.Drawing.Point(780, 51);
            this.kiLabel.Name = "kiLabel";
            this.kiLabel.Size = new System.Drawing.Size(13, 13);
            this.kiLabel.TabIndex = 39;
            this.kiLabel.Text = "0";
            // 
            // kdLabel
            // 
            this.kdLabel.AutoSize = true;
            this.kdLabel.Location = new System.Drawing.Point(780, 72);
            this.kdLabel.Name = "kdLabel";
            this.kdLabel.Size = new System.Drawing.Size(13, 13);
            this.kdLabel.TabIndex = 40;
            this.kdLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 578);
            this.Controls.Add(this.kdLabel);
            this.Controls.Add(this.kiLabel);
            this.Controls.Add(this.kLabel);
            this.Controls.Add(this.currentRegulatorSettingsHelpLabel);
            this.Controls.Add(this.sendSettingsButton);
            this.Controls.Add(this.kdTextBox);
            this.Controls.Add(this.kiTextBox);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.kdHelpLabel);
            this.Controls.Add(this.kiHelpLabel);
            this.Controls.Add(this.kHelpLabel);
            this.Controls.Add(this.workStateLabel);
            this.Controls.Add(this.sendRegulatorTaskButton);
            this.Controls.Add(this.currentRegulatorTaskLabel);
            this.Controls.Add(this.currentRegulatorHelpLabel);
            this.Controls.Add(this.regulatorTaskHelpLabel);
            this.Controls.Add(this.regulatorTaskTextBox);
            this.Controls.Add(this.automaticControlButton);
            this.Controls.Add(this.manualControlButton);
            this.Controls.Add(this.x1Button);
            this.Controls.Add(this.x10Button);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.helpWaterLavelLabel);
            this.Controls.Add(this.helpInputStreamLabel);
            this.Controls.Add(this.preasureLabel);
            this.Controls.Add(this.increaseInputStreamButton);
            this.Controls.Add(this.reduceInputStreamButton);
            this.Controls.Add(this.waterLevelLabel);
            this.Controls.Add(this.waterLimitStateChart);
            this.Controls.Add(this.objectPictureBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.waterLimitStateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox objectPictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart waterLimitStateChart;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Button reduceInputStreamButton;
        private System.Windows.Forms.Button increaseInputStreamButton;
        private System.Windows.Forms.Label preasureLabel;
        private System.Windows.Forms.Label helpInputStreamLabel;
        private System.Windows.Forms.Label helpWaterLavelLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button x10Button;
        private System.Windows.Forms.Button x1Button;
        private System.Windows.Forms.Button manualControlButton;
        private System.Windows.Forms.Button automaticControlButton;
        private System.Windows.Forms.TextBox regulatorTaskTextBox;
        private System.Windows.Forms.Label regulatorTaskHelpLabel;
        private System.Windows.Forms.Label currentRegulatorHelpLabel;
        private System.Windows.Forms.Label currentRegulatorTaskLabel;
        private System.Windows.Forms.Button sendRegulatorTaskButton;
        private System.Windows.Forms.Label workStateLabel;
        private System.Windows.Forms.Label kHelpLabel;
        private System.Windows.Forms.Label kiHelpLabel;
        private System.Windows.Forms.Label kdHelpLabel;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.TextBox kiTextBox;
        private System.Windows.Forms.TextBox kdTextBox;
        private System.Windows.Forms.Button sendSettingsButton;
        private System.Windows.Forms.Label currentRegulatorSettingsHelpLabel;
        private System.Windows.Forms.Label kLabel;
        private System.Windows.Forms.Label kiLabel;
        private System.Windows.Forms.Label kdLabel;
    }
}

