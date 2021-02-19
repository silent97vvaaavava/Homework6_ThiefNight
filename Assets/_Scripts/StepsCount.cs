using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepsCount : Controller, IControllerGame
{
    
    [SerializeField] private float steps;

    private void Update()
    {
        ShowWindow(steps);
        ShowCount(steps);
    }


    public new void ChangeCount()
    {
        if (steps > 0)
        {
            steps--;
        }
    }


}
