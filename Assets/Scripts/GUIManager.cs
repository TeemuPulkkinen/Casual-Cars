using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : MonoBehaviour
{
    
    private GameObject retryMenu;
    // Start is called before the first frame update
    void Start()
    {
        retryMenu = GameObject.Find("RetryMenu");
        retryMenu.SetActive(false);
    }

    public void PlayerDeath()
    {
        retryMenu.SetActive(true);
    }
}
