using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrilliantApplication
{
    public static class SystemSettings
    {
        static public double T { get; } = 50;
        static public double Gain { get; } = 25;
        static public double WaterLevelLimit { get; } = 1;
        static public double MaxInputStream { get; } = 0.1;
        static public double RecommendedStep { get; } = 0.01;
    }
}
