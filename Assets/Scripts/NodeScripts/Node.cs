using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Transform DestinationPoint;

    public Vector3 jumpDirectionCorrected;
    public Vector3 StartPosition;
    public Vector3 EndPosition;

    // Start is called before the first frame update
    void Start()
    {
        jumpDirectionCorrected =  DestinationPoint.position - transform.position;
        jumpDirectionCorrected = jumpDirectionCorrected / 6f;

        StartPosition = transform.position;
        EndPosition = transform.position += jumpDirectionCorrected;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
