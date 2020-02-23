using System;
using System.Collections.Generic;
using System.Text;

using BlocksLibrary.Interfaces;

namespace BlocksLibrary.Blocks
{
    public class IntegralBlock : IBlock, IRefreshable
    {
        private double m_prev = 0;
        private double m_dt;
        private double m_sum = 0;

        public IntegralBlock(double dt)
        {
            m_dt = dt;
        }

        public virtual double Calculate(double input)
        {
            m_sum += (input + m_prev) * m_dt / 2;
            m_prev = input;

            return m_sum;
        }

        public void Refresh()
        {
            m_sum = 0;
            m_prev = 0;
        }
    }
}