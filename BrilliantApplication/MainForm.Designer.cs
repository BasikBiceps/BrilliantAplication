﻿namespace BrilliantApplication
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.Name = "ChartArea1";
            this.waterLimitStateChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.waterLimitStateChart.Legends.Add(legend1);
            this.waterLimitStateChart.Location = new System.Drawing.Point(508, 115);
            this.waterLimitStateChart.Name = "waterLimitStateChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Water level";
            this.waterLimitStateChart.Series.Add(series1);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 578);
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
    }
}

