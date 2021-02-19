using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GoToRules : Tools, IPointerExitHandler, IPointerEnterHandler
{
    [SerializeField] Animation clipDescription;

    public new void OnPointerExit(PointerEventData eventData)
    {
        HoverOnButton(null);
    }

    protected override void ShowPropertiesTool()
    {
        base.ShowPropertiesTool();
    }


    public override void Unlock(Animation clip)
    {
        clip.Play();
        base.Unlock();
    }
}
