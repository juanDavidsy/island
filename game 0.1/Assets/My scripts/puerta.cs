using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta : MonoBehaviour
{
    public Animator animator;

  

    public void OnOpenDoor()
    {
        animator.SetTrigger("Open");
    }


}
