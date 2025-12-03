using UnityEngine;

public class CannonShoot : MonoBehaviour
{


    public GameObject cannonBall;
    public int shootForce = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject projectile = (GameObject)Instantiate(
                cannonBall, transform.position, transform.rotation);
            int shootForce = Random.Range(100, 4000);
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
        };
    }
}