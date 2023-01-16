using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNode : MonoBehaviour
{
    public int NodeIndex;

    public Transform[] SpawnPoint;
    public Transform Destination;
    public List<NodeArrangement> NodeArrangements = new List<NodeArrangement>();  




    private void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.A))
        {

            SpawnNewNode();
        }
    }



    public void SpawnNextNode(GameObject nodeObject, Transform pointToSpawn)
    {
        GameObject newNode = Instantiate(nodeObject, pointToSpawn.position, Quaternion.identity);
        newNode.GetComponent<Node>().DestinationPoint = Destination;
        
    }

    public void SpawnNewNode()
    {
        for (int i = 0; i < NodeArrangements.Count; i++)
        {
            SpawnNextNode(NodeArrangements[i].NodeRow[NodeIndex], SpawnPoint[i]);
        }
        NodeIndex++;
    }
}
