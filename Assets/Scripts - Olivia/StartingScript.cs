using UnityEngine;


public class StartingScript : MonoBehaviour
{
    public GameObject instruction;
    public GameObject startButton;
    public GameObject player;
    public MonoBehaviour FirstPersonCam;
    public MonoBehaviour ShootingScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
        FirstPersonCam.enabled = false;
        ShootingScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        instruction.SetActive(false);
        startButton.SetActive(false);
        Time.timeScale = 1f;
        FirstPersonCam.enabled = true;
        ShootingScript.enabled = true;
    }
   

}
