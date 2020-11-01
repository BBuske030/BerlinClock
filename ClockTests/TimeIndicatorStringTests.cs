using System;
using Xunit;
using ClockLibary;

namespace ClockTests
{
    public class TimeIndicatorStringTests
    {
        [Fact]
        public void TestTwoSecoundsIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("13:17:02"));
            String indicator = clock.GetTwoSecoundsIndicatorString();

            // Test output String length
            Assert.Equal(1, indicator.Length);

            // Test for secound lamp indicator string (indicator on)
            Assert.Equal("Y", indicator);
        }

        [Fact]
        public void TestFiveHoursIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("13:17:02"));
            String indicator = clock.GetFiveHoursIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for five hours indicator string
            Assert.Equal("RROO", indicator);
        }

        [Fact]
        public void TestOneHourIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("13:17:02"));
            String indicator = clock.GetOneHourIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one hour indicator string
            Assert.Equal("RRRO", indicator);
        }

        [Fact]
        public void TestFiveMinutesIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("13:17:02"));
            String indicator = clock.GetFiveMinutesIndicatorString();

            // Test output String length
            Assert.Equal(11, indicator.Length);

            // Test for five minutes indicator string
            Assert.Equal("YYROOOOOOOO", indicator);
        }

        [Fact]
        public void TestOneMinuteIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("13:17:02"));
            String indicator = clock.GetOneMinuteIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one minute indicator string
            Assert.Equal("YYOO", indicator);
        }
    }
}
