using UnityEngine;

public class JournalMenu : MonoBehaviour
{
    public GameObject[] pages;
    private int currentPageIndex = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            TurnPage(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            TurnPage(-1);
        }
    }

    void TurnPage(int direction)
    {
        pages[currentPageIndex].SetActive(false);

        currentPageIndex += direction;
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
}

