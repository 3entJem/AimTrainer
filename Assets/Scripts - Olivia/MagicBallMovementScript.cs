using UnityEngine;

public class MagicBallMovementScript : MonoBehaviour
{
    public float followspeed = 5f;
    private Transform playerTransform;
    public float distanceThreshold = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player object with tag 'Player' not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, followspeed * Time.deltaTime);

            float distance = Vector3.Distance(transform.position, playerTransform.position);

            if (distance < distanceThreshold)
            {
                gameObject.SetActive(false);
            }
        }

        
            
    }
}
