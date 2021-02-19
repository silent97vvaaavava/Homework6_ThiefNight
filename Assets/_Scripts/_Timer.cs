using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Timer : Controller, IControllerGame
{
    [SerializeField] int time;

    private void Update()
    {
        ShowWindow(ChangeCount());
        ShowCount(ChangeCount());
    }

    public new float ChangeCount()
    {
        if (!CheckWindow())
        {
            return Mathf.Round(time - Time.time);
        }
        else
        {
            return Mathf.Round(time);
        }
    }
}