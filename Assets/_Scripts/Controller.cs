using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Controller : MonoBehaviour, IControllerGame
{
    [SerializeField] private Text timerText;
    [SerializeField] private GameObject[] windows;
    [SerializeField] private Text[] pin;
    [SerializeField] private Animator unlockAnimator;

    public void ActiveWindow(int num)
    {
        if (!windows[num].activeSelf)
        {
            windows[num].SetActive(true);
        }
    }

    public float ChangeCount()
    {
        return 5f;
    }

    public bool CheckWindow()
    {
        if (windows[0].activeSelf)
        {
            return windows[0].activeSelf;
        } else
            if (windows[1].activeSelf)
        {
            return windows[1].activeSelf;
        } else
        {
            return false;
        }
    }

    public bool EqualsPin()
    {
        bool check = false;
        for (int i = 0; i < pin.Length; i++)
        {
            if (i != pin.Length - 1)
            {
                if (pin[i].text.Equals(pin[i + 1].text))
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
            else
            {
                if (int.Parse(pin[i].text) == 0)
                    check = true;
            }
        }

        return check;
    }

    public void ShowAnimation()
    {
        unlockAnimator.SetBool("EqualsPinValue", EqualsPin());
    }


    public void ShowCount(float count)
    {
        if (count >= 0)
        {
            timerText.text = count.ToString();
        }
    }

    public void ShowWindow(float count)
    {
        if (count <= 0)
        {
            ActiveWindow(0);
        }
        else
          if (EqualsPin())
        {
            ShowAnimation();    
        }
    }
}
