using Unity.VisualScripting;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public GameObject heart1image;
    public GameObject heart2image;
    public GameObject heart3image;
    public int heartnum = 3;
    public GameObject EndingText;
    public GameObject RestartingButton;
    public ShootingScript shootingScript;
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        heart1image.SetActive(true);
        heart2image.SetActive(true);
        heart3image.SetActive(true);
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

    public void Attack()
    {
        heartnum--;
    }

    public void ToEndGame()
    {
        Time.timeScale = 0f;
        PresentingScore();
        EndingText.SetActive(true);
        RestartingButton.SetActive(true);
    }

    public void PresentingScore()
    {

    }


  

}
