using System.Collections;
using UnityEngine;
using SuperPupSystems.Helper;

public class enemyMovement : MonoBehaviour
{
    public GameObject hiddenplace;
    public GameObject exposedplace;
    public Timer hideTimer;
    public Timer popOutTimer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopOut()
    {
        gameObject.transform.position = exposedplace.transform.position;
        float time = Random.Range(3.0f, 6.0f);
        hideTimer.StartTimer(time);
    }

    public void Hide()
    {
        gameObject.transform.position = hiddenplace.transform.position;
        float time = Random.Range(3.0f, 6.0f);
        popOutTimer.StartTimer(time);
    }

    public void Damage()
    {
        popOutTimer.StopTimer();
        hideTimer.StopTimer();
        Hide();
    }
}
