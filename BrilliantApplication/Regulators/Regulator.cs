﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BrilliantApplication.ControlSystems;
using BlocksLibrary.Blocks;

namespace BrilliantApplication.Regulators
{
    public class Regulator
    {
        private GainBlock m_gainBlock;
        private IntegralBlock m_integralBlock;
        private DifferentialBlock m_diffBlock;
        private double m_regulatorTask = 0;
        private double m_Ki = 0;

        public double Ki { get { return m_Ki; } set { m_Ki = value; } }
        public double K { get { return m_gainBlock.Gain; } set { m_gainBlock.Gain = value; } }
        public double Ti { get { return 1 / m_Ki; } set { m_Ki = 1 / value; } }
        public double Kd { get; set; }

        public Regulator(double dt, double K = 0, double Ki = 0, double Kd = 0)
        {
            m_gainBlock = new GainBlock(K);
            m_integralBlock = new IntegralBlock(dt);
            m_diffBlock = new DifferentialBlock(dt);

            this.K = K;
            this.Ki = Ki;
            this.Kd = Kd;
        }

        public double RegulatorTask
        {
            get { return m_regulatorTask; }
            set
            {
                if (value > SystemSettings.WaterLevelLimit)
                {
                    m_regulatorTask = SystemSettings.WaterLevelLimit;
                }
                else if (value < 0)
                {
                    m_regulatorTask = 0;
                }
                else
                {
                    m_regulatorTask = value;
                }
            }
        }

        public double Regulate(double x)
        {
            return m_gainBlock.Calculate(x+Ki*m_integralBlock.Calculate(x)+Kd*m_diffBlock.Calculate(x));
        }
    }
}
