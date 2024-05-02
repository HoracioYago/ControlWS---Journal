using UnityEngine;
using UnityEngine.InputSystem;

public class JournalMenu : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPageIndex = 0;

    public GameObject[] choices;
    private int currentChoiceIndex = 0;
    public GameObject selectIcon;

    public void TurnPage(InputAction.CallbackContext context)
    {
        if(context.performed) return;
        pages[currentPageIndex].SetActive(false);
        float direction = context.ReadValue<Vector2>().x;
        //float direction = Mathf.Sign(Input.GetAxis("Horizontal"))*1;
        currentPageIndex += (int)direction;
        if (currentPageIndex >= pages.Length)
        {
            currentPageIndex = 0; 
        }
        else if (currentPageIndex < 0)
        {
            currentPageIndex = pages.Length - 1;
        }

        pages[currentPageIndex].SetActive(true);
    }

    public void ScrollIndex(InputAction.CallbackContext context)
    {

            float direction = Mathf.Sign(Input.GetAxis("Vertical")) * 1;
            currentChoiceIndex += (int)direction;
            if (currentChoiceIndex >= choices.Length)
            {
                currentChoiceIndex = 0;
            }
            else if (currentChoiceIndex < 0)
            {
                currentChoiceIndex = choices.Length - 1;
            }

            selectIcon.transform.position = choices[currentChoiceIndex].transform.position;
        
    }

    public void SelectPage(InputAction.CallbackContext context)
    {
        pages[currentPageIndex].SetActive(false);

        currentPageIndex = currentChoiceIndex + 1;

        pages[currentPageIndex].SetActive(true);
    }

    public void BackToIndex(InputAction.CallbackContext context)
    {
        pages[currentPageIndex].SetActive(false);

        currentPageIndex = 0;

        pages[currentPageIndex].SetActive(true);
    }
}

