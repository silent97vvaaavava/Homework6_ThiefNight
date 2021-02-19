using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TransitionLevel : MonoBehaviour
{
    [Header("Set in Inspector")]
    [SerializeField] Animator animatorBG;

    private string level = "Level_";


    public void WriteNameLevelScene(GameObject numberLevel)
    {
        level += numberLevel.name;
    }

    void LoadSceneLevel()
    {
        if (!animatorBG.GetCurrentAnimatorStateInfo(0).IsName("Transition") && animatorBG.GetBool(name: "Transition"))
        {
            SceneManager.LoadScene(level);
        }
    }

    private void Update()
    {
        LoadSceneLevel();
    }
}
