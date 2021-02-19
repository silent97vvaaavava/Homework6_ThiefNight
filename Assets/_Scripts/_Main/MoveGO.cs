using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGO : MonoBehaviour
{
    /// <summary>
    /// moving an gameObject across the scene from one point to a second point 
    /// </summary>


    [Header("Set in Inspector")]
    [Tooltip("Set start point")]
    [SerializeField] protected Vector2 startPosition;
    [Tooltip("Set end point")]
    [SerializeField] protected Vector2 endPosition;
    [SerializeField] protected float step;
    protected float progress;



    protected virtual void Move(GameObject current, Vector2 start, Vector2 end)
    {
        current.transform.position = start;
        transform.position = Vector2.Lerp(start, end, progress);
        progress += step;
    }

    

}
