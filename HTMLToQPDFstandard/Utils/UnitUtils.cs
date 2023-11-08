using QuestPDF.Infrastructure;
using System;

namespace HTMLToQPDFstandard.Utils
{
    internal static class UnitUtils
    {
        public static float ToPoints(float value, Unit unit)
        {
            return value * GetConversionFactor();
            float GetConversionFactor()
            {
                switch (unit)
                {
                    case Unit.Point: return 1f;
                    case Unit.Meter: return 2834.64575f;
                    case Unit.Centimetre: return 28.3464565f;
                    case Unit.Millimetre: return 2.83464575f;
                    case Unit.Feet: return 864f;
                    case Unit.Inch: return 72f;
                    case Unit.Mil: return 0.072f;
                    default: throw new ArgumentException("unit", unit.ToString(), null);
                }
            }
        }
    }
}
