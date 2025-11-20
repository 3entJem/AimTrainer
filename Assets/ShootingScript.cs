using UnityEngine;
using TMPro;

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
            if (Physics.Raycast(FirePoint.position, transform.TransformDirection(Vector3.forward), out hit, 100))
            {
                Debug.DrawRay(FirePoint.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if(hit.transform.name == "Cube Target")
                {
                    Debug.Log("Target Hit!");
                    score++;
                    scoreText.text = "Score: " + score.ToString();
                    hit.collider.gameObject.GetComponent<RandomMove>().MoveSquare();
                }
                else
                {
                    Debug.Log("Miss!");
                }
            }
        }
        

    }
}
