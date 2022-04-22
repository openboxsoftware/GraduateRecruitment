using System;

namespace GraduateRecruitment.ConsoleApp.Extensions
{
    internal static class DecimalExtensions
    {
        internal static int RoundToInt(this decimal inputDecimal)
        {
            var roundedDecimal = Math.Round(inputDecimal, 0, MidpointRounding.AwayFromZero);
            return (int)roundedDecimal;
        }
    }
}