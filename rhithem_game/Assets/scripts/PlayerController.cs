using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;

    private bool isShowing = false;

    void Start()
    {
        up.SetActive(false);
        down.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
    }

    void Update()
    {
        if (!isShowing)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                StartCoroutine(ShowDirection(up));
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                StartCoroutine(ShowDirection(down));
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                StartCoroutine(ShowDirection(left));
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                StartCoroutine(ShowDirection(right));
            }
        }
    }

    IEnumerator ShowDirection(GameObject direction)
    {
        isShowing = true;

        direction.SetActive(true);

        yield return new WaitForSeconds(0.1f);

        direction.SetActive(false);

        isShowing = false;
    }
}
