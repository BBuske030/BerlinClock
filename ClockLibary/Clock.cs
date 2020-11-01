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
            string indicator = "O";

            try
            {
                indicator = (currentTime.Seconds % 2) == 0 ? "Y" : "O";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return indicator;
        }

        /// <summary>
        /// Returns the five hours indicator string for the four lamps in a row. Every red lamp represent five hours.
        /// </summary>
        /// <returns>A String with length(4) R = Red; O = Off</returns>
        public string GetFiveHoursIndicatorString()
        {
            string indicator = "";

            try
            {
                int hours = currentTime.Hours;
                hours = (int)Math.Floor((double)(hours * 5) / 24);
                indicator = indicator.PadRight(hours, 'R');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                indicator = indicator.PadRight(4, 'O');
            }

            return indicator;
        }

        /// <summary>
        /// Returns the one hour indicator string for the four lamps in a row. Every red lamp represent one hour.
        /// </summary>
        /// <returns>A String with length(4) R = Red; O = Off</returns>
        public string GetOneHourIndicatorString()
        {
            string indicator = "";

            try
            {
                int hours = currentTime.Hours;
                hours %= 5;
                indicator = indicator.PadRight(hours, 'R');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                indicator = indicator.PadRight(4, 'O');
            }

            return indicator;
        }

        /// <summary>
        /// Returns the five minutes indicator string for the eleven lamps in a row. One Lamp represent five minutes.
        /// Every third lamp is red and represent a quarter of an hour, the other lamps are yellow.
        /// </summary>
        /// <returns>A String with length(11) Y = Yellow; R = Red; O = Off</returns>
        public string GetFiveMinutesIndicatorString()
        {
            string indicator = "";

            try
            {
                int minutes = currentTime.Minutes;

                for (int i = 5; i <= minutes; i += 5)
                {
                    if (i % 15 == 0)
                    {
                        indicator += "R";
                    }
                    else
                    {
                        indicator += "Y";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                indicator = indicator.PadRight(11, 'O');
            }

            return indicator;
        }


        /// <summary>
        /// Returns the one minute indicator string for the four lamps in a row. Every yellow lamp represent one minute.
        /// </summary>
        /// <returns>A String with length(4) Y = Yellow; O = Off</returns>
        public string GetOneMinuteIndicatorString()
        {
            string indicator = "";

            try
            {
                int minutes = currentTime.Minutes;
                minutes %= 5;
                indicator = indicator.PadRight(minutes, 'Y');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                indicator = indicator.PadRight(4, 'O');
            }

            return indicator;
        }
    }
}
