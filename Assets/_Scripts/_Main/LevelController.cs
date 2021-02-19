using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelController : MonoBehaviour
{
    [Header("Get components")]
    [Tooltip("Set number level")]
    [SerializeField] private Text numberLvl;

    void SetLevel()
    {
        if(numberLvl.text != this.gameObject.name)
        numberLvl.text = this.gameObject.name;
    }

    private void Update()
    {
        SetLevel();
    }
}
