using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public GameObject heart1image;
    public GameObject heart2image;
    public GameObject heart3image;
    public int heartnum = 3;
    private bool canTakeDamage = true;
    public float damageCooldown = 3f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        heart1image.SetActive(true);
        heart2image.SetActive(true);
        heart3image.SetActive(true);

        //GameObject player = GameObject.FindGameObjectWithTag("Player");
       // Collider playercollider = player.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (heartnum == 2)
        {
            heart1image.SetActive (false);
        }

        if (heartnum == 1)
        {
            heart1image.SetActive(false);
            heart2image.SetActive (false);
        }

        if (heartnum == 0)
        {
            heart1image.SetActive(false);
            heart2image.SetActive(false);
            heart3image.SetActive(false);
            Debug.Log("Waiting for seconds");
            new WaitForSeconds(10f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MagicBall") && canTakeDamage)
        {
            heartnum--;
            canTakeDamage = false;
            Destroy(other.gameObject);
            //StartCoroutine(ResetDamageCooldown());
        }
    }

    /*private IEnumerator ResetDamageCooldown()
    {
        yield return new WaitForSeconds(damageCooldown);
        canTakeDamage = true;
    }*/

}
