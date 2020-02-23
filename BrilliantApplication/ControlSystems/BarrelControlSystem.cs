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
        private double m_valve = 0;
        public double InputStream { get { return m_inputStream; } set { if (value < 0) m_inputStream = 0; else m_inputStream = value; } }
        public double Valve { get { return m_valve; } set { if (value > 1) m_valve = 1; else if (value < 0) m_valve = 0; else m_valve = value; } }
        public double WaterLevel { get; set; }
        public double WaterLevelLimit { get; set; }
        public double OutputStreamLimit { get; set; }
        public double OutputStream { get; set; }

        public BarrelControlSystem(double waterLevelLimit, double dt, double outputStreamLimit) : base() 
        {
            DT = dt;
            WaterLevelLimit = waterLevelLimit;
            OutputStreamLimit = outputStreamLimit;
            InputStream = 0;
            Valve = 0;

            var blocks = new Queue<IBlock>();
            blocks.Enqueue(new AperiodicBlock(dt, 10));
            Object = new ComplexBlock(blocks);
        }

        public double GetInputStream()
        {
            return InputStream * Valve;
        }

        public double CalculateWaterLevel()
        {
            var result = Object.Calculate(GetInputStream());

            if (result > OutputStreamLimit)
            {
                OutputStream = OutputStreamLimit;
                WaterLevel = result - OutputStreamLimit;
            }
            else
            {
                WaterLevel = 0;
                OutputStream = result;
            }

            if (WaterLevel > WaterLevelLimit)
            {
                WaterLevel = WaterLevelLimit;
            }
            Time += DT;

            return result;
        }

        public void RefreshSystem()
        {
            WaterLevel = 0;
            Time = 0;
            OutputStream = 0;

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
