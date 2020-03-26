using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BrilliantApplication.ControlSystems;

namespace BrilliantApplication.Regulators
{
    public class Regulator
    {
        public double m_regulatorTask = 0;
        public double m_prevWaterLevel = 0;

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

        public Regulator(double regulatorTask = 0)
        {
            RegulatorTask = regulatorTask;
        }

        public double Regulate(double waterLevel)
        {
            var kef = RegulatorTask / waterLevel;

            if (waterLevel > RegulatorTask)
            {
                return SystemSettings.OutputStream * kef;
            }
            else if (waterLevel < RegulatorTask)
            {
                return SystemSettings.OutputStream * kef;
            }
            else
            {
                return SystemSettings.OutputStream;
            }
        }
    }
}
