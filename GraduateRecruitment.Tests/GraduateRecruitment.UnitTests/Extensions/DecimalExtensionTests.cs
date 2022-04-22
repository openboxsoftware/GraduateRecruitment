using FluentAssertions;
using GraduateRecruitment.ConsoleApp.Extensions;
using NUnit.Framework;

namespace GraduateRecruitment.UnitTests.Extensions
{
    [TestFixture]
    internal class DecimalExtensionTests
    {
        [Test]
        public void RoundToInt_When_FirstDecimalPointIsFive_Then_RoundsUp()
        {
            var inputDecimal = 17.5M;

            var result = inputDecimal.RoundToInt();

            result.Should().Be(18);
        }

        [Test]
        public void RoundToInt_When_FirstDecimalPointIsGreaterThanFive_Then_RoundsUp()
        {
            var inputDecimal = 17.6M;

            var result = inputDecimal.RoundToInt();

            result.Should().Be(18);
        }

        [Test]
        public void RoundToInt_When_FirstDecimalPointIsLessThanFive_Then_RoundsDown()
        {
            var inputDecimal = 17.4M;

            var result = inputDecimal.RoundToInt();

            result.Should().Be(17);
        }
    }
}