using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeRemover : MonoBehaviour
{
    [SerializeField] private GameManager instance;

    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Node")
        {
            Debug.Log("Node Destroyted");
            instance.TotalHealthPoint--;
            Destroy(collision.gameObject);
        }
    }
}
