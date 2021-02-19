using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _CloudMove : MoveGO
{
    [Header("Set in Inspector")]
    private GameObject currentCloud;
    

    private void Start()
    {
        transform.position = startPosition;
    }

    private void Update()
    {
        if(transform.position.x == endPosition.x)
        {
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate()
    {
        CreatedNewCloud();
        Move(this.gameObject ,startPosition, endPosition);
    }

    void CreatedNewCloud()
    {
        if (transform.position.x > 0)
        {
            if (!currentCloud)
            {
                currentCloud = Instantiate<GameObject>(this.gameObject, parent: transform.parent);
                currentCloud.name = this.gameObject.name;
            }
        }
    }


}
