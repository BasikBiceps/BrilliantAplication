using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BlocksLibrary.Blocks;
using BlocksLibrary.Interfaces;
using BrilliantApplication.Regulators;

namespace BrilliantApplication.ControlSystems
{
    public enum WorkMode
    { 
        Manual,
        Automatic
    }

    public class BarrelControlSystem : ObjectControlSystem
    {
        private double m_inputStream = 0;
        public double m_regulatorTask = 0;
        public double InputStream
        {
            get { return m_inputStream; }
            set
            {
                if (value < 0)
                {
                    m_inputStream = 0;
                }
                else if (value > SystemSettings.MaxInputStream)
                {
                    m_inputStream = SystemSettings.MaxInputStream;
                }
                else
                {
                    m_inputStream = value;
                }
            }
        }
        public double WaterLevel { get; set; }
        public GainBlock InputStreamBlock { get; set; }
        public WorkMode WorkMode { get; set; } = WorkMode.Manual;
        public Regulator Regulator { get; set; }

        public BarrelControlSystem(double dt) : base() 
        {
            DT = dt;
            InputStream = 0;

            InputStreamBlock = new GainBlock(SystemSettings.Gain);

            var blocks = new Queue<IBlock>();
            blocks.Enqueue(new DelayBlock(dt, SystemSettings.Delay));
            blocks.Enqueue(new IntegralBlock(dt));
            blocks.Enqueue(new InterferenceBlock(SystemSettings.Interference));
            Object = new ComplexBlock(blocks);

            Regulator = new Regulator(dt);
        }

        public double CalculateWaterLevel()
        {
            if (WorkMode == WorkMode.Automatic)
            {
                var e = Regulator.RegulatorTask - WaterLevel;

                InputStream = Regulator.Regulate(e);
            }

            var inputValue = InputStreamBlock.Calculate(InputStream) - SystemSettings.OutputStream;
            var result = Object.Calculate(inputValue);

            WaterLevel = result;

            if (WaterLevel <= 0)
            {
                WaterLevel = 0;

                if (inputValue < 0)
                {
                    foreach (var block in Object.Blocks)
                    {
                        var integralBlock = block as IntegralBlock;

                        if (integralBlock != null)
                        {
                            integralBlock.StepBackAtLimitValue();
                        }
                    }
                }
            }

            if (WaterLevel >= SystemSettings.WaterLevelLimit)
            {
                WaterLevel = SystemSettings.WaterLevelLimit;

                if (inputValue > 0)
                {
                    foreach (var block in Object.Blocks)
                    {
                        var integralBlock = block as IntegralBlock;

                        if (integralBlock != null)
                        {
                            integralBlock.StepBackAtLimitValue();
                        }
                    }
                }
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
