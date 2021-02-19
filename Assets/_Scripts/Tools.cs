using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


    public class Tools : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
    [Header("Set in Inspector")]
    [SerializeField] Text[] pinValue;
    [SerializeField] int[] valueTools;
    [SerializeField] private GameObject windowProperties;
    [SerializeField] private Text[] fieldProperties;
    [SerializeField] private Text nameTool;
    [SerializeField] private Sprite selectedSprite;
    [SerializeField] private Animation lockAnimation;
   

    private Image currentSprite;
    private Button enableButton;

    public int[] ValueTools { get => valueTools; set => valueTools = value; }
    public Animation LockAnimation { get => lockAnimation; set => lockAnimation = value; }
    public Text[] PinValue { get => pinValue; set => pinValue = value; }
    public Button EnableButton { get => enableButton; set => enableButton = value; }

    public virtual void Unlock()
    {

        lockAnimation.Play();

        for (int i = 0; i < pinValue.Length; i++)
        {
            pinValue[i].text = (int.Parse(pinValue[i].text) + valueTools[i]).ToString();
        }
    }
    public virtual void Unlock(Animation clip)
    {
        lockAnimation.Play();
        for (int i = 0; i < pinValue.Length; i++)
        {
            pinValue[i].text = (int.Parse(pinValue[i].text) + valueTools[i]).ToString();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        ShowPropertiesTool();
    }

    private void Awake()
    {
        currentSprite = gameObject.GetComponent<Image>();
        enableButton = gameObject.GetComponent<Button>();
    }

     
    void GetProperties()
    {
        for(int i = 0; i < fieldProperties.Length; i++)
        {
            fieldProperties[i].text = valueTools[i].ToString();
        }
    }

    // подсвечивание инструмента
    protected void HoverOnButton(Sprite current = null)
    {
        if (enableButton.interactable)
        {
            currentSprite.overrideSprite = current;
        } else
        {
            currentSprite.overrideSprite = null;
        }
    }

    //отображение окна свойств
    protected virtual void ShowPropertiesTool()
    {
        HoverOnButton(selectedSprite);  

        if (!windowProperties.activeSelf && enableButton.interactable)
        {
            GetProperties();
            SetNameTool();
            windowProperties.SetActive(true);
        }
    }
   

    // скрывает окно описания при выходе курсора за инструмент
    void HidePropertiesTool()
    {
        HoverOnButton(null);
        if (windowProperties.activeSelf)
        {
            windowProperties.SetActive(false);
        }
    }

    // имя окна описания
    void SetNameTool()
    {
        nameTool.text = gameObject.transform.GetChild(0).GetComponent<Text>().text;
    }

    // блокировка инструмента когда значения меньше значений пинов
    protected void BlockTool()
    {
        for(int i = 0; i < pinValue.Length; i++)
        {
            if((int.Parse(pinValue[i].text)+valueTools[i]) < 0)
            {
                enableButton.interactable = false;
                break;
            } else
            {
                enableButton.interactable = true;

            }
        }
    }

    

    public void OnPointerExit(PointerEventData eventData)
    {
        HidePropertiesTool();
    }


}

    


