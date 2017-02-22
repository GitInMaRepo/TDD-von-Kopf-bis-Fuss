using System;

namespace Lebowski_Special
{
    public class Frame
    {
        public Frame()
        {
        }

        public bool IsSpare { get; set; }
        public bool IsStrike { get; set; }
        public int ResultValue { get; set; }
        public string Roll1 { get; set; }
        public string Roll2 { get; set; }

        public void Calculate()
        {
            var roll1 = Convert.ToInt32(Roll1);
            if (roll1 == 10)
            {
                IsStrike = true;
                return;
            }
            var roll2 = Convert.ToInt32(Roll2);
            ResultValue = roll1 + roll2;
            if (ResultValue == 10)
            {
                IsSpare = true;
            }
        }
    }
}