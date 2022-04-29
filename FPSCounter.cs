using TMPro;
using UnityEngine;
// * Import Timer Utils

/// <summary>
/// A basic FPS counter.
/// </summary>
internal class FPSCounter : MonoBehaviour
{
    #region Variables
    #region Editor
    [SerializeField, Tooltip("The text component responsible for holding the FPS value.")]
    private TextMeshProUGUI fpsText;
    #endregion
    #region Class
    /// <summary>
    /// Holds the current displayed FPS value from 0 to 999.
    /// <para>We can't use a normal .ToString() call as it creates an entirely new string and generates garbage.</para>
    /// </summary>
    private readonly string[] fpsStrings = new string[1000];

    /// <summary>
    /// The current FPS value.
    /// </summary>
    private int currentFPS;

    /// <summary>
    /// Used for <see cref="TimerUtils.CountTimer(ref float, float)"/> to calculate the FPS every 800ms.
    /// </summary>
    private float timer;
    #endregion
    #endregion

    /// <summary>
    /// Generate strings from 0 to 999, so the max displayed FPS is 999.
    /// </summary>
    private void Start()
    {
        for (var i = 0; i < 1000; i++) fpsStrings[i] = i.ToString();
    }

    /// <summary>
    /// Gets the current FPS.
    /// </summary>
    private void LateUpdate()
    {
        if (!TimerUtils.CountTimer(ref timer, .8f)) return;
        currentFPS = (int) Mathf.Round(1 / Time.unscaledDeltaTime);
        fpsText.text = fpsStrings[currentFPS];
        timer = 0;
    }
}
