using UnityEngine;
using System.Collections;

public class EnemyPopoutScript : MonoBehaviour
{
    public int seconds = 5;
    public bool RandomBool;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(DelayedAction());
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
    }


}
