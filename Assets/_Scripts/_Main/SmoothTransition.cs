using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothTransition : MonoBehaviour
{
    [Header("Set in Inspector")]
    [Tooltip("Get animation for transition")]
    [SerializeField] Animation currentMenu;
    [SerializeField] Animation nextMenuAnim;
    [SerializeField] Animation lamp;
    [SerializeField] GameObject nextMenu;
    [SerializeField] string nameAnimationLamp;
    [SerializeField] string nameAnimationCurrent;
    [SerializeField] string nameAnimationNext;


    public void StartTransition()
    {
        if (nameAnimationCurrent != "")
        {
            currentMenu.Play(nameAnimationCurrent);
        }
        else
        {
            NextAnimation();
        }
        if (lamp)
        {
            lamp.Play(nameAnimationLamp);
        }
    }

    void NextAnimation()
    {
        if (nextMenuAnim)
        {
            nextMenu.SetActive(true);
            nextMenuAnim.Play(nameAnimationNext);
            gameObject.SetActive(false);
        } else
        {
            nextMenu.SetActive(true);

            Debug.Log("none animation");
            gameObject.SetActive(false);

        }
    }

}
