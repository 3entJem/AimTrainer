using UnityEngine;

public class Billboarded : MonoBehaviour
{
    public GameObject sprite;
    public Camera Camera;
    void Update()
    {
        sprite.transform.rotation = Camera.main.transform.rotation;
    }

}
