using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

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
        if (isShowing || Keyboard.current == null) return;

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            StartCoroutine(ShowDirection(up));
        }
        else if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            StartCoroutine(ShowDirection(down));
        }
        else if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            StartCoroutine(ShowDirection(left));
        }
        else if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            StartCoroutine(ShowDirection(right));
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