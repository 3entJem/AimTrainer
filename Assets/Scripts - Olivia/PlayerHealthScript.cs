using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerHealthScript : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioSource audioSrc2;

    public GameObject heart1image;
    public GameObject heart2image;
    public GameObject heart3image;
    public int heartnum = 3;
    public TextMeshProUGUI EndingText;
    public GameObject EndText;
    
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
            ToEndGame();
        }
    }

    public void Attack()
    {
        audioSrc2.Play();
        heartnum--;
        if (heartnum == 0)
        {
            audioSrc.Play();
        }
    }
        

    public void ToEndGame()
    {
        Time.timeScale = 0f;
        PresentingScore();
        EndText.SetActive(true);
       
    }

    public void PresentingScore()
    {
        EndingText.text = "Your score is " + shootingScript.score.ToString() + ". To restart game, press esc.";
    }


  

}
