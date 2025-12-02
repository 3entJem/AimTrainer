using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class ShootingScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public Transform FirePoint;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(FirePoint.position, transform.TransformDirection(Vector3.forward), out hit, 1000))
            {
                Debug.DrawRay(FirePoint.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Hit " + hit.transform.name);
                if (hit.collider.gameObject.GetComponent<enemyMovement>())
                {
                    Debug.Log("Target Hit!");
                    score++;
                    scoreText.text = "Score: " + score.ToString();
                    // hit.collider.gameObject.GetComponent<RandomMove>().MoveSquare();
                    hit.collider.gameObject.GetComponent<enemyMovement>().Damage();
                }
                else
                {
                    Debug.Log("Miss!");
                }
                
            }
        }

       
        

    }
}
