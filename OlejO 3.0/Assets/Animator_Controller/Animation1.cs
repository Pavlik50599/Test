using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation1 : MonoBehaviour
{
    public Animator objectAnimator;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            {
                objectAnimator.SetBool("Play position", !objectAnimator.GetBool("Play position"));
            }

        if (Input.GetKeyDown(KeyCode.RightShift))
            {
                objectAnimator.SetBool("Play rotation", !objectAnimator.GetBool("Play rotation"));
            }

        if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                objectAnimator.SetBool("Play scale", !objectAnimator.GetBool("Play scale"));
            }
    }   
}
