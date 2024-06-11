using UnityEngine;
using UnityEngine.UI;

public class InputIconManager : MonoBehaviour
{
    public Sprite[] keyboardIcons;
    public Sprite[] gamepadIcons;
    public Image[] actionIcons;

    private bool isGamepadActive = false;

    void Update()
    {
        if (Input.GetJoystickNames().Length > 0)
        {
            isGamepadActive = true;
            ChangeIcons(gamepadIcons);
        }
        else
        {
            isGamepadActive = false;
            ChangeIcons(keyboardIcons);
        }
    }

    void ChangeIcons(Sprite[] newIcons)
    {
        for (int i = 0; i < actionIcons.Length; i++)
        {
            if (i < newIcons.Length)
            {
                actionIcons[i].sprite = newIcons[i];
            }
        }
    }
}