using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    void Start()
    {
        up.SetActive(false);
        down.SetActive(false);
        left.SetActive(false);
        right.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
