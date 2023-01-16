using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public GameObject[] HealthPoints;
    [SerializeField] private GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateHealth()
    {
        HealthPoints[instance.TotalHealthPoint].SetActive(!gameObject.activeInHierarchy);
    }
}
