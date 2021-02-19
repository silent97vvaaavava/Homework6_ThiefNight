using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Move character and work her Animation
/// </summary>
public class CharacterAnimation : MoveGO
{
    [Tooltip("Get Animator BG")]
    [SerializeField] Animator animatorBG;

    private static readonly int Value = Animator.StringToHash(name: "Value");
    private Animator animator;

    private void Awake()
    {
        if (!animator)
        {
            animator = gameObject.GetComponent<Animator>();
        }
    }

    private void FixedUpdate()
    {
        if(!animatorBG.GetCurrentAnimatorStateInfo(0).IsName("PreviewStartGame"))
        Move(this.gameObject, startPosition, endPosition);

        StartIdleAnimation();
    }

    void StartIdleAnimation()
    {
        if(transform.position.x >= endPosition.x)
        {
            animator.SetBool(id: Value, true);
            Invoke("Transition", 1f);
        }
    }

    void Transition()
    {
        animatorBG.SetBool(name: "Transition", true);
    }
}
