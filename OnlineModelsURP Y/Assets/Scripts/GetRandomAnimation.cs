using System.Collections;
using System.Globalization;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class GetRandomAnimation : MonoBehaviour
{
    public Animator animator;
    public string[] animationNames;
    private int current = 0;
    private bool finished = false;
    private int num;
    private float nextChange = 0f;
    public float changeTime = 3f;
    private void FixedUpdate()
    {
        AnimFinished();
        if (finished == true)
        {
            GetNumber();
            animator.SetInteger("State", current);
            finished = false;
        }
    }

    void GetNumber()
    {
        current = Random.Range(0, animationNames.Length - 1);
    }

    void AnimFinished()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("New State"))
        {
            finished = true;
        }
    }
}
