using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoTools : Tools
{
   public void GetLastValueTool(Tools currentTool)
    {
        for(int i = 0; i < ValueTools.Length; i++)
        {
            ValueTools[i] = -(currentTool.ValueTools[i]); 
        }
        EnableButton.interactable = true;

    }

    public override void Unlock()
    {
        LockAnimation.Play();

        for (int i = 0; i < PinValue.Length; i++)
        {
            PinValue[i].text = (int.Parse(PinValue[i].text) + ValueTools[i]).ToString();
        }

        EnableButton.interactable = false;
    }
}
