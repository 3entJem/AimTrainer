using TMPro;
using UnityEngine;
using UnityEngine.Audio;

public class ShootingScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public Transform FirePoint;
    public AudioSource audioSource;
    public AudioClip mouseDownAudioClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(mouseDownAudioClip, 1);
            RaycastHit hit;
            if (Physics.Raycast(FirePoint.position, transform.TransformDirection(Vector3.forward), out hit, 100))
            {
                Renderer r = hit.collider.GetComponent<Renderer>();
                Texture2D tex = (Texture2D)r.material.mainTexture;

                Vector2 uv = hit.textureCoord;
                Color pixel = tex.GetPixelBilinear(uv.x, uv.y);
                if (pixel.a < 0.1f)
                {
                    Debug.Log("Miss!");
                }
                else
                {
                    if (hit.transform.name == "Cube Target")
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
}
