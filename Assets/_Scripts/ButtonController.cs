using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonController : MonoBehaviour
{
    // перезагрузка уровня
    // возвращение домой
    // следующий уровень

    [Header("Set in Inspector")]
    [SerializeField] private string[] nameScene; 

    public void GoMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        GetNextLevel();
    }

    void GetNextLevel()
    {
        for(int i = 0; i < nameScene.Length; i++)
        {
            if (nameScene[i].Equals(SceneManager.GetActiveScene().name))
            {
                if (!i.Equals(nameScene.Length - 1))
                {
                    SceneManager.LoadScene(nameScene[i + 1]);
                } else
                {
                    // show window with information about end level
                }
            } 
        }
    } 
}
