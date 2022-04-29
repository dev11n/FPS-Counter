using UnityEngine;

/// <summary>
/// Basic timer utils.
/// </summary>
internal class TimerUtils
{
    /// <summary>
    /// Start capturing.
    /// </summary>
    /// <param name="timer"></param>
    /// <param name="reach"></param>
    /// <returns>Whether or not <see cref="timer"/> has reached the value of <see cref="reach"/></returns>
    public static bool CountTimer(ref float timer, float reach)
    {
        timer += Time.deltaTime;
        return timer >= reach;
    }
}
