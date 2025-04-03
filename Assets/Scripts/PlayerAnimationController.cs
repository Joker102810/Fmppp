using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{

    private Animator animator;
    private GameObject player;

    void Start()
    {
        player = GetComponent<GameObject>();
        animator = GetComponent<Animator>();
    }

    // Call this function to play an animation
    public void PlayAnimation(string animationName)
    {
        //animator.Play(animationName);
    }

    // Call this function to stop an animation
    public void StopAnimation(string animationName)
    {
        animator.StopPlayback();
    }

    // Call this function to transition to a new state
    public void TransitionToState(string stateName)
    {
        animator.SetTrigger(stateName);
    }

    void Update()
    {
        


    }

}