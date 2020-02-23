using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BrilliantApplication.ControlSystems;
using BlocksLibrary.Blocks;
using BlocksLibrary.Interfaces;

namespace BrilliantApplication
{
    public partial class MainForm : Form
    {
        private BarrelControlSystem m_controlSystem;
        private const double m_k_dt = 1;
        private double m_valveStep = 0.1;
        private double m_preasureStep = 1;
        private int m_roundCof = 5;
        private int m_startPictureLocation;

        public MainForm()
        {
            InitializeComponent();
            m_startPictureLocation = waterPictureBox.Location.Y;

            m_controlSystem = new BarrelControlSystem(100, m_k_dt, 2);
        }

        private void reduceValveButton_Click(object sender, EventArgs e)
        {
            m_controlSystem.Valve -= m_valveStep;
            valveCoefficientLabel.Text = Math.Round(m_controlSystem.Valve, m_roundCof).ToString();
        }

        private void increaseValveButton_Click(object sender, EventArgs e)
        {
            m_controlSystem.Valve += m_valveStep;
            valveCoefficientLabel.Text = Math.Round(m_controlSystem.Valve, m_roundCof).ToString();
        }

        private void reducePreasureButton_Click(object sender, EventArgs e)
        {
            m_controlSystem.InputStream -= m_preasureStep;
            preasureLabel.Text = Math.Round(m_controlSystem.InputStream, m_roundCof).ToString();
        }

        private void increasePreasureButton_Click(object sender, EventArgs e)
        {
            m_controlSystem.InputStream += m_preasureStep;
            preasureLabel.Text = Math.Round(m_controlSystem.InputStream, m_roundCof).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m_controlSystem.CalculateWaterLevel();

            waterLevelLabel.Text = Math.Round(m_controlSystem.WaterLevel, m_roundCof).ToString();
            outputStreamLabel.Text = Math.Round(m_controlSystem.OutputStream, m_roundCof).ToString();

            waterLimitStateChart.Series[0].Points.AddXY(m_controlSystem.Time, m_controlSystem.WaterLevel);
            outputStreamStateChart.Series[0].Points.AddXY(m_controlSystem.Time, m_controlSystem.OutputStream);

            var waterPictureBoxLocation = waterPictureBox.Location;
            waterPictureBoxLocation.Y = m_startPictureLocation - Convert.ToInt32(Math.Round(m_controlSystem.WaterLevel, m_roundCof)*1.4);
            waterPictureBox.Location = waterPictureBoxLocation;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            m_controlSystem.RefreshSystem();
            outputStreamLabel.Text = "0";
            waterLevelLabel.Text = "0";

            foreach (var series in waterLimitStateChart.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in outputStreamStateChart.Series)
            {
                series.Points.Clear();
            }
        }

        private void x10Button_Click(object sender, EventArgs e)
        {
            timer1.Interval /= 10;
        }

        private void x1Button_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }
    }
}
