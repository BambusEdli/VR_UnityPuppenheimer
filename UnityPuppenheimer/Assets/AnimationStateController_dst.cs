using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startWalking()
    {
        animator.SetBool("isWalking", true);
    }
    public void stopWalking()
    {
        animator.SetBool("isWalking", false);
    }
}
