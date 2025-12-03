using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RandomMove : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAnimator.Play("E1O");
        myAnimator.Play("E2O");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Active()
    {
        yield return new WaitForSeconds(5f);
        myAnimator.Play("E1O");
        myAnimator.Play("E2I");
        //GetComponent<Collider>().enabled = true;

    }

    public void MoveSquare()
    {
        Debug.Log("MOVE");
        myAnimator.Play("E1I");
        myAnimator.Play("E2I");
        //GetComponent<Collider>().enabled = false;
        StartCoroutine(Active());
    }
}
