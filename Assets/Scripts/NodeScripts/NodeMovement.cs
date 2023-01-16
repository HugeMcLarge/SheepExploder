using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Node Node;
    public AnimationCurve AnimCurve;
    
    public bool IsPaused;
    private float percentageComplete;
    private float Duration = 1f;
    [SerializeField] private float speed;
    private float timer;

    public float Timer
    {
        get { return timer; }
        
        set { 
            if (value >= 1) 
            {
                timer = 0;
                IsPaused = !IsPaused;
                if (!IsPaused)
                {
                    UpdatPosition();
                }
                
            }
            else
            {
                timer = value;
            }
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        Node = GetComponent<Node>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += speed * Time.deltaTime;
        if (!IsPaused)
        {          
            percentageComplete = Timer / Duration;
            transform.position = Vector3.Lerp(Node.StartPosition, Node.EndPosition, AnimCurve.Evaluate(percentageComplete));
        }
    }

    public void UpdatPosition()
    {
        
        Node.EndPosition += Node.jumpDirectionCorrected;
        Node.StartPosition = transform.position;
        percentageComplete = 0;
        //Debug.Log("Start: " + Node.StartPosition);
        //Debug.Log("End: " +Node.EndPosition);
    }
}
