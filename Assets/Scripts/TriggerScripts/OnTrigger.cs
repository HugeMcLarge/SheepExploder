using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public KeyCode PressedKey;
    public Sprite PressedButton;
    public Sprite DefaultButton; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node")
        {
            //gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node")
        {
            //collision.gameObject.SetActive(false);
        }
    }
}
