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
            Clock clock = new Clock(TimeSpan.Parse("00:00:00"));
            String indicator = clock.GetTwoSecoundsIndicatorString();

            // Test output String length
            Assert.Equal(1, indicator.Length);

            // Test for secound lamp indicator string (lamp on)
            Assert.Equal("Y", indicator);

            // Test for secound lamp indicator string (lamp off)
            clock = new Clock(TimeSpan.Parse("00:00:01"));
            indicator = clock.GetTwoSecoundsIndicatorString();

            Assert.Equal("O", indicator);
        }

        [Fact]
        public void TestFiveHoursIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("00:00:00"));
            String indicator = clock.GetFiveHoursIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for five hours indicator string (all lamps off)
            Assert.Equal("OOOO", indicator);

            clock = new Clock(TimeSpan.Parse("23:00:00"));
            indicator = clock.GetFiveHoursIndicatorString();

            // Test output String length (all lamps on)
            Assert.Equal(4, indicator.Length);

            // Test for five hours indicator string
            Assert.Equal("RRRR", indicator);
        }

        [Fact]
        public void TestOneHourIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("05:00:00"));
            String indicator = clock.GetOneHourIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one hour indicator string (all lamps off)
            Assert.Equal("OOOO", indicator);

            clock = new Clock(TimeSpan.Parse("14:00:00"));
            indicator = clock.GetOneHourIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one hour indicator string (all lamps on)
            Assert.Equal("RRRR", indicator);
        }

        [Fact]
        public void TestFiveMinutesIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("00:00:00"));
            String indicator = clock.GetFiveMinutesIndicatorString();

            // Test output String length
            Assert.Equal(11, indicator.Length);

            // Test for five minutes indicator string (all lamps off)
            Assert.Equal("OOOOOOOOOOO", indicator);

            clock = new Clock(TimeSpan.Parse("00:59:00"));
            indicator = clock.GetFiveMinutesIndicatorString();

            // Test output String length
            Assert.Equal(11, indicator.Length);

            // Test for five minutes indicator string (all lamps on, every third must be red)
            Assert.Equal("YYRYYRYYRYY", indicator);
        }

        [Fact]
        public void TestOneMinuteIndicatorString()
        {
            Clock clock = new Clock(TimeSpan.Parse("00:15:00"));
            String indicator = clock.GetOneMinuteIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one minute indicator string (all lamps off)
            Assert.Equal("OOOO", indicator);

            clock = new Clock(TimeSpan.Parse("00:19:00"));
            indicator = clock.GetOneMinuteIndicatorString();

            // Test output String length
            Assert.Equal(4, indicator.Length);

            // Test for one minute indicator string (all lamps on)
            Assert.Equal("YYYY", indicator);
        }
    }
}
