using UnityEngine;
using System.Collections;

public class EnemyPopoutScript : MonoBehaviour
{
    public int seconds = 5;
    public bool RandomBool;
    public float waitAttack = 5f;
    public GameObject magicball;
    public Animator enemyanim;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DelayedAction()
    {
        Debug.Log("Waiting");
        yield return new WaitForSeconds(seconds);
        RandomBool = Random.value > 0.5f;
        if (RandomBool)
        {
            Debug.Log("True");
            MoveCharacter();
            StartCoroutine(AttackHesitate());
        }
        else
        {
            Debug.Log("False");
            StartCoroutine(DelayedAction());
        }
        
    }

    void MoveCharacter()
    {
        Debug.Log("Move");
        enemyanim.Play("enemyout");
    }

    IEnumerator AttackHesitate()
    {
        yield return new WaitForSeconds(waitAttack);
        RaycastHit touch;
        Ray rayToCast = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(rayToCast, out touch))
        {
            enemyanim.Play("enemyback");
            Debug.Log("Move Back");
            StartCoroutine(DelayedAction());
        }
        else { Instantiate(magicball, transform.position, Quaternion.identity); }
            
    }

   public void ToStartTime()
    {
        StartCoroutine(DelayedAction());
    }

}
