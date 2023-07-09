using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviourSingletonInScene<TooltipSystem>
{
    public Tooltip tooltip;

    public static void Show(string contentKey, string headerKey)
    {
        Get().tooltip.ShowTooltip(contentKey, headerKey);
    }

    public static void Hide()
    {
        Get().tooltip.HideTooltip();
    }
}
