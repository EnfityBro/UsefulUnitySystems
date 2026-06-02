/// <summary>
/// Seconds converter to various string time formats.
/// </summary>
public class StringTimer
{
    /// <summary>
    /// Converts seconds to a string like mm:ss and hh:mm:ss if the seconds count is more than 3600.
    /// </summary>
    public static string ElectronicFormat(int time)
    {
        string displayedTime = "";

        if (time < 60)
        {
            if (time < 10)
                displayedTime = $"00:0{time}";
            else
                displayedTime = $"00:{time}";
        }
        else if ((time >= 60) && (time < 3600))
        {
            if ((int)(time / 60.0) < 10)
            {
                if (time % 60 < 10)
                    displayedTime = $"0{(int)(time / 60)}:0{time % 60}";
                else
                    displayedTime = $"0{(int)(time / 60)}:{time % 60}";
            }
            else
            {
                if (time % 60 < 10)
                    displayedTime = $"{(int)(time / 60)}:0{time % 60}";
                else
                    displayedTime = $"{(int)(time / 60)}:{time % 60}";
            }
        }
        else if (time >= 3600)
        {
            int hour = 0;

            if (time / 3600 > 1)
            {
                hour = ((int)time / 3600) - 1;
                time -= (3600 * hour);
            }

            if (hour + 1 < 10)
            {
                if ((int)((time - 3600) / 60) < 10)
                {
                    if (time % 60 < 10)
                        displayedTime = $"0{hour + 1}:0{(int)((time - 3600) / 60)}:0{time % 60}";
                    else
                        displayedTime = $"0{hour + 1}:0{(int)((time - 3600) / 60)}:{time % 60}";
                }
                else
                {
                    if (time % 60 < 10)
                        displayedTime = $"0{hour + 1}:{(int)((time - 3600) / 60)}:0{time % 60}";
                    else
                        displayedTime = $"0{hour + 1}:{(int)((time - 3600) / 60)}:{time % 60}";
                }
            }
            else
            {
                if ((int)((time - 3600) / 60) < 10)
                {
                    if (time % 60 < 10)
                        displayedTime = $"{hour + 1}:0{(int)((time - 3600) / 60)}:0{time % 60}";
                    else
                        displayedTime = $"{hour + 1}:0{(int)((time - 3600) / 60)}:{time % 60}";
                }
                else
                {
                    if (time % 60 < 10)
                        displayedTime = $"{hour + 1}:{(int)((time - 3600) / 60)}:0{time % 60}";
                    else
                        displayedTime = $"{hour + 1}:{(int)((time - 3600) / 60)}:{time % 60}";
                }
            }
        }

        return displayedTime;
    }

    /// <summary>
    /// Converts seconds to a string like _s, _m _s if the seconds count is more than 60 and _h _m _s if the seconds count is more than 3600.
    /// </summary>
    public static string TextFormat(int time)
    {
        string displayedTime = "";

        if (time < 60)
        {
            displayedTime = $"{time}s";
        }
        else if ((time >= 60) && (time < 3600))
        {
            if (time % 60 == 0)
                displayedTime = $"{(int)(time / 60)}m";
            else
                displayedTime = $"{(int)(time / 60)}m {time % 60}s";
        }
        else if (time >= 3600)
        {
            int hour = 0;

            if (time / 3600 > 1)
            {
                hour = ((int)time / 3600) - 1;
                time -= (3600 * hour);
            }

            if ((int)((time - 3600) / 60) == 0)
            {
                if (time % 60 == 0)
                    displayedTime = $"{hour + 1}h";
                else
                    displayedTime = $"{hour + 1}h {time % 60}s";
            }
            else
            {
                if (time % 60 == 0)
                    displayedTime = $"{hour + 1}h {(int)((time - 3600) / 60)}m";
                else
                    displayedTime = $"{hour + 1}h {(int)((time - 3600) / 60)}m {time % 60}s";
            }
        }

        return displayedTime;
    }
}



/*

How to use:
1. Just call the public static methods "ElectronicFormat" or "TextFormat" from your script.


Documentation:
- The integer parameter "time" is the displayed time, which will be converted to the "string time" format.
  You can also pass the float parameter just by using: (int)someFloatValue.


Comment:
- You can use this method for timers or clocks in your game.

*/