using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlocksLibrary.Blocks;
using BlocksLibrary.Interfaces;

namespace BrilliantApplication.ControlSystems
{
    public class BarrelControlSystem : ObjectControlSystem
    {
        private double m_inputStream = 0;
        //private double m_valve = 0;
        public double InputStream { get { return m_inputStream; } 
            set { if (value < 0) m_inputStream = 0;
                else if (value > SystemSettings.MaxInputStream) m_inputStream = SystemSettings.MaxInputStream;
                else m_inputStream = value; } }
        //public double Valve { get { return m_valve; } set { if (value > 1) m_valve = 1; else if (value < 0) m_valve = 0; else m_valve = value; } }
        public double WaterLevel { get; set; }
        public double WaterLevelLimit { get; set; }

        public BarrelControlSystem(double dt) : base() 
        {
            DT = dt;
            WaterLevelLimit = SystemSettings.WaterLevelLimit;
            InputStream = 0;
            //Valve = 0;

            var blocks = new Queue<IBlock>();
            //TODO add Delay and Interference blocks!!! 
            blocks.Enqueue(new AperiodicBlock(dt, SystemSettings.T));
            blocks.Enqueue(new GainBlock(SystemSettings.Gain));
            Object = new ComplexBlock(blocks);
        }

        public double CalculateWaterLevel()
        {
            WaterLevel = Object.Calculate(InputStream);

            if (WaterLevel > WaterLevelLimit)
            {
                WaterLevel = WaterLevelLimit;
            }
            Time += DT;

            return WaterLevel;
        }

        public void RefreshSystem()
        {
            WaterLevel = 0;
            Time = 0;

            foreach(var block in Object.Blocks)
            {
                var temp = block as IRefreshable;
                if (temp != null)
                {
                    temp.Refresh();
                }
            }
        }
    }
}
