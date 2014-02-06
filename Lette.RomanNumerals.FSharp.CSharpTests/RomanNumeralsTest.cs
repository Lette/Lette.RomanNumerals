using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace Lette.RomanNumerals.FSharp.CSharpTests
{
    public class RomanNumeralsTest
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                return new List<object[]>
                    {
                        new object[] { 1, "I" },
                        new object[] { 2, "II" },
                        new object[] { 3, "III" },
                        new object[] { 4, "IV" },
                        new object[] { 5, "V" },
                        new object[] { 6, "VI" },
                        new object[] { 7, "VII" },
                        new object[] { 8, "VIII" },
                        new object[] { 9, "IX" },
                        new object[] { 10, "X" },
                        new object[] { 11, "XI" },
                        new object[] { 18, "XVIII" },
                        new object[] { 19, "XIX" },
                        new object[] { 49, "XLIX" },
                        new object[] { 99, "XCIX" },
                        new object[] { 100, "C" },
                        new object[] { 101, "CI" },
                        new object[] { 499, "CDXCIX" },
                        new object[] { 500, "D" },
                        new object[] { 501, "DI" },
                        new object[] { 899, "DCCCXCIX" },
                        new object[] { 900, "CM" },
                        new object[] { 901, "CMI" },
                        new object[] { 999, "CMXCIX" },
                        new object[] { 1000, "M" },
                        new object[] { 1001, "MI" },
                        new object[] { 4000, "MMMM" },
                        new object[] { 9894, "MMMMMMMMMDCCCXCIV" },
                        new object[] { 10000, "MMMMMMMMMM" },
                        new object[] { 100000, "MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM" }
                    };
            }
        }

        [Theory]
        [PropertyData("TestData")]
        public void Converts_number_to_roman(int number, string expected)
        {
            var converter = new DotNetWrappers.Converter();

            var inRoman = converter.ToRoman(number);

            Assert.Equal(expected, inRoman);
        }
    }
}