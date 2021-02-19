using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveMoon : MoveGO
{
    [Header("Set in Inspector")]

    //[Tooltip ("Set coordinate for move Moon")]
    //[SerializeField] Vector2 startPosition;
    //[SerializeField] Vector2 endPosition;
    //[SerializeField] float step;

    [Tooltip("Set Animator Value")]
    [SerializeField] Animator animator;
 
    private bool checkMove;




    void Start()
    {
        transform.position = startPosition;
    }

    private void FixedUpdate()
    {
        if (checkMove)
        {
            Move(this.gameObject, startPosition, endPosition);
        }
        if(!checkMove)
        {
            Move(this.gameObject, endPosition, startPosition);
        }

    }

    public void WhereMove()
    {
        this.enabled = true;
        progress = 0;
        checkMove = !checkMove;

        if (animator)
        {
            animator.SetBool(name: "Check", checkMove);
        }
    }
}
