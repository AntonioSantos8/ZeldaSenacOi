using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAim : MonoBehaviour
{
    public Animator animator;

    public void AnimationSword()
    {
        Debug.Log("Anima��o de ataque chamada!");
        animator.SetTrigger("Attack");
    }
}