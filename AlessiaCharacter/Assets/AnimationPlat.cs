using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlat : MonoBehaviour
{
    public string animationName;
    public Animator animator;
    public void AnimationWalk() 
    {
        animator.Play(animationName);
    }

    public void AnimationJump()
    {
        animator.Play(animationName);
    }

    public void AnimationIdle()
    {
        animator.Play(animationName);
    }
}
