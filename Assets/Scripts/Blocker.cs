using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Blocker : MonoBehaviour
{
    GUIManager GUIManager;

    public float blockerSpeed;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        GUIManager = GameObject.Find("GUI").GetComponent<GUIManager>();
        rb2d.velocity = -transform.right * blockerSpeed; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            //SceneManager.LoadScene("MainMenu");
            GUIManager.PlayerDeath();
        }
    }
}
