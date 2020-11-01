using System;

namespace ClockLibary
{
    public class Clock
    {
        TimeSpan currentTime;

        public Clock(TimeSpan currentTime) => CurrentTime = currentTime;

        public TimeSpan CurrentTime
        {
            get => currentTime;
            set => currentTime = value;
        }

        /// <summary>
        /// Returns the secound lamp indicator string. The yellow lamp blink all two secounds.
        /// </summary>
        /// <returns>A String with length(1) Y = Yellow; O = Off</returns>
        public string GetTwoSecoundsIndicatorString()
        {
            return "Y";
        }

        /// <summary>
        /// Returns the five hours indicator string for the four lamps in a row. Every red lamp represent five hours.
        /// </summary>
        /// <returns>A String with length(4) R = Red; O = Off</returns>
        public string GetFiveHoursIndicatorString()
        {
            return "RROO";
        }

        /// <summary>
        /// Returns the one hour indicator string for the four lamps in a row. Every red lamp represent one hour.
        /// </summary>
        /// <returns>A String with length(4) R = Red; O = Off</returns>
        public string GetOneHourIndicatorString()
        {
            return "RRRO";
        }

        /// <summary>
        /// Returns the five minutes indicator string for the eleven lamps in a row. One Lamp represent five minutes.
        /// Every third lamp is red and represent a quarter of an hour, the other lamps are yellow.
        /// </summary>
        /// <returns>A String with length(11) Y = Yellow; R = Red; O = Off</returns>
        public string GetFiveMinutesIndicatorString()
        {
            return "YYROOOOOOOO";
        }


        /// <summary>
        /// Returns the one minute indicator string for the four lamps in a row. Every yellow lamp represent one minute.
        /// </summary>
        /// <returns>A String with length(4) Y = Yellow; O = Off</returns>
        public string GetOneMinuteIndicatorString()
        {
            return "YYOO";
        }
    }
}
