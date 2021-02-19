using UnityEngine;

public interface IControllerGame
{
    float ChangeCount();
    void ShowCount(float count);
    void ShowWindow(float count);
    bool EqualsPin();
    void ActiveWindow(int num);
    bool CheckWindow();
    void ShowAnimation();
}
