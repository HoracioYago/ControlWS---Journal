using UnityEngine;
using UnityEngine.UI;

public class AdaptiveUI : MonoBehaviour
{
    public Sprite keyboardIcon;
    public Sprite gamepadIcon;
    public Image actionIcon;

    private bool isGamepadActive = false;

    void Update()
    {
        if (Input.GetJoystickNames().Length > 0)
        {
            isGamepadActive = true;
            ChangeIcon(gamepadIcon);
        }
        else
        {
            isGamepadActive = false;
            ChangeIcon(keyboardIcon);
        }
    }

    void ChangeIcon(Sprite newIcon)
    {
        actionIcon.sprite = newIcon;
    }
}
